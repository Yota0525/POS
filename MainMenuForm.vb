Imports System.Linq

Public Class MainMenuForm

    ' デザイナーで配置した時の基準サイズ（Form1.Designer.vb の ClientSize と合わせる）
    Private ReadOnly DesignSize As New Size(1024, 768)

    ' メニューボタンの現在表示中のページ番号(0始まり)。1ページにつきボタン9個分
    Private currentMenuPage As Integer = 0
    Private Const MenuButtonsPerPage As Integer = 9

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

    ''' DBの部屋情報をもとに、各room_buttonの1行目(部屋番号・機種名)と3行目(収容人数)を更新する。
    ''' ボタンの画面上の並び順(上→下、左→右)と、DBの部屋番号の昇順を対応させている。
    Private Sub UpdateRoomButtonTexts()
        Dim roomButtons = Me.Controls.OfType(Of MultiLineButton)().
            OrderBy(Function(b) b.Top).
            ThenBy(Function(b) b.Left).
            ToList()

        Dim rooms = Database.GetAllRooms() ' room_noの昇順

        Dim count = Math.Min(roomButtons.Count, rooms.Rows.Count)
        For i = 0 To count - 1
            Dim roomNo = CInt(rooms.Rows(i)("room_no"))
            Dim modelName = rooms.Rows(i)("model_name").ToString()
            Dim capacityMin = CInt(rooms.Rows(i)("capacity_min"))
            Dim capacityMax = CInt(rooms.Rows(i)("capacity_max"))
            Dim btn = roomButtons(i)

            If btn.Lines.Count > 0 Then btn.Lines(0).Text = $"{roomNo:00} {modelName}　＊＊"
            If btn.Lines.Count > 2 Then btn.Lines(2).Text = $"  0人 ( {capacityMin:00}- {capacityMax:00})"
            btn.Invalidate()
        Next
    End Sub

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
                Using cashCountForm As New CashCountCheckForm()
                    cashCountForm.ShowDialog(Me)
                End Using
        End Select
    End Sub
End Class
