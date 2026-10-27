Imports System.Data

Public Class EnterRoomForm

    ''' 部屋番号を指定せずに開いた場合はNothing
    Public ReadOnly Property RoomNo As Integer?

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(roomNo As Integer)
        InitializeComponent()
        RoomNo = roomNo
    End Sub

    ' コース一覧をキャッシュしておき、入室時間が変わるたびに時間帯で絞り込む
    Private allCourses As DataTable

    Private Sub EnterRoomForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' 端末ごとに解像度が違うため、実際の画面サイズに確実に合わせる
        Me.Bounds = Screen.PrimaryScreen.Bounds

        If RoomNo.HasValue Then
            room_no.Text = RoomNo.Value.ToString("00")
            room_no.Enabled = False ' 部屋ボタンから開いた場合は部屋を固定する
        End If

        entry_time.Text = DateTime.Now.ToString("HH:mm")

        ' コース・機種メーカー・部屋種別(コンセプト)・オプションをDBから読み込む
        allCourses = Database.GetAllCourses()
        RefreshCourseCombo()
        LoadComboBox(maker_combo, Database.GetAllManufacturers(), "manufacturer_name", "manufacturer_code")
        LoadComboBox(roomtype_combo, Database.GetAllRoomTypes(), "name", "room_type_code")
        LoadComboBox(option_combo, Database.GetAllOptions(), "option_name", "option_code")
        RefreshModelCombo()

        ' サービス(時間)の選択肢
        service_combo.Items.Clear()
        service_combo.Items.AddRange({0, 10, 20, 30, 40, 50, 60})
        service_combo.SelectedIndex = 0
    End Sub

    Private Sub LoadComboBox(combo As ComboBox, table As DataTable, displayMember As String, valueMember As String)
        combo.DataSource = table
        combo.DisplayMember = displayMember
        combo.ValueMember = valueMember
    End Sub

    ''' 入室時間欄を編集し終えたら、その時間帯で選べるコースを再計算する
    Private Sub entry_time_Leave(sender As Object, e As EventArgs) Handles entry_time.Leave
        RefreshCourseCombo()
    End Sub

    ''' 入室時間欄(entry_time)の時刻をもとに、開始・終了時間の範囲内にあるコースだけをcourse_comboに表示する
    Private Sub RefreshCourseCombo()
        If allCourses Is Nothing Then Return

        Dim currentTime = GetEntryTimeOfDay()
        Dim filtered = allCourses.Clone()
        For Each row As DataRow In allCourses.Rows
            Dim startTs = ParseTimeSpan(row("start_time").ToString())
            Dim endTs = ParseTimeSpan(row("end_time").ToString())
            If IsTimeInRange(currentTime, startTs, endTs) Then
                filtered.ImportRow(row)
            End If
        Next

        Dim previousSelection = course_combo.SelectedValue
        course_combo.DataSource = filtered
        course_combo.DisplayMember = "course_name"
        course_combo.ValueMember = "course_code"

        ' 絞り込み後も選べるコードであれば選択を維持する
        If previousSelection IsNot Nothing Then
            course_combo.SelectedValue = previousSelection
        End If
    End Sub

    ''' entry_timeのテキスト(HH:mm)を時刻に変換する。不正な場合は現在時刻を使う
    Private Function GetEntryTimeOfDay() As TimeSpan
        Dim parsed As DateTime
        If DateTime.TryParse(entry_time.Text, parsed) Then
            Return parsed.TimeOfDay
        End If
        Return DateTime.Now.TimeOfDay
    End Function

    Private Function ParseTimeSpan(text As String) As TimeSpan
        Dim parsed As DateTime
        If DateTime.TryParse(text, parsed) Then
            Return parsed.TimeOfDay
        End If
        Return TimeSpan.Zero
    End Function

    ''' startがendより後の場合は日をまたぐ範囲(例: 22:00〜05:00)として扱う
    Private Function IsTimeInRange(t As TimeSpan, start As TimeSpan, [end] As TimeSpan) As Boolean
        If start <= [end] Then
            Return t >= start AndAlso t <= [end]
        Else
            Return t >= start OrElse t <= [end]
        End If
    End Function

    Private Sub maker_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles maker_combo.SelectedIndexChanged
        RefreshModelCombo()
    End Sub

    ''' 選択中のメーカーに属する機種だけをmachine_combo(機種)に表示する
    Private Sub RefreshModelCombo()
        If maker_combo.SelectedValue Is Nothing Then Return
        Dim makerCode = maker_combo.SelectedValue.ToString()

        machine_combo.DataSource = Database.GetModelsByManufacturer(makerCode)
        machine_combo.DisplayMember = "model_name"
        machine_combo.ValueMember = "model_code"
    End Sub

    ''' 会員コードの入力が終わったら、区分・ランクを参照して表示する
    Private Sub member_code_Leave(sender As Object, e As EventArgs) Handles member_code.Leave
        If String.IsNullOrWhiteSpace(member_code.Text) Then
            member_rank.Clear()
            member_category.Clear()
            Return
        End If

        Dim info = Database.GetMemberInfo(member_code.Text.Trim())
        If info Is Nothing Then
            member_rank.Text = "該当なし"
            member_category.Text = ""
        Else
            member_rank.Text = info("rank_name").ToString()
            member_category.Text = info("category_name").ToString()
        End If
    End Sub

    ''' テンキー。フォーカス中のテキストボックスに数字を追加入力する
    Private Sub KeyButton_Click(sender As Object, e As EventArgs) Handles _
        key_button_0.Click, key_button_1.Click, key_button_2.Click, key_button_3.Click, key_button_4.Click,
        key_button_5.Click, key_button_6.Click, key_button_7.Click, key_button_8.Click, key_button_9.Click
        Dim target = TryCast(Me.ActiveControl, TextBox)
        If target Is Nothing Then Return
        target.Text &= DirectCast(sender, Button).Text
    End Sub

    Private Sub key_button_c_Click(sender As Object, e As EventArgs) Handles key_button_c.Click
        Dim target = TryCast(Me.ActiveControl, TextBox)
        If target Is Nothing Then Return
        target.Clear()
    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles back_button.Click
        Me.Close()
    End Sub

    Private Sub register_button_Click(sender As Object, e As EventArgs) Handles register_button.Click
        Dim roomNoValue As Integer
        If Not Integer.TryParse(room_no.Text, roomNoValue) Then
            MessageBox.Show("部屋Noを正しく入力してください。")
            Return
        End If
        If course_combo.SelectedValue Is Nothing Then
            MessageBox.Show("コースを選択してください。")
            Return
        End If
        If maker_combo.SelectedValue Is Nothing Then
            MessageBox.Show("機種メーカーを選択してください。")
            Return
        End If
        If machine_combo.SelectedValue Is Nothing Then
            MessageBox.Show("機種を選択してください。")
            Return
        End If

        ' 入室時間(HH:mm)を今日の日付と組み合わせる。未入力・不正な場合は現在時刻を使う
        Dim entryTime As DateTime
        Dim parsedEntry As DateTime
        If DateTime.TryParse(entry_time.Text, parsedEntry) Then
            entryTime = DateTime.Today.Add(parsedEntry.TimeOfDay)
        Else
            entryTime = DateTime.Now
        End If

        ' 退室時間(予定)欄から利用時間(分)を逆算する。日をまたぐ場合は+1日する
        Dim usageMinutes As Integer? = Nothing
        Dim parsedExit As DateTime
        If DateTime.TryParse(exit_time.Text, parsedExit) Then
            Dim plannedExit = DateTime.Today.Add(parsedExit.TimeOfDay)
            If plannedExit < entryTime Then plannedExit = plannedExit.AddDays(1)
            usageMinutes = CInt((plannedExit - entryTime).TotalMinutes)
        End If

        Dim entryCode = Database.GetNextEntryCode()

        Try
            Database.InsertEntry(
                entryCode, roomNoValue,
                If(String.IsNullOrWhiteSpace(member_code.Text), Nothing, member_code.Text.Trim()),
                ParseNullableInt(age_20.Text),
                ParseNullableInt(age_7to15.Text),
                ParseNullableInt(age_18to19.Text),
                ParseNullableInt(age_6.Text),
                high_school.Checked,
                entryTime,
                course_combo.SelectedValue.ToString(),
                usageMinutes,
                maker_combo.SelectedValue.ToString(),
                machine_combo.SelectedValue.ToString(),
                If(roomtype_combo.SelectedValue Is Nothing, Nothing, roomtype_combo.SelectedValue.ToString()),
                If(option_combo.SelectedValue Is Nothing, Nothing, option_combo.SelectedValue.ToString()),
                ParseNullableInt(service_combo.Text),
                ParseNullableInt(price_1.Text),
                ParseNullableInt(price_2.Text),
                ParseNullableInt(price_3.Text),
                ParseNullableInt(price_4.Text))

            MessageBox.Show("入室情報を登録しました。")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("登録に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Function ParseNullableInt(text As String) As Integer?
        Dim value As Integer
        If Integer.TryParse(text, value) Then Return value
        Return Nothing
    End Function

End Class
