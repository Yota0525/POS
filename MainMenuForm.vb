Imports System.Data
Imports System.Linq

Public Class MainMenuForm

    ' デザイナーで配置した時の基準サイズ（Form1.Designer.vb の ClientSize と合わせる）
    Private ReadOnly DesignSize As New Size(1024, 768)

    ' メニューボタンの現在表示中のページ番号(0始まり)。1ページにつきボタン9個分
    Private currentMenuPage As Integer = 0
    Private Const MenuButtonsPerPage As Integer = 9

    ' クリックされた部屋ボタンの番号(0〜34)。未選択時は-1
    Private selected_room_button As Integer = -1

    ''' room_button_0〜room_button_34すべてで共有するクリックハンドラ。
    ''' ボタン名(room_button_N)からNを取り出してselected_room_buttonに設定する。
    Private Sub RoomButton_Click(sender As Object, e As EventArgs) Handles _
        room_button_0.Click, room_button_1.Click, room_button_2.Click, room_button_3.Click, room_button_4.Click,
        room_button_5.Click, room_button_6.Click, room_button_7.Click, room_button_8.Click, room_button_9.Click,
        room_button_10.Click, room_button_11.Click, room_button_12.Click, room_button_13.Click, room_button_14.Click,
        room_button_15.Click, room_button_16.Click, room_button_17.Click, room_button_18.Click, room_button_19.Click,
        room_button_20.Click, room_button_21.Click, room_button_22.Click, room_button_23.Click, room_button_24.Click,
        room_button_25.Click, room_button_26.Click, room_button_27.Click, room_button_28.Click, room_button_29.Click,
        room_button_30.Click, room_button_31.Click, room_button_32.Click, room_button_33.Click, room_button_34.Click
        Dim btnName = DirectCast(sender, Control).Name
        selected_room_button = CInt(btnName.Substring("room_button_".Length))

        MsgBox(selected_room_button & " selected!")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Database.InitializeDatabase()
        UpdateRoomButtonTexts()
        RefreshMenuButtons()

        ' 端末ごとに解像度が違うため、配置はそのままに実際の画面サイズへ拡大・縮小する
        Dim targetSize As Size = Screen.PrimaryScreen.Bounds.Size
        Dim scaleFactor As New SizeF(
            targetSize.Width / CSng(DesignSize.Width),
            targetSize.Height / CSng(DesignSize.Height))

        ScaleControls(Me, scaleFactor)

        Me.Bounds = Screen.PrimaryScreen.Bounds
    End Sub

    ' コントロールの位置・サイズ・フォントを指定倍率で再帰的に拡大縮小する
    Private Sub ScaleControls(parent As Control, factor As SizeF)
        For Each ctrl As Control In parent.Controls
            ctrl.Left = CInt(Math.Round(ctrl.Left * factor.Width))
            ctrl.Top = CInt(Math.Round(ctrl.Top * factor.Height))
            ctrl.Width = CInt(Math.Round(ctrl.Width * factor.Width))
            ctrl.Height = CInt(Math.Round(ctrl.Height * factor.Height))

            Dim avgFactor As Single = (factor.Width + factor.Height) / 2.0F
            ctrl.Font = New Font(ctrl.Font.FontFamily, ctrl.Font.Size * avgFactor, ctrl.Font.Style)

            Dim multiLineBtn = TryCast(ctrl, MultiLineButton)
            If multiLineBtn IsNot Nothing Then
                For Each line In multiLineBtn.Lines
                    line.Font = New Font(line.Font.FontFamily, line.Font.Size * avgFactor, line.Font.Style)
                Next
            End If

            If ctrl.Controls.Count > 0 Then
                ScaleControls(ctrl, factor)
            End If
        Next
    End Sub

    Private ReadOnly OccupiedWithinTimeColor As Color = Color.FromArgb(128, 255, 255)
    Private ReadOnly OccupiedOverTimeColor As Color = Color.FromArgb(255, 128, 255)

    ''' DBの部屋情報・入室情報をもとに、各room_buttonの表示(テキスト4行・背景色・有効/無効)を更新する。
    ''' ボタンの画面上の並び順(上→下、左→右)と、DBの部屋番号の昇順を対応させている。
    ''' date_time_timerから毎秒呼び出され、使用中の部屋は残り時間/超過時間がリアルタイムに更新される。
    Private Sub UpdateRoomButtonTexts()
        Dim roomButtons = Me.Controls.OfType(Of MultiLineButton)().
            OrderBy(Function(b) b.Top).
            ThenBy(Function(b) b.Left).
            ToList()

        Dim rooms = Database.GetAllRooms() ' room_noの昇順

        ' 部屋番号 → 使用中の入室情報 のルックアップ
        Dim activeByRoom As New Dictionary(Of Integer, DataRow)
        For Each row As DataRow In Database.GetActiveEntries().Rows
            activeByRoom(CInt(row("room_no"))) = row
        Next

        For i = 0 To roomButtons.Count - 1
            Dim btn = roomButtons(i)

            If i >= rooms.Rows.Count Then
                ' 対応する部屋情報が無いボタンはテキストを消して無効化する
                For Each line In btn.Lines
                    line.Text = ""
                Next
                btn.BackColor = Color.Gray
                btn.Enabled = False
                btn.Invalidate()
                Continue For
            End If

            Dim roomRow = rooms.Rows(i)
            Dim roomNo = CInt(roomRow("room_no"))
            Dim modelName = roomRow("model_name").ToString()
            Dim capacityMin = CInt(roomRow("capacity_min"))
            Dim capacityMax = CInt(roomRow("capacity_max"))
            Dim roomTypeShortName = roomRow("room_type_short_name").ToString()

            btn.Enabled = True

            If activeByRoom.ContainsKey(roomNo) Then
                Dim entry = activeByRoom(roomNo)
                Dim entryTime = CDate(entry("entry_time"))
                Dim usageMinutes = If(IsDBNull(entry("usage_minutes")), 0, CInt(entry("usage_minutes")))
                Dim plannedExit = entryTime.AddMinutes(usageMinutes)
                Dim now = DateTime.Now

                Dim courseName = entry("course_name").ToString()
                Dim courseShort = courseName.Substring(0, Math.Min(2, courseName.Length))

                Dim optionShortName = If(IsDBNull(entry("option_short_name")), "", entry("option_short_name").ToString())

                Dim totalCount =
                    NzInt(entry("count_adult")) +
                    NzInt(entry("count_age_7_15")) +
                    NzInt(entry("count_age_18_19")) +
                    NzInt(entry("count_child"))

                Dim minutesText As Integer
                If now <= plannedExit Then
                    minutesText = CInt(Math.Floor((plannedExit - now).TotalMinutes))
                    btn.BackColor = OccupiedWithinTimeColor
                Else
                    minutesText = CInt(Math.Floor((now - plannedExit).TotalMinutes))
                    btn.BackColor = OccupiedOverTimeColor
                End If

                btn.Lines(0).Text = $"{roomNo:00} {modelName.PadRight(8)} {courseShort}"
                btn.Lines(1).Text = $" {entryTime:HH:mm}～{plannedExit:HH:mm}  {minutesText}分"
                btn.Lines(2).Text = $"  {totalCount}人( {capacityMin}～ {capacityMax})"
                btn.Lines(3).Text = $" {optionShortName}"
            Else
                btn.BackColor = Color.White

                btn.Lines(0).Text = $"{roomNo:00} {modelName}"
                btn.Lines(1).Text = ""
                btn.Lines(2).Text = $"     {capacityMin}～ {capacityMax}名"
                btn.Lines(3).Text = $"          {roomTypeShortName}"
            End If

            btn.Invalidate()
        Next
    End Sub

    Private Function NzInt(value As Object) As Integer
        If IsDBNull(value) Then Return 0
        Return CInt(value)
    End Function

    ''' DBのメニューボタン情報(表示名・背景色)をもとに、現在のページ分(9個)をmenu_button_0〜8に反映する。
    ''' 登録数がボタン数に満たないスロットは非表示相当(無効化・空表示)にする。
    Private Sub RefreshMenuButtons()
        Dim buttons() As Button = {
            menu_button_0, menu_button_1, menu_button_2,
            menu_button_3, menu_button_4, menu_button_5,
            menu_button_6, menu_button_7, menu_button_8
        }

        Dim menuItems = Database.GetAllMenuButtons() ' sort_orderの昇順
        Dim startIndex = currentMenuPage * MenuButtonsPerPage

        For i = 0 To buttons.Length - 1
            Dim rowIndex = startIndex + i
            Dim btn = buttons(i)

            If rowIndex < menuItems.Rows.Count Then
                Dim row = menuItems.Rows(rowIndex)
                btn.Text = row("display_name").ToString()
                ' 無効として登録されたボタンでも背景色だけは反映し、クリックだけできないようにする
                btn.BackColor = ColorTranslator.FromHtml(row("back_color").ToString())
                btn.Enabled = CInt(row("is_enabled")) <> 0
            Else
                btn.Text = ""
                btn.BackColor = SystemColors.Control
                btn.Enabled = False
            End If
        Next
    End Sub

    Private Sub menu_next_button_Click(sender As Object, e As EventArgs) Handles menu_next_button.Click
        Dim menuItems = Database.GetAllMenuButtons()
        Dim totalPages = CInt(Math.Ceiling(menuItems.Rows.Count / CDbl(MenuButtonsPerPage)))
        If totalPages <= 1 Then Return ' 1ページ以下しかない場合は何もしない

        currentMenuPage = (currentMenuPage + 1) Mod totalPages
        RefreshMenuButtons()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Alt+F4やタスクバー経由の終了操作を無効化し、業務フローからの明示的な終了のみ許可する
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub exit_button_Click(sender As Object, e As EventArgs) Handles menu_exit_button.Click
        Application.Exit()
    End Sub

    Private Sub date_time_timer_Tick(sender As Object, e As EventArgs) Handles date_time_timer.Tick
        Dim now_time As DateTime

        now_time = DateTime.Now
        date_time_label.Text = Format(now_time, "yyyy年MM月dd日 HH時mm分ss秒")

        operation_date_label.Text = "営業設定日:" & Format(now_time, "yyyy/MM/dd")

        Select Case CInt(now_time.DayOfWeek)
            Case 1 To 4
                operation_week_label.Text = "曜日区分:月～木"
            Case 5
                operation_week_label.Text = "曜日区分:金"
            Case 6
                operation_week_label.Text = "曜日区分:土・祝中"
            Case 0
                operation_week_label.Text = "曜日区分:日・祝"
        End Select

        UpdateRoomButtonTexts()
    End Sub

    ' 実際のPOS画面には配置しないマスタ管理画面を、Ctrl+Shift+Mで開く
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.M Then
            ' TopMostのままだとマスタフォームがForm1の裏に隠れてしまうため、開いている間だけ解除する
            Me.TopMost = False
            Using masterForm As New MasterForm()
                masterForm.ShowDialog(Me)
            End Using
            Me.TopMost = True
            UpdateRoomButtonTexts()
            RefreshMenuButtons()
        End If
    End Sub

    Private Sub menu_button_7_Click(sender As Object, e As EventArgs) Handles menu_button_7.Click
        Select Case currentMenuPage
            Case 0
                Dim saver As New ScreenSaverForm()
                AddHandler saver.Dismissed, Sub(senderArg, eArg)
                                                ' 操作を検知したときに実行したい処理
                                            End Sub
                saver.Show(Me)   ' ShowDialogではなくShowを使う
        End Select
    End Sub

    Private Sub menu_button_6_Click(sender As Object, e As EventArgs) Handles menu_button_6.Click
        Select Case currentMenuPage
            Case 3
                ' MainMenuForm → overlay → cashCountForm の順でオーナーをつなげ、重なり順を確実にする
                Dim overlay As New OverlayForm()
                overlay.Show(Me)
                overlay.Refresh()

                Using cashCountForm As New CashCountCheckForm()
                    cashCountForm.OverlayToClose = overlay
                    cashCountForm.ShowDialog(overlay)
                End Using
        End Select
    End Sub

    Private Sub menu_button_5_Click(sender As Object, e As EventArgs) Handles menu_button_5.Click
        Select Case currentMenuPage
            'Case 3
            '    OverlayForm.Show()
        End Select
    End Sub

    Private Sub menu_button_0_Click(sender As Object, e As EventArgs) Handles menu_button_0.Click
        Select Case currentMenuPage
            Case 0
                If selected_room_button = -1 Then
                    Using enterRoomForm As New EnterRoomForm()
                        enterRoomForm.ShowDialog(Me)
                    End Using
                Else
                    Using enterRoomForm As New EnterRoomForm(selected_room_button + 1)
                        enterRoomForm.ShowDialog(Me)
                    End Using
                End If
        End Select
    End Sub
End Class
