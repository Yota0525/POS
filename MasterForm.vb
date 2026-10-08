Imports System.Data

''' 部屋・機種・メーカー・部屋種別のマスタデータを登録・編集するための管理画面。
''' 実際のPOS画面(Form1)には配置しない、別ウィンドウとして開く管理者向け画面。
Public Class MasterForm
    Inherits Form

    Private tabControl As TabControl

    ' --- メーカータブ ---
    Private mfGrid As DataGridView
    Private mfCodeText As TextBox
    Private mfNameText As TextBox

    ' --- 機種タブ ---
    Private modelGrid As DataGridView
    Private modelCodeText As TextBox
    Private modelMakerCombo As ComboBox
    Private modelNameText As TextBox

    ' --- 部屋種別タブ ---
    Private rtGrid As DataGridView
    Private rtCodeText As TextBox
    Private rtNameText As TextBox
    Private rtFeeNumeric As NumericUpDown
    Private rtShortNameText As TextBox

    ' --- 部屋タブ ---
    Private roomGrid As DataGridView
    Private roomNoNumeric As NumericUpDown
    Private roomTypeCombo As ComboBox
    Private roomModelCombo As ComboBox
    Private roomCapMinNumeric As NumericUpDown
    Private roomCapMaxNumeric As NumericUpDown

    ' --- メニューボタンタブ ---
    Private menuGrid As DataGridView
    Private menuSortOrderText As TextBox
    Private menuNameText As TextBox
    Private menuColorHexText As TextBox
    Private menuColorPreviewPanel As Panel
    Private menuSelectedColor As Color = Color.White
    Private menuEnabledCheck As CheckBox
    ' グリッドで選択中の行の表示順(元の値)。更新時に主キーを特定するために使う。新規時はNothing
    Private editingMenuSortOrder As Integer?

    ' --- 利用者区分タブ ---
    Private categoryGrid As DataGridView
    Private categoryCodeText As TextBox
    Private categoryNameText As TextBox

    ' --- 会員ランクタブ ---
    Private rankGrid As DataGridView
    Private rankCodeText As TextBox
    Private rankNameText As TextBox
    Private rankDiscountText As TextBox

    ' --- コースタブ ---
    Private courseGrid As DataGridView
    Private courseCodeText As TextBox
    Private courseNameText As TextBox
    Private courseTimeSystemNumeric As NumericUpDown
    Private courseFeeNumeric As NumericUpDown

    ' --- オプションタブ ---
    Private optionGrid As DataGridView
    Private optionCodeText As TextBox
    Private optionNameText As TextBox
    Private optionFeeNumeric As NumericUpDown
    Private optionShortNameText As TextBox

    Public Sub New()
        Me.Text = "マスタ管理"
        Me.Size = New Size(920, 650)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimumSize = New Size(700, 500)

        tabControl = New TabControl() With {.Dock = DockStyle.Fill}
        Me.Controls.Add(tabControl)

        BuildManufacturerTab()
        BuildModelTab()
        BuildRoomTypeTab()
        BuildRoomTab()
        BuildMenuButtonTab()
        BuildMemberCategoryTab()
        BuildMemberRankTab()
        BuildCourseTab()
        BuildOptionTab()

        ReloadManufacturers()
        ReloadModels()
        ReloadRoomTypes()
        ReloadRooms()
        ReloadMenuButtons()
        ReloadMemberCategories()
        ReloadMemberRanks()
        ReloadCourses()
        ReloadOptions()
    End Sub

    Private Sub ApplyHeader(grid As DataGridView, columnName As String, header As String)
        If grid.Columns.Contains(columnName) Then grid.Columns(columnName).HeaderText = header
    End Sub

    ''' Dockで残り全体を埋める一覧表（Anchorは親の初期サイズに依存して崩れることがあるため使わない）
    Private Function MakeGrid() As DataGridView
        Return New DataGridView() With {
            .Dock = DockStyle.Fill,
            .ReadOnly = True,
            .AllowUserToAddRows = False,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            .MultiSelect = False,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        }
    End Function

    ''' 下部に固定表示される入力欄用パネル（Dock=Bottomなので常に下端に表示される）
    Private Function MakeEditPanel() As Panel
        Return New Panel() With {
            .Dock = DockStyle.Bottom,
            .Height = 90
        }
    End Function

    ' =====================================================================
    ' メーカー管理
    ' =====================================================================

    Private Sub BuildManufacturerTab()
        Dim page As New TabPage("メーカー管理")
        tabControl.TabPages.Add(page)

        Dim editPanel = MakeEditPanel()

        Dim lblCode As New Label() With {.Text = "メーカーコード", .Location = New Point(10, 13), .AutoSize = True}
        mfCodeText = New TextBox() With {.Location = New Point(130, 10), .Width = 150, .Enabled = False} ' 自動採番のため手入力不可
        Dim lblName As New Label() With {.Text = "メーカー名", .Location = New Point(300, 13), .AutoSize = True}
        mfNameText = New TextBox() With {.Location = New Point(390, 10), .Width = 300}

        Dim btnNew As New Button() With {.Text = "新規登録", .Location = New Point(10, 48), .Width = 100}
        Dim btnUpdate As New Button() With {.Text = "更新", .Location = New Point(120, 48), .Width = 100}
        Dim btnDelete As New Button() With {.Text = "削除", .Location = New Point(230, 48), .Width = 100}
        Dim btnClear As New Button() With {.Text = "クリア", .Location = New Point(340, 48), .Width = 100}

        AddHandler btnNew.Click, AddressOf MfNew_Click
        AddHandler btnUpdate.Click, AddressOf MfUpdate_Click
        AddHandler btnDelete.Click, AddressOf MfDelete_Click
        AddHandler btnClear.Click, Sub() ClearManufacturerFields()

        editPanel.Controls.AddRange({lblCode, mfCodeText, lblName, mfNameText, btnNew, btnUpdate, btnDelete, btnClear})
        page.Controls.Add(editPanel)

        ' Dock=Fillのグリッドは、他のDock済みコントロールを追加した後に最後に追加することで残り全体を占める
        mfGrid = MakeGrid()
        AddHandler mfGrid.SelectionChanged, AddressOf MfGrid_SelectionChanged
        page.Controls.Add(mfGrid)
    End Sub

    Private Sub ReloadManufacturers()
        mfGrid.DataSource = Database.GetAllManufacturers()
        ApplyHeader(mfGrid, "manufacturer_code", "コード")
        ApplyHeader(mfGrid, "manufacturer_name", "名前")
        ClearManufacturerFields()
    End Sub

    Private Sub MfGrid_SelectionChanged(sender As Object, e As EventArgs)
        If mfGrid.CurrentRow Is Nothing Then Return
        Dim row = mfGrid.CurrentRow
        mfCodeText.Text = row.Cells("manufacturer_code").Value.ToString()
        mfNameText.Text = row.Cells("manufacturer_name").Value.ToString()
    End Sub

    ''' 入力欄をクリアし、次に登録される自動採番コードを表示する
    Private Sub ClearManufacturerFields()
        mfCodeText.Text = Database.GetNextManufacturerCode()
        mfNameText.Clear()
        mfGrid.ClearSelection()
    End Sub

    Private Sub MfNew_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(mfCodeText.Text) OrElse String.IsNullOrWhiteSpace(mfNameText.Text) Then
            MessageBox.Show("コードと名前を入力してください。")
            Return
        End If
        Try
            Database.InsertManufacturer(mfCodeText.Text.Trim(), mfNameText.Text.Trim())
            ReloadManufacturers()
            ClearManufacturerFields()
        Catch ex As Exception
            MessageBox.Show("登録に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub MfUpdate_Click(sender As Object, e As EventArgs)
        If mfGrid.CurrentRow Is Nothing Then
            MessageBox.Show("更新対象をグリッドから選択してください。")
            Return
        End If
        Try
            Database.UpdateManufacturer(mfCodeText.Text.Trim(), mfNameText.Text.Trim())
            ReloadManufacturers()
            ClearManufacturerFields()
        Catch ex As Exception
            MessageBox.Show("更新に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub MfDelete_Click(sender As Object, e As EventArgs)
        If mfGrid.CurrentRow Is Nothing Then
            MessageBox.Show("削除対象をグリッドから選択してください。")
            Return
        End If
        If MessageBox.Show($"メーカー「{mfNameText.Text}」を削除しますか？", "確認", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Try
            Database.DeleteManufacturer(mfCodeText.Text.Trim())
            ReloadManufacturers()
            ClearManufacturerFields()
        Catch ex As Exception
            MessageBox.Show("削除に失敗しました（機種から参照されている可能性があります）: " & ex.Message)
        End Try
    End Sub

    ' =====================================================================
    ' 機種管理
    ' =====================================================================

    Private Sub BuildModelTab()
        Dim page As New TabPage("機種管理")
        tabControl.TabPages.Add(page)

        Dim editPanel = MakeEditPanel()

        Dim lblCode As New Label() With {.Text = "機種コード", .Location = New Point(10, 13), .AutoSize = True}
        modelCodeText = New TextBox() With {.Location = New Point(110, 10), .Width = 120, .Enabled = False} ' 自動採番のため手入力不可

        Dim lblMaker As New Label() With {.Text = "メーカー", .Location = New Point(250, 13), .AutoSize = True}
        modelMakerCombo = New ComboBox() With {.Location = New Point(320, 10), .Width = 200, .DropDownStyle = ComboBoxStyle.DropDownList}

        Dim lblName As New Label() With {.Text = "機種名", .Location = New Point(540, 13), .AutoSize = True}
        modelNameText = New TextBox() With {.Location = New Point(600, 10), .Width = 280}

        Dim btnNew As New Button() With {.Text = "新規登録", .Location = New Point(10, 48), .Width = 100}
        Dim btnUpdate As New Button() With {.Text = "更新", .Location = New Point(120, 48), .Width = 100}
        Dim btnDelete As New Button() With {.Text = "削除", .Location = New Point(230, 48), .Width = 100}
        Dim btnClear As New Button() With {.Text = "クリア", .Location = New Point(340, 48), .Width = 100}

        AddHandler btnNew.Click, AddressOf ModelNew_Click
        AddHandler btnUpdate.Click, AddressOf ModelUpdate_Click
        AddHandler btnDelete.Click, AddressOf ModelDelete_Click
        AddHandler btnClear.Click, Sub() ClearModelFields()

        editPanel.Controls.AddRange({lblCode, modelCodeText, lblMaker, modelMakerCombo, lblName, modelNameText, btnNew, btnUpdate, btnDelete, btnClear})
        page.Controls.Add(editPanel)

        modelGrid = MakeGrid()
        AddHandler modelGrid.SelectionChanged, AddressOf ModelGrid_SelectionChanged
        page.Controls.Add(modelGrid)
    End Sub

    Private Sub ReloadModels()
        modelGrid.DataSource = Database.GetAllModels()
        ApplyHeader(modelGrid, "model_code", "機種コード")
        ApplyHeader(modelGrid, "manufacturer_code", "メーカーコード")
        ApplyHeader(modelGrid, "manufacturer_name", "メーカー名")
        ApplyHeader(modelGrid, "model_name", "機種名")

        modelMakerCombo.DataSource = Database.GetAllManufacturers()
        modelMakerCombo.DisplayMember = "manufacturer_name"
        modelMakerCombo.ValueMember = "manufacturer_code"

        ClearModelFields()
    End Sub

    Private Sub ModelGrid_SelectionChanged(sender As Object, e As EventArgs)
        If modelGrid.CurrentRow Is Nothing Then Return
        Dim row = modelGrid.CurrentRow
        modelCodeText.Text = row.Cells("model_code").Value.ToString()
        modelMakerCombo.SelectedValue = row.Cells("manufacturer_code").Value
        modelNameText.Text = row.Cells("model_name").Value.ToString()
    End Sub

    ''' 入力欄をクリアし、次に登録される自動採番コードを表示する
    Private Sub ClearModelFields()
        modelCodeText.Text = Database.GetNextModelCode()
        If modelMakerCombo.Items.Count > 0 Then modelMakerCombo.SelectedIndex = 0
        modelNameText.Clear()
        modelGrid.ClearSelection()
    End Sub

    Private Sub ModelNew_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(modelCodeText.Text) OrElse String.IsNullOrWhiteSpace(modelNameText.Text) OrElse modelMakerCombo.SelectedValue Is Nothing Then
            MessageBox.Show("すべての項目を入力してください。")
            Return
        End If
        Try
            Database.InsertModel(modelCodeText.Text.Trim(), modelMakerCombo.SelectedValue.ToString(), modelNameText.Text.Trim())
            ReloadModels()
            ClearModelFields()
        Catch ex As Exception
            MessageBox.Show("登録に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub ModelUpdate_Click(sender As Object, e As EventArgs)
        If modelGrid.CurrentRow Is Nothing Then
            MessageBox.Show("更新対象をグリッドから選択してください。")
            Return
        End If
        Try
            Database.UpdateModel(modelCodeText.Text.Trim(), modelMakerCombo.SelectedValue.ToString(), modelNameText.Text.Trim())
            ReloadModels()
            ClearModelFields()
        Catch ex As Exception
            MessageBox.Show("更新に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub ModelDelete_Click(sender As Object, e As EventArgs)
        If modelGrid.CurrentRow Is Nothing Then
            MessageBox.Show("削除対象をグリッドから選択してください。")
            Return
        End If
        If MessageBox.Show($"機種「{modelNameText.Text}」を削除しますか？", "確認", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Try
            Database.DeleteModel(modelCodeText.Text.Trim())
            ReloadModels()
            ClearModelFields()
        Catch ex As Exception
            MessageBox.Show("削除に失敗しました（部屋から参照されている可能性があります）: " & ex.Message)
        End Try
    End Sub

    ' =====================================================================
    ' 部屋種別管理
    ' =====================================================================

    Private Sub BuildRoomTypeTab()
        Dim page As New TabPage("部屋種別管理")
        tabControl.TabPages.Add(page)

        Dim editPanel = MakeEditPanel()

        Dim lblCode As New Label() With {.Text = "種別コード", .Location = New Point(10, 13), .AutoSize = True}
        rtCodeText = New TextBox() With {.Location = New Point(120, 10), .Width = 150, .Enabled = False} ' 自動採番のため手入力不可
        Dim lblName As New Label() With {.Text = "名前", .Location = New Point(290, 13), .AutoSize = True}
        rtNameText = New TextBox() With {.Location = New Point(340, 10), .Width = 250}
        Dim lblFee As New Label() With {.Text = "料金", .Location = New Point(600, 13), .AutoSize = True}
        rtFeeNumeric = New NumericUpDown() With {.Location = New Point(650, 10), .Width = 70, .Minimum = 0, .Maximum = 999999}
        Dim lblShort As New Label() With {.Text = "短縮名", .Location = New Point(730, 13), .AutoSize = True}
        rtShortNameText = New TextBox() With {.Location = New Point(790, 10), .Width = 60} ' ボタン表示用の短縮名(例: ボタンの先頭1文字に使用)

        Dim btnNew As New Button() With {.Text = "新規登録", .Location = New Point(10, 48), .Width = 100}
        Dim btnUpdate As New Button() With {.Text = "更新", .Location = New Point(120, 48), .Width = 100}
        Dim btnDelete As New Button() With {.Text = "削除", .Location = New Point(230, 48), .Width = 100}
        Dim btnClear As New Button() With {.Text = "クリア", .Location = New Point(340, 48), .Width = 100}

        AddHandler btnNew.Click, AddressOf RtNew_Click
        AddHandler btnUpdate.Click, AddressOf RtUpdate_Click
        AddHandler btnDelete.Click, AddressOf RtDelete_Click
        AddHandler btnClear.Click, Sub() ClearRoomTypeFields()

        editPanel.Controls.AddRange({lblCode, rtCodeText, lblName, rtNameText, lblFee, rtFeeNumeric, lblShort, rtShortNameText, btnNew, btnUpdate, btnDelete, btnClear})
        page.Controls.Add(editPanel)

        rtGrid = MakeGrid()
        AddHandler rtGrid.SelectionChanged, AddressOf RtGrid_SelectionChanged
        page.Controls.Add(rtGrid)
    End Sub

    Private Sub ReloadRoomTypes()
        rtGrid.DataSource = Database.GetAllRoomTypes()
        ApplyHeader(rtGrid, "room_type_code", "コード")
        ApplyHeader(rtGrid, "name", "名前")
        ApplyHeader(rtGrid, "fee", "料金")
        ApplyHeader(rtGrid, "short_name", "短縮名")
        ClearRoomTypeFields()
    End Sub

    Private Sub RtGrid_SelectionChanged(sender As Object, e As EventArgs)
        If rtGrid.CurrentRow Is Nothing Then Return
        Dim row = rtGrid.CurrentRow
        rtCodeText.Text = row.Cells("room_type_code").Value.ToString()
        rtNameText.Text = row.Cells("name").Value.ToString()
        rtFeeNumeric.Value = CDec(row.Cells("fee").Value)
        rtShortNameText.Text = row.Cells("short_name").Value.ToString()
    End Sub

    ''' 入力欄をクリアし、次に登録される自動採番コードを表示する
    Private Sub ClearRoomTypeFields()
        rtCodeText.Text = Database.GetNextRoomTypeCode()
        rtNameText.Clear()
        rtFeeNumeric.Value = 0
        rtShortNameText.Clear()
        rtGrid.ClearSelection()
    End Sub

    Private Sub RtNew_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(rtCodeText.Text) OrElse String.IsNullOrWhiteSpace(rtNameText.Text) Then
            MessageBox.Show("コードと名前を入力してください。")
            Return
        End If
        Try
            Database.InsertRoomType(rtCodeText.Text.Trim(), rtNameText.Text.Trim(), CInt(rtFeeNumeric.Value), rtShortNameText.Text.Trim())
            ReloadRoomTypes()
            ClearRoomTypeFields()
        Catch ex As Exception
            MessageBox.Show("登録に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub RtUpdate_Click(sender As Object, e As EventArgs)
        If rtGrid.CurrentRow Is Nothing Then
            MessageBox.Show("更新対象をグリッドから選択してください。")
            Return
        End If
        Try
            Database.UpdateRoomType(rtCodeText.Text.Trim(), rtNameText.Text.Trim(), CInt(rtFeeNumeric.Value), rtShortNameText.Text.Trim())
            ReloadRoomTypes()
            ClearRoomTypeFields()
        Catch ex As Exception
            MessageBox.Show("更新に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub RtDelete_Click(sender As Object, e As EventArgs)
        If rtGrid.CurrentRow Is Nothing Then
            MessageBox.Show("削除対象をグリッドから選択してください。")
            Return
        End If
        If MessageBox.Show($"部屋種別「{rtNameText.Text}」を削除しますか？", "確認", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Try
            Database.DeleteRoomType(rtCodeText.Text.Trim())
            ReloadRoomTypes()
            ClearRoomTypeFields()
        Catch ex As Exception
            MessageBox.Show("削除に失敗しました（部屋から参照されている可能性があります）: " & ex.Message)
        End Try
    End Sub

    ' =====================================================================
    ' 部屋管理
    ' =====================================================================

    Private Sub BuildRoomTab()
        Dim page As New TabPage("部屋管理")
        tabControl.TabPages.Add(page)

        Dim editPanel = MakeEditPanel()

        Dim lblNo As New Label() With {.Text = "部屋番号", .Location = New Point(10, 13), .AutoSize = True}
        roomNoNumeric = New NumericUpDown() With {.Location = New Point(90, 10), .Width = 80, .Minimum = 0, .Maximum = 9999, .Enabled = False} ' 自動採番のため手入力不可

        Dim lblType As New Label() With {.Text = "部屋種別", .Location = New Point(190, 13), .AutoSize = True}
        roomTypeCombo = New ComboBox() With {.Location = New Point(260, 10), .Width = 150, .DropDownStyle = ComboBoxStyle.DropDownList}

        Dim lblModel As New Label() With {.Text = "機種", .Location = New Point(430, 13), .AutoSize = True}
        roomModelCombo = New ComboBox() With {.Location = New Point(470, 10), .Width = 180, .DropDownStyle = ComboBoxStyle.DropDownList}

        Dim lblMin As New Label() With {.Text = "人数下限", .Location = New Point(670, 13), .AutoSize = True}
        roomCapMinNumeric = New NumericUpDown() With {.Location = New Point(740, 10), .Width = 60, .Minimum = 0, .Maximum = 99}

        Dim lblMax As New Label() With {.Text = "人数上限", .Location = New Point(810, 13), .AutoSize = True}
        roomCapMaxNumeric = New NumericUpDown() With {.Location = New Point(870, 10), .Width = 60, .Minimum = 0, .Maximum = 99}

        Dim btnNew As New Button() With {.Text = "新規登録", .Location = New Point(10, 48), .Width = 100}
        Dim btnUpdate As New Button() With {.Text = "更新", .Location = New Point(120, 48), .Width = 100}
        Dim btnDelete As New Button() With {.Text = "削除", .Location = New Point(230, 48), .Width = 100}
        Dim btnClear As New Button() With {.Text = "クリア", .Location = New Point(340, 48), .Width = 100}

        AddHandler btnNew.Click, AddressOf RoomNew_Click
        AddHandler btnUpdate.Click, AddressOf RoomUpdate_Click
        AddHandler btnDelete.Click, AddressOf RoomDelete_Click
        AddHandler btnClear.Click, Sub() ClearRoomFields()

        editPanel.Controls.AddRange({lblNo, roomNoNumeric, lblType, roomTypeCombo, lblModel, roomModelCombo, lblMin, roomCapMinNumeric, lblMax, roomCapMaxNumeric, btnNew, btnUpdate, btnDelete, btnClear})
        page.Controls.Add(editPanel)

        roomGrid = MakeGrid()
        AddHandler roomGrid.SelectionChanged, AddressOf RoomGrid_SelectionChanged
        page.Controls.Add(roomGrid)
    End Sub

    Private Sub ReloadRooms()
        roomGrid.DataSource = Database.GetAllRooms()
        ApplyHeader(roomGrid, "room_no", "部屋番号")
        ApplyHeader(roomGrid, "room_type_code", "種別コード")
        ApplyHeader(roomGrid, "room_type_name", "種別名")
        ApplyHeader(roomGrid, "model_code", "機種コード")
        ApplyHeader(roomGrid, "model_name", "機種名")
        ApplyHeader(roomGrid, "capacity_min", "人数下限")
        ApplyHeader(roomGrid, "capacity_max", "人数上限")

        roomTypeCombo.DataSource = Database.GetAllRoomTypes()
        roomTypeCombo.DisplayMember = "name"
        roomTypeCombo.ValueMember = "room_type_code"

        roomModelCombo.DataSource = Database.GetAllModels()
        roomModelCombo.DisplayMember = "model_name"
        roomModelCombo.ValueMember = "model_code"

        ClearRoomFields()
    End Sub

    Private Sub RoomGrid_SelectionChanged(sender As Object, e As EventArgs)
        If roomGrid.CurrentRow Is Nothing Then Return
        Dim row = roomGrid.CurrentRow
        roomNoNumeric.Value = CDec(row.Cells("room_no").Value)
        roomTypeCombo.SelectedValue = row.Cells("room_type_code").Value
        roomModelCombo.SelectedValue = row.Cells("model_code").Value
        roomCapMinNumeric.Value = CDec(row.Cells("capacity_min").Value)
        roomCapMaxNumeric.Value = CDec(row.Cells("capacity_max").Value)
    End Sub

    ''' 入力欄をクリアし、次に登録される自動採番の部屋番号を表示する
    Private Sub ClearRoomFields()
        roomNoNumeric.Value = Math.Min(Database.GetNextRoomNo(), CInt(roomNoNumeric.Maximum))
        If roomTypeCombo.Items.Count > 0 Then roomTypeCombo.SelectedIndex = 0
        If roomModelCombo.Items.Count > 0 Then roomModelCombo.SelectedIndex = 0
        roomCapMinNumeric.Value = 0
        roomCapMaxNumeric.Value = 0
        roomGrid.ClearSelection()
    End Sub

    Private Sub RoomNew_Click(sender As Object, e As EventArgs)
        If roomTypeCombo.SelectedValue Is Nothing OrElse roomModelCombo.SelectedValue Is Nothing Then
            MessageBox.Show("部屋種別と機種を選択してください。")
            Return
        End If
        Try
            Database.InsertRoom(CInt(roomNoNumeric.Value), roomTypeCombo.SelectedValue.ToString(), roomModelCombo.SelectedValue.ToString(), CInt(roomCapMinNumeric.Value), CInt(roomCapMaxNumeric.Value))
            ReloadRooms()
            ClearRoomFields()
        Catch ex As Exception
            MessageBox.Show("登録に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub RoomUpdate_Click(sender As Object, e As EventArgs)
        If roomGrid.CurrentRow Is Nothing Then
            MessageBox.Show("更新対象をグリッドから選択してください。")
            Return
        End If
        Try
            Database.UpdateRoom(CInt(roomNoNumeric.Value), roomTypeCombo.SelectedValue.ToString(), roomModelCombo.SelectedValue.ToString(), CInt(roomCapMinNumeric.Value), CInt(roomCapMaxNumeric.Value))
            ReloadRooms()
            ClearRoomFields()
        Catch ex As Exception
            MessageBox.Show("更新に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub RoomDelete_Click(sender As Object, e As EventArgs)
        If roomGrid.CurrentRow Is Nothing Then
            MessageBox.Show("削除対象をグリッドから選択してください。")
            Return
        End If
        If MessageBox.Show($"部屋番号「{CInt(roomNoNumeric.Value)}」を削除しますか？", "確認", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Try
            Database.DeleteRoom(CInt(roomNoNumeric.Value))
            ReloadRooms()
            ClearRoomFields()
        Catch ex As Exception
            MessageBox.Show("削除に失敗しました: " & ex.Message)
        End Try
    End Sub

    ' =====================================================================
    ' メニューボタン管理
    ' =====================================================================

    Private Sub BuildMenuButtonTab()
        Dim page As New TabPage("メニューボタン管理")
        tabControl.TabPages.Add(page)

        Dim editPanel = MakeEditPanel()

        Dim lblOrder As New Label() With {.Text = "表示順", .Location = New Point(10, 13), .AutoSize = True}
        menuSortOrderText = New TextBox() With {.Location = New Point(70, 10), .Width = 50} ' 任意の数値を手入力できる

        Dim lblName As New Label() With {.Text = "表示名", .Location = New Point(140, 13), .AutoSize = True}
        menuNameText = New TextBox() With {.Location = New Point(200, 10), .Width = 200}

        Dim lblColor As New Label() With {.Text = "背景色", .Location = New Point(420, 13), .AutoSize = True}
        menuColorHexText = New TextBox() With {.Location = New Point(470, 10), .Width = 80, .Text = ColorTranslator.ToHtml(menuSelectedColor)} ' 色コード(#RRGGBB)を直接入力できる
        AddHandler menuColorHexText.Leave, AddressOf MenuColorHexText_Leave
        menuColorPreviewPanel = New Panel() With {
            .Location = New Point(560, 10),
            .Size = New Size(30, 26),
            .BackColor = menuSelectedColor,
            .BorderStyle = BorderStyle.FixedSingle
        }
        Dim btnColorPick As New Button() With {.Text = "色を選択...", .Location = New Point(600, 8), .Width = 90}
        AddHandler btnColorPick.Click, AddressOf MenuColorPick_Click

        ' 無効(クリックできない)なボタンでも背景色だけは設定して登録できるようにするためのチェック
        menuEnabledCheck = New CheckBox() With {.Text = "有効", .Location = New Point(700, 12), .AutoSize = True, .Checked = True}

        Dim btnNew As New Button() With {.Text = "新規登録", .Location = New Point(10, 48), .Width = 100}
        Dim btnUpdate As New Button() With {.Text = "更新", .Location = New Point(120, 48), .Width = 100}
        Dim btnDelete As New Button() With {.Text = "削除", .Location = New Point(230, 48), .Width = 100}
        Dim btnClear As New Button() With {.Text = "クリア", .Location = New Point(340, 48), .Width = 100}

        AddHandler btnNew.Click, AddressOf MenuNew_Click
        AddHandler btnUpdate.Click, AddressOf MenuUpdate_Click
        AddHandler btnDelete.Click, AddressOf MenuDelete_Click
        AddHandler btnClear.Click, Sub() ClearMenuButtonFields()

        editPanel.Controls.AddRange({lblOrder, menuSortOrderText, lblName, menuNameText, lblColor, menuColorHexText, menuColorPreviewPanel, btnColorPick, menuEnabledCheck, btnNew, btnUpdate, btnDelete, btnClear})
        page.Controls.Add(editPanel)

        menuGrid = MakeGrid()
        AddHandler menuGrid.SelectionChanged, AddressOf MenuGrid_SelectionChanged
        page.Controls.Add(menuGrid)
    End Sub

    Private Sub ReloadMenuButtons()
        menuGrid.DataSource = Database.GetAllMenuButtons()
        ApplyHeader(menuGrid, "sort_order", "表示順")
        ApplyHeader(menuGrid, "display_name", "表示名")
        ApplyHeader(menuGrid, "back_color", "背景色")
        ApplyHeader(menuGrid, "is_enabled", "有効")
        ClearMenuButtonFields()
    End Sub

    Private Sub MenuGrid_SelectionChanged(sender As Object, e As EventArgs)
        If menuGrid.CurrentRow Is Nothing Then Return
        Dim row = menuGrid.CurrentRow
        editingMenuSortOrder = CInt(row.Cells("sort_order").Value)
        menuSortOrderText.Text = row.Cells("sort_order").Value.ToString()
        menuNameText.Text = row.Cells("display_name").Value.ToString()
        menuEnabledCheck.Checked = CInt(row.Cells("is_enabled").Value) <> 0
        Try
            menuSelectedColor = ColorTranslator.FromHtml(row.Cells("back_color").Value.ToString())
        Catch
            menuSelectedColor = Color.White
        End Try
        menuColorPreviewPanel.BackColor = menuSelectedColor
        menuColorHexText.Text = ColorTranslator.ToHtml(menuSelectedColor)
    End Sub

    ''' 色コードの手入力欄からフォーカスが外れたときに反映する。不正な値の場合は直前の色に戻す
    Private Sub MenuColorHexText_Leave(sender As Object, e As EventArgs)
        Try
            Dim c = ColorTranslator.FromHtml(menuColorHexText.Text.Trim())
            menuSelectedColor = c
            menuColorPreviewPanel.BackColor = c
        Catch
            menuColorHexText.Text = ColorTranslator.ToHtml(menuSelectedColor)
        End Try
    End Sub

    ''' Visual Studioのプロパティウィンドウと同じ配色パレット(カスタム/Web/システム)で色を選ぶ
    Private Sub MenuColorPick_Click(sender As Object, e As EventArgs)
        Dim picked = VsColorPicker.PickColor(menuSelectedColor)
        If picked.HasValue Then
            menuSelectedColor = picked.Value
            menuColorPreviewPanel.BackColor = menuSelectedColor
            menuColorHexText.Text = ColorTranslator.ToHtml(menuSelectedColor)
        End If
    End Sub

    ''' 入力欄をクリアし、次の登録用に自動採番の表示順を候補として表示する(編集可能)
    Private Sub ClearMenuButtonFields()
        editingMenuSortOrder = Nothing
        menuSortOrderText.Text = Database.GetNextMenuButtonSortOrder().ToString()
        menuNameText.Clear()
        menuSelectedColor = Color.White
        menuColorPreviewPanel.BackColor = menuSelectedColor
        menuColorHexText.Text = ColorTranslator.ToHtml(menuSelectedColor)
        menuEnabledCheck.Checked = True
        menuGrid.ClearSelection()
    End Sub

    Private Sub MenuNew_Click(sender As Object, e As EventArgs)
        Dim newOrder As Integer
        If Not Integer.TryParse(menuSortOrderText.Text, newOrder) Then
            MessageBox.Show("表示順には数値を入力してください。")
            Return
        End If
        Try
            Database.InsertMenuButton(newOrder, menuNameText.Text.Trim(), ColorTranslator.ToHtml(menuSelectedColor), menuEnabledCheck.Checked)
            ReloadMenuButtons()
        Catch ex As Exception
            MessageBox.Show("登録に失敗しました（表示順が重複している可能性があります）: " & ex.Message)
        End Try
    End Sub

    Private Sub MenuUpdate_Click(sender As Object, e As EventArgs)
        If menuGrid.CurrentRow Is Nothing OrElse Not editingMenuSortOrder.HasValue Then
            MessageBox.Show("更新対象をグリッドから選択してください。")
            Return
        End If
        Dim newOrder As Integer
        If Not Integer.TryParse(menuSortOrderText.Text, newOrder) Then
            MessageBox.Show("表示順には数値を入力してください。")
            Return
        End If
        Try
            Database.UpdateMenuButton(editingMenuSortOrder.Value, newOrder, menuNameText.Text.Trim(), ColorTranslator.ToHtml(menuSelectedColor), menuEnabledCheck.Checked)
            ReloadMenuButtons()
        Catch ex As Exception
            MessageBox.Show("更新に失敗しました（表示順が重複している可能性があります）: " & ex.Message)
        End Try
    End Sub

    Private Sub MenuDelete_Click(sender As Object, e As EventArgs)
        If menuGrid.CurrentRow Is Nothing OrElse Not editingMenuSortOrder.HasValue Then
            MessageBox.Show("削除対象をグリッドから選択してください。")
            Return
        End If
        If MessageBox.Show($"メニューボタン「{menuNameText.Text}」を削除しますか？", "確認", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Try
            Database.DeleteMenuButton(editingMenuSortOrder.Value)
            ReloadMenuButtons()
        Catch ex As Exception
            MessageBox.Show("削除に失敗しました: " & ex.Message)
        End Try
    End Sub

    ' =====================================================================
    ' 利用者区分管理
    ' =====================================================================

    Private Sub BuildMemberCategoryTab()
        Dim page As New TabPage("利用者区分管理")
        tabControl.TabPages.Add(page)

        Dim editPanel = MakeEditPanel()

        Dim lblCode As New Label() With {.Text = "区分コード", .Location = New Point(10, 13), .AutoSize = True}
        categoryCodeText = New TextBox() With {.Location = New Point(100, 10), .Width = 100, .Enabled = False}
        Dim lblName As New Label() With {.Text = "区分名", .Location = New Point(220, 13), .AutoSize = True}
        categoryNameText = New TextBox() With {.Location = New Point(280, 10), .Width = 300}

        Dim btnNew As New Button() With {.Text = "新規登録", .Location = New Point(10, 48), .Width = 100}
        Dim btnUpdate As New Button() With {.Text = "更新", .Location = New Point(120, 48), .Width = 100}
        Dim btnDelete As New Button() With {.Text = "削除", .Location = New Point(230, 48), .Width = 100}
        Dim btnClear As New Button() With {.Text = "クリア", .Location = New Point(340, 48), .Width = 100}

        AddHandler btnNew.Click, AddressOf CategoryNew_Click
        AddHandler btnUpdate.Click, AddressOf CategoryUpdate_Click
        AddHandler btnDelete.Click, AddressOf CategoryDelete_Click
        AddHandler btnClear.Click, Sub() ClearCategoryFields()

        editPanel.Controls.AddRange({lblCode, categoryCodeText, lblName, categoryNameText, btnNew, btnUpdate, btnDelete, btnClear})
        page.Controls.Add(editPanel)

        categoryGrid = MakeGrid()
        AddHandler categoryGrid.SelectionChanged, AddressOf CategoryGrid_SelectionChanged
        page.Controls.Add(categoryGrid)
    End Sub

    Private Sub ReloadMemberCategories()
        categoryGrid.DataSource = Database.GetAllMemberCategories()
        ApplyHeader(categoryGrid, "category_code", "コード")
        ApplyHeader(categoryGrid, "category_name", "区分名")
        ClearCategoryFields()
    End Sub

    Private Sub CategoryGrid_SelectionChanged(sender As Object, e As EventArgs)
        If categoryGrid.CurrentRow Is Nothing Then Return
        Dim row = categoryGrid.CurrentRow
        categoryCodeText.Text = row.Cells("category_code").Value.ToString()
        categoryNameText.Text = row.Cells("category_name").Value.ToString()
    End Sub

    Private Sub ClearCategoryFields()
        categoryCodeText.Text = Database.GetNextMemberCategoryCode()
        categoryNameText.Clear()
        categoryGrid.ClearSelection()
    End Sub

    Private Sub CategoryNew_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(categoryNameText.Text) Then
            MessageBox.Show("区分名を入力してください。")
            Return
        End If
        Try
            Database.InsertMemberCategory(categoryCodeText.Text.Trim(), categoryNameText.Text.Trim())
            ReloadMemberCategories()
        Catch ex As Exception
            MessageBox.Show("登録に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub CategoryUpdate_Click(sender As Object, e As EventArgs)
        If categoryGrid.CurrentRow Is Nothing Then
            MessageBox.Show("更新対象をグリッドから選択してください。")
            Return
        End If
        Try
            Database.UpdateMemberCategory(categoryCodeText.Text.Trim(), categoryNameText.Text.Trim())
            ReloadMemberCategories()
        Catch ex As Exception
            MessageBox.Show("更新に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub CategoryDelete_Click(sender As Object, e As EventArgs)
        If categoryGrid.CurrentRow Is Nothing Then
            MessageBox.Show("削除対象をグリッドから選択してください。")
            Return
        End If
        If MessageBox.Show($"利用者区分「{categoryNameText.Text}」を削除しますか？", "確認", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Try
            Database.DeleteMemberCategory(categoryCodeText.Text.Trim())
            ReloadMemberCategories()
        Catch ex As Exception
            MessageBox.Show("削除に失敗しました（会員から参照されている可能性があります）: " & ex.Message)
        End Try
    End Sub

    ' =====================================================================
    ' 会員ランク管理
    ' =====================================================================

    Private Sub BuildMemberRankTab()
        Dim page As New TabPage("会員ランク管理")
        tabControl.TabPages.Add(page)

        Dim editPanel = MakeEditPanel()

        Dim lblCode As New Label() With {.Text = "ランクコード", .Location = New Point(10, 13), .AutoSize = True}
        rankCodeText = New TextBox() With {.Location = New Point(110, 10), .Width = 100, .Enabled = False}
        Dim lblName As New Label() With {.Text = "ランク名", .Location = New Point(230, 13), .AutoSize = True}
        rankNameText = New TextBox() With {.Location = New Point(300, 10), .Width = 200}
        Dim lblDiscount As New Label() With {.Text = "割引等", .Location = New Point(520, 13), .AutoSize = True}
        rankDiscountText = New TextBox() With {.Location = New Point(580, 10), .Width = 280}

        Dim btnNew As New Button() With {.Text = "新規登録", .Location = New Point(10, 48), .Width = 100}
        Dim btnUpdate As New Button() With {.Text = "更新", .Location = New Point(120, 48), .Width = 100}
        Dim btnDelete As New Button() With {.Text = "削除", .Location = New Point(230, 48), .Width = 100}
        Dim btnClear As New Button() With {.Text = "クリア", .Location = New Point(340, 48), .Width = 100}

        AddHandler btnNew.Click, AddressOf RankNew_Click
        AddHandler btnUpdate.Click, AddressOf RankUpdate_Click
        AddHandler btnDelete.Click, AddressOf RankDelete_Click
        AddHandler btnClear.Click, Sub() ClearRankFields()

        editPanel.Controls.AddRange({lblCode, rankCodeText, lblName, rankNameText, lblDiscount, rankDiscountText, btnNew, btnUpdate, btnDelete, btnClear})
        page.Controls.Add(editPanel)

        rankGrid = MakeGrid()
        AddHandler rankGrid.SelectionChanged, AddressOf RankGrid_SelectionChanged
        page.Controls.Add(rankGrid)
    End Sub

    Private Sub ReloadMemberRanks()
        rankGrid.DataSource = Database.GetAllMemberRanks()
        ApplyHeader(rankGrid, "rank_code", "コード")
        ApplyHeader(rankGrid, "rank_name", "ランク名")
        ApplyHeader(rankGrid, "discount_note", "割引等")
        ClearRankFields()
    End Sub

    Private Sub RankGrid_SelectionChanged(sender As Object, e As EventArgs)
        If rankGrid.CurrentRow Is Nothing Then Return
        Dim row = rankGrid.CurrentRow
        rankCodeText.Text = row.Cells("rank_code").Value.ToString()
        rankNameText.Text = row.Cells("rank_name").Value.ToString()
        rankDiscountText.Text = If(IsDBNull(row.Cells("discount_note").Value), "", row.Cells("discount_note").Value.ToString())
    End Sub

    Private Sub ClearRankFields()
        rankCodeText.Text = Database.GetNextMemberRankCode()
        rankNameText.Clear()
        rankDiscountText.Clear()
        rankGrid.ClearSelection()
    End Sub

    Private Sub RankNew_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(rankNameText.Text) Then
            MessageBox.Show("ランク名を入力してください。")
            Return
        End If
        Try
            Database.InsertMemberRank(rankCodeText.Text.Trim(), rankNameText.Text.Trim(), rankDiscountText.Text.Trim())
            ReloadMemberRanks()
        Catch ex As Exception
            MessageBox.Show("登録に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub RankUpdate_Click(sender As Object, e As EventArgs)
        If rankGrid.CurrentRow Is Nothing Then
            MessageBox.Show("更新対象をグリッドから選択してください。")
            Return
        End If
        Try
            Database.UpdateMemberRank(rankCodeText.Text.Trim(), rankNameText.Text.Trim(), rankDiscountText.Text.Trim())
            ReloadMemberRanks()
        Catch ex As Exception
            MessageBox.Show("更新に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub RankDelete_Click(sender As Object, e As EventArgs)
        If rankGrid.CurrentRow Is Nothing Then
            MessageBox.Show("削除対象をグリッドから選択してください。")
            Return
        End If
        If MessageBox.Show($"会員ランク「{rankNameText.Text}」を削除しますか？", "確認", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Try
            Database.DeleteMemberRank(rankCodeText.Text.Trim())
            ReloadMemberRanks()
        Catch ex As Exception
            MessageBox.Show("削除に失敗しました（会員から参照されている可能性があります）: " & ex.Message)
        End Try
    End Sub

    ' =====================================================================
    ' コース管理
    ' =====================================================================

    Private Sub BuildCourseTab()
        Dim page As New TabPage("コース管理")
        tabControl.TabPages.Add(page)

        Dim editPanel = MakeEditPanel()

        Dim lblCode As New Label() With {.Text = "コースコード", .Location = New Point(10, 13), .AutoSize = True}
        courseCodeText = New TextBox() With {.Location = New Point(110, 10), .Width = 80, .Enabled = False}
        Dim lblName As New Label() With {.Text = "コース名", .Location = New Point(210, 13), .AutoSize = True}
        courseNameText = New TextBox() With {.Location = New Point(280, 10), .Width = 200}
        Dim lblTimeSystem As New Label() With {.Text = "時間制区分", .Location = New Point(500, 13), .AutoSize = True}
        courseTimeSystemNumeric = New NumericUpDown() With {.Location = New Point(580, 10), .Width = 60, .Minimum = 0, .Maximum = 99}
        Dim lblFee As New Label() With {.Text = "料金", .Location = New Point(660, 13), .AutoSize = True}
        courseFeeNumeric = New NumericUpDown() With {.Location = New Point(700, 10), .Width = 80, .Minimum = 0, .Maximum = 999999}

        Dim btnNew As New Button() With {.Text = "新規登録", .Location = New Point(10, 48), .Width = 100}
        Dim btnUpdate As New Button() With {.Text = "更新", .Location = New Point(120, 48), .Width = 100}
        Dim btnDelete As New Button() With {.Text = "削除", .Location = New Point(230, 48), .Width = 100}
        Dim btnClear As New Button() With {.Text = "クリア", .Location = New Point(340, 48), .Width = 100}

        AddHandler btnNew.Click, AddressOf CourseNew_Click
        AddHandler btnUpdate.Click, AddressOf CourseUpdate_Click
        AddHandler btnDelete.Click, AddressOf CourseDelete_Click
        AddHandler btnClear.Click, Sub() ClearCourseFields()

        editPanel.Controls.AddRange({lblCode, courseCodeText, lblName, courseNameText, lblTimeSystem, courseTimeSystemNumeric, lblFee, courseFeeNumeric, btnNew, btnUpdate, btnDelete, btnClear})
        page.Controls.Add(editPanel)

        courseGrid = MakeGrid()
        AddHandler courseGrid.SelectionChanged, AddressOf CourseGrid_SelectionChanged
        page.Controls.Add(courseGrid)
    End Sub

    Private Sub ReloadCourses()
        courseGrid.DataSource = Database.GetAllCourses()
        ApplyHeader(courseGrid, "course_code", "コード")
        ApplyHeader(courseGrid, "course_name", "コース名")
        ApplyHeader(courseGrid, "time_system_type", "時間制区分")
        ApplyHeader(courseGrid, "fee", "料金")
        ClearCourseFields()
    End Sub

    Private Sub CourseGrid_SelectionChanged(sender As Object, e As EventArgs)
        If courseGrid.CurrentRow Is Nothing Then Return
        Dim row = courseGrid.CurrentRow
        courseCodeText.Text = row.Cells("course_code").Value.ToString()
        courseNameText.Text = row.Cells("course_name").Value.ToString()
        courseTimeSystemNumeric.Value = CDec(row.Cells("time_system_type").Value)
        courseFeeNumeric.Value = CDec(row.Cells("fee").Value)
    End Sub

    Private Sub ClearCourseFields()
        courseCodeText.Text = Database.GetNextCourseCode()
        courseNameText.Clear()
        courseTimeSystemNumeric.Value = 0
        courseFeeNumeric.Value = 0
        courseGrid.ClearSelection()
    End Sub

    Private Sub CourseNew_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(courseNameText.Text) Then
            MessageBox.Show("コース名を入力してください。")
            Return
        End If
        Try
            Database.InsertCourse(courseCodeText.Text.Trim(), courseNameText.Text.Trim(), CInt(courseTimeSystemNumeric.Value), CInt(courseFeeNumeric.Value))
            ReloadCourses()
        Catch ex As Exception
            MessageBox.Show("登録に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub CourseUpdate_Click(sender As Object, e As EventArgs)
        If courseGrid.CurrentRow Is Nothing Then
            MessageBox.Show("更新対象をグリッドから選択してください。")
            Return
        End If
        Try
            Database.UpdateCourse(courseCodeText.Text.Trim(), courseNameText.Text.Trim(), CInt(courseTimeSystemNumeric.Value), CInt(courseFeeNumeric.Value))
            ReloadCourses()
        Catch ex As Exception
            MessageBox.Show("更新に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub CourseDelete_Click(sender As Object, e As EventArgs)
        If courseGrid.CurrentRow Is Nothing Then
            MessageBox.Show("削除対象をグリッドから選択してください。")
            Return
        End If
        If MessageBox.Show($"コース「{courseNameText.Text}」を削除しますか？", "確認", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Try
            Database.DeleteCourse(courseCodeText.Text.Trim())
            ReloadCourses()
        Catch ex As Exception
            MessageBox.Show("削除に失敗しました（入室情報から参照されている可能性があります）: " & ex.Message)
        End Try
    End Sub

    ' =====================================================================
    ' オプション管理
    ' =====================================================================

    Private Sub BuildOptionTab()
        Dim page As New TabPage("オプション管理")
        tabControl.TabPages.Add(page)

        Dim editPanel = MakeEditPanel()

        Dim lblCode As New Label() With {.Text = "オプションコード", .Location = New Point(10, 13), .AutoSize = True}
        optionCodeText = New TextBox() With {.Location = New Point(130, 10), .Width = 80, .Enabled = False}
        Dim lblName As New Label() With {.Text = "オプション名", .Location = New Point(230, 13), .AutoSize = True}
        optionNameText = New TextBox() With {.Location = New Point(330, 10), .Width = 200}
        Dim lblFee As New Label() With {.Text = "料金", .Location = New Point(550, 13), .AutoSize = True}
        optionFeeNumeric = New NumericUpDown() With {.Location = New Point(590, 10), .Width = 80, .Minimum = 0, .Maximum = 999999}
        Dim lblShort As New Label() With {.Text = "短縮名", .Location = New Point(690, 13), .AutoSize = True}
        optionShortNameText = New TextBox() With {.Location = New Point(750, 10), .Width = 60} ' ボタン表示用の短縮名

        Dim btnNew As New Button() With {.Text = "新規登録", .Location = New Point(10, 48), .Width = 100}
        Dim btnUpdate As New Button() With {.Text = "更新", .Location = New Point(120, 48), .Width = 100}
        Dim btnDelete As New Button() With {.Text = "削除", .Location = New Point(230, 48), .Width = 100}
        Dim btnClear As New Button() With {.Text = "クリア", .Location = New Point(340, 48), .Width = 100}

        AddHandler btnNew.Click, AddressOf OptionNew_Click
        AddHandler btnUpdate.Click, AddressOf OptionUpdate_Click
        AddHandler btnDelete.Click, AddressOf OptionDelete_Click
        AddHandler btnClear.Click, Sub() ClearOptionFields()

        editPanel.Controls.AddRange({lblCode, optionCodeText, lblName, optionNameText, lblFee, optionFeeNumeric, lblShort, optionShortNameText, btnNew, btnUpdate, btnDelete, btnClear})
        page.Controls.Add(editPanel)

        optionGrid = MakeGrid()
        AddHandler optionGrid.SelectionChanged, AddressOf OptionGrid_SelectionChanged
        page.Controls.Add(optionGrid)
    End Sub

    Private Sub ReloadOptions()
        optionGrid.DataSource = Database.GetAllOptions()
        ApplyHeader(optionGrid, "option_code", "コード")
        ApplyHeader(optionGrid, "option_name", "オプション名")
        ApplyHeader(optionGrid, "fee", "料金")
        ApplyHeader(optionGrid, "short_name", "短縮名")
        ClearOptionFields()
    End Sub

    Private Sub OptionGrid_SelectionChanged(sender As Object, e As EventArgs)
        If optionGrid.CurrentRow Is Nothing Then Return
        Dim row = optionGrid.CurrentRow
        optionCodeText.Text = row.Cells("option_code").Value.ToString()
        optionNameText.Text = row.Cells("option_name").Value.ToString()
        optionFeeNumeric.Value = CDec(row.Cells("fee").Value)
        optionShortNameText.Text = row.Cells("short_name").Value.ToString()
    End Sub

    Private Sub ClearOptionFields()
        optionCodeText.Text = Database.GetNextOptionCode()
        optionNameText.Clear()
        optionFeeNumeric.Value = 0
        optionShortNameText.Clear()
        optionGrid.ClearSelection()
    End Sub

    Private Sub OptionNew_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(optionNameText.Text) Then
            MessageBox.Show("オプション名を入力してください。")
            Return
        End If
        Try
            Database.InsertOption(optionCodeText.Text.Trim(), optionNameText.Text.Trim(), CInt(optionFeeNumeric.Value), optionShortNameText.Text.Trim())
            ReloadOptions()
        Catch ex As Exception
            MessageBox.Show("登録に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub OptionUpdate_Click(sender As Object, e As EventArgs)
        If optionGrid.CurrentRow Is Nothing Then
            MessageBox.Show("更新対象をグリッドから選択してください。")
            Return
        End If
        Try
            Database.UpdateOption(optionCodeText.Text.Trim(), optionNameText.Text.Trim(), CInt(optionFeeNumeric.Value), optionShortNameText.Text.Trim())
            ReloadOptions()
        Catch ex As Exception
            MessageBox.Show("更新に失敗しました: " & ex.Message)
        End Try
    End Sub

    Private Sub OptionDelete_Click(sender As Object, e As EventArgs)
        If optionGrid.CurrentRow Is Nothing Then
            MessageBox.Show("削除対象をグリッドから選択してください。")
            Return
        End If
        If MessageBox.Show($"オプション「{optionNameText.Text}」を削除しますか？", "確認", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Try
            Database.DeleteOption(optionCodeText.Text.Trim())
            ReloadOptions()
        Catch ex As Exception
            MessageBox.Show("削除に失敗しました（入室情報から参照されている可能性があります）: " & ex.Message)
        End Try
    End Sub

End Class
