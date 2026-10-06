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

    ' --- 部屋タブ ---
    Private roomGrid As DataGridView
    Private roomNoNumeric As NumericUpDown
    Private roomTypeCombo As ComboBox
    Private roomModelCombo As ComboBox
    Private roomCapMinNumeric As NumericUpDown
    Private roomCapMaxNumeric As NumericUpDown

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

        ReloadManufacturers()
        ReloadModels()
        ReloadRoomTypes()
        ReloadRooms()
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
        rtNameText = New TextBox() With {.Location = New Point(340, 10), .Width = 300}

        Dim btnNew As New Button() With {.Text = "新規登録", .Location = New Point(10, 48), .Width = 100}
        Dim btnUpdate As New Button() With {.Text = "更新", .Location = New Point(120, 48), .Width = 100}
        Dim btnDelete As New Button() With {.Text = "削除", .Location = New Point(230, 48), .Width = 100}
        Dim btnClear As New Button() With {.Text = "クリア", .Location = New Point(340, 48), .Width = 100}

        AddHandler btnNew.Click, AddressOf RtNew_Click
        AddHandler btnUpdate.Click, AddressOf RtUpdate_Click
        AddHandler btnDelete.Click, AddressOf RtDelete_Click
        AddHandler btnClear.Click, Sub() ClearRoomTypeFields()

        editPanel.Controls.AddRange({lblCode, rtCodeText, lblName, rtNameText, btnNew, btnUpdate, btnDelete, btnClear})
        page.Controls.Add(editPanel)

        rtGrid = MakeGrid()
        AddHandler rtGrid.SelectionChanged, AddressOf RtGrid_SelectionChanged
        page.Controls.Add(rtGrid)
    End Sub

    Private Sub ReloadRoomTypes()
        rtGrid.DataSource = Database.GetAllRoomTypes()
        ApplyHeader(rtGrid, "room_type_code", "コード")
        ApplyHeader(rtGrid, "name", "名前")
        ClearRoomTypeFields()
    End Sub

    Private Sub RtGrid_SelectionChanged(sender As Object, e As EventArgs)
        If rtGrid.CurrentRow Is Nothing Then Return
        Dim row = rtGrid.CurrentRow
        rtCodeText.Text = row.Cells("room_type_code").Value.ToString()
        rtNameText.Text = row.Cells("name").Value.ToString()
    End Sub

    ''' 入力欄をクリアし、次に登録される自動採番コードを表示する
    Private Sub ClearRoomTypeFields()
        rtCodeText.Text = Database.GetNextRoomTypeCode()
        rtNameText.Clear()
        rtGrid.ClearSelection()
    End Sub

    Private Sub RtNew_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(rtCodeText.Text) OrElse String.IsNullOrWhiteSpace(rtNameText.Text) Then
            MessageBox.Show("コードと名前を入力してください。")
            Return
        End If
        Try
            Database.InsertRoomType(rtCodeText.Text.Trim(), rtNameText.Text.Trim())
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
            Database.UpdateRoomType(rtCodeText.Text.Trim(), rtNameText.Text.Trim())
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

End Class
