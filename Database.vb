Imports System.Data
Imports Microsoft.Data.Sqlite

''' DB接続の確立とテーブル初期化を行う
Public Module Database

    Private ReadOnly DbFileName As String = "maneki-casher.db"

    Public ReadOnly Property DbPath As String
        Get
            Return IO.Path.Combine(Application.StartupPath, DbFileName)
        End Get
    End Property

    Public Function GetConnection() As SqliteConnection
        Dim conn As New SqliteConnection($"Data Source={DbPath}")
        conn.Open()
        ' SQLiteは既定で外部キー制約が無効なため、接続ごとに有効化する
        Using cmd = conn.CreateCommand()
            cmd.CommandText = "PRAGMA foreign_keys = ON;"
            cmd.ExecuteNonQuery()
        End Using
        Return conn
    End Function

    ''' 4テーブルが存在しない場合に作成する
    Public Sub InitializeDatabase()
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "
                    CREATE TABLE IF NOT EXISTS manufacturers (
                        manufacturer_code TEXT PRIMARY KEY,
                        manufacturer_name TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS models (
                        model_code TEXT PRIMARY KEY,
                        manufacturer_code TEXT NOT NULL,
                        model_name TEXT NOT NULL,
                        FOREIGN KEY (manufacturer_code) REFERENCES manufacturers(manufacturer_code)
                    );

                    CREATE TABLE IF NOT EXISTS room_types (
                        room_type_code TEXT PRIMARY KEY,
                        name TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS rooms (
                        room_no INTEGER PRIMARY KEY,
                        room_type_code TEXT NOT NULL,
                        model_code TEXT NOT NULL,
                        capacity_min INTEGER NOT NULL,
                        capacity_max INTEGER NOT NULL,
                        FOREIGN KEY (room_type_code) REFERENCES room_types(room_type_code),
                        FOREIGN KEY (model_code) REFERENCES models(model_code)
                    );

                    CREATE TABLE IF NOT EXISTS menu_buttons (
                        sort_order INTEGER PRIMARY KEY,
                        display_name TEXT NOT NULL,
                        back_color TEXT NOT NULL,
                        is_enabled INTEGER NOT NULL DEFAULT 1
                    );
                "
                cmd.ExecuteNonQuery()
            End Using

            ' 既存のDBファイルで menu_buttons テーブルが is_enabled 列を持たないまま作成されている場合に備えた移行処理
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "PRAGMA table_info(menu_buttons)"
                Dim hasIsEnabled As Boolean = False
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        If reader("name").ToString() = "is_enabled" Then
                            hasIsEnabled = True
                            Exit While
                        End If
                    End While
                End Using

                If Not hasIsEnabled Then
                    Using alterCmd = conn.CreateCommand()
                        alterCmd.CommandText = "ALTER TABLE menu_buttons ADD COLUMN is_enabled INTEGER NOT NULL DEFAULT 1"
                        alterCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
        End Using
    End Sub

    ' --- 登録用メソッド ---

    Public Sub InsertManufacturer(manufacturerCode As String, manufacturerName As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "INSERT INTO manufacturers (manufacturer_code, manufacturer_name) VALUES ($code, $name)"
                cmd.Parameters.AddWithValue("$code", manufacturerCode)
                cmd.Parameters.AddWithValue("$name", manufacturerName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub InsertModel(modelCode As String, manufacturerCode As String, modelName As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "INSERT INTO models (model_code, manufacturer_code, model_name) VALUES ($code, $makerCode, $name)"
                cmd.Parameters.AddWithValue("$code", modelCode)
                cmd.Parameters.AddWithValue("$makerCode", manufacturerCode)
                cmd.Parameters.AddWithValue("$name", modelName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub InsertRoomType(roomTypeCode As String, name As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "INSERT INTO room_types (room_type_code, name) VALUES ($code, $name)"
                cmd.Parameters.AddWithValue("$code", roomTypeCode)
                cmd.Parameters.AddWithValue("$name", name)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub InsertRoom(roomNo As Integer, roomTypeCode As String, modelCode As String, capacityMin As Integer, capacityMax As Integer)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "INSERT INTO rooms (room_no, room_type_code, model_code, capacity_min, capacity_max) VALUES ($no, $typeCode, $modelCode, $min, $max)"
                cmd.Parameters.AddWithValue("$no", roomNo)
                cmd.Parameters.AddWithValue("$typeCode", roomTypeCode)
                cmd.Parameters.AddWithValue("$modelCode", modelCode)
                cmd.Parameters.AddWithValue("$min", capacityMin)
                cmd.Parameters.AddWithValue("$max", capacityMax)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' --- 更新用メソッド ---

    Public Sub UpdateManufacturer(manufacturerCode As String, manufacturerName As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE manufacturers SET manufacturer_name = $name WHERE manufacturer_code = $code"
                cmd.Parameters.AddWithValue("$code", manufacturerCode)
                cmd.Parameters.AddWithValue("$name", manufacturerName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateModel(modelCode As String, manufacturerCode As String, modelName As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE models SET manufacturer_code = $makerCode, model_name = $name WHERE model_code = $code"
                cmd.Parameters.AddWithValue("$code", modelCode)
                cmd.Parameters.AddWithValue("$makerCode", manufacturerCode)
                cmd.Parameters.AddWithValue("$name", modelName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateRoomType(roomTypeCode As String, name As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE room_types SET name = $name WHERE room_type_code = $code"
                cmd.Parameters.AddWithValue("$code", roomTypeCode)
                cmd.Parameters.AddWithValue("$name", name)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateRoom(roomNo As Integer, roomTypeCode As String, modelCode As String, capacityMin As Integer, capacityMax As Integer)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE rooms SET room_type_code = $typeCode, model_code = $modelCode, capacity_min = $min, capacity_max = $max WHERE room_no = $no"
                cmd.Parameters.AddWithValue("$no", roomNo)
                cmd.Parameters.AddWithValue("$typeCode", roomTypeCode)
                cmd.Parameters.AddWithValue("$modelCode", modelCode)
                cmd.Parameters.AddWithValue("$min", capacityMin)
                cmd.Parameters.AddWithValue("$max", capacityMax)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' --- 削除用メソッド ---

    Public Sub DeleteManufacturer(manufacturerCode As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "DELETE FROM manufacturers WHERE manufacturer_code = $code"
                cmd.Parameters.AddWithValue("$code", manufacturerCode)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteModel(modelCode As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "DELETE FROM models WHERE model_code = $code"
                cmd.Parameters.AddWithValue("$code", modelCode)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteRoomType(roomTypeCode As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "DELETE FROM room_types WHERE room_type_code = $code"
                cmd.Parameters.AddWithValue("$code", roomTypeCode)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteRoom(roomNo As Integer)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "DELETE FROM rooms WHERE room_no = $no"
                cmd.Parameters.AddWithValue("$no", roomNo)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' --- 採番用メソッド（コード/番号は手入力させず、既存の最大値+1を自動採番する） ---

    Private Function GetNextCode(tableName As String, columnName As String) As String
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                ' コード列はTEXTだが数値文字列として運用するため、数値に変換して最大値+1を求める
                cmd.CommandText = $"SELECT IFNULL(MAX(CAST({columnName} AS INTEGER)), 0) + 1 FROM {tableName}"
                Return CInt(cmd.ExecuteScalar()).ToString()
            End Using
        End Using
    End Function

    Public Function GetNextManufacturerCode() As String
        Return GetNextCode("manufacturers", "manufacturer_code")
    End Function

    Public Function GetNextModelCode() As String
        Return GetNextCode("models", "model_code")
    End Function

    Public Function GetNextRoomTypeCode() As String
        Return GetNextCode("room_types", "room_type_code")
    End Function

    Public Function GetNextRoomNo() As Integer
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "SELECT IFNULL(MAX(room_no), 0) + 1 FROM rooms"
                Return CInt(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function GetNextMenuButtonSortOrder() As Integer
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "SELECT IFNULL(MAX(sort_order), -1) + 1 FROM menu_buttons"
                Return CInt(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    ' --- メニューボタン用メソッド ---

    Public Sub InsertMenuButton(sortOrder As Integer, displayName As String, backColor As String, isEnabled As Boolean)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "INSERT INTO menu_buttons (sort_order, display_name, back_color, is_enabled) VALUES ($order, $name, $color, $enabled)"
                cmd.Parameters.AddWithValue("$order", sortOrder)
                cmd.Parameters.AddWithValue("$name", displayName)
                cmd.Parameters.AddWithValue("$color", backColor)
                cmd.Parameters.AddWithValue("$enabled", If(isEnabled, 1, 0))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' 表示順(主キー)自体の変更にも対応するため、更新対象を特定するoldSortOrderと、
    ''' 新しく設定したい値newSortOrderを分けて受け取る
    Public Sub UpdateMenuButton(oldSortOrder As Integer, newSortOrder As Integer, displayName As String, backColor As String, isEnabled As Boolean)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE menu_buttons SET sort_order = $newOrder, display_name = $name, back_color = $color, is_enabled = $enabled WHERE sort_order = $oldOrder"
                cmd.Parameters.AddWithValue("$oldOrder", oldSortOrder)
                cmd.Parameters.AddWithValue("$newOrder", newSortOrder)
                cmd.Parameters.AddWithValue("$name", displayName)
                cmd.Parameters.AddWithValue("$color", backColor)
                cmd.Parameters.AddWithValue("$enabled", If(isEnabled, 1, 0))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteMenuButton(sortOrder As Integer)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "DELETE FROM menu_buttons WHERE sort_order = $order"
                cmd.Parameters.AddWithValue("$order", sortOrder)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetAllMenuButtons() As DataTable
        Return GetTable("SELECT sort_order, display_name, back_color, is_enabled FROM menu_buttons ORDER BY sort_order")
    End Function

    ' --- 一覧取得用メソッド ---

    Private Function GetTable(sql As String) As DataTable
        Dim table As New DataTable()
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = sql
                Using reader = cmd.ExecuteReader()
                    table.Load(reader)
                End Using
            End Using
        End Using
        Return table
    End Function

    Public Function GetAllManufacturers() As DataTable
        Return GetTable("SELECT manufacturer_code, manufacturer_name FROM manufacturers ORDER BY manufacturer_code")
    End Function

    ''' 機種一覧（メーカー名を結合した表示用）
    Public Function GetAllModels() As DataTable
        Return GetTable("
            SELECT m.model_code, m.manufacturer_code, mk.manufacturer_name, m.model_name
            FROM models m
            JOIN manufacturers mk ON mk.manufacturer_code = m.manufacturer_code
            ORDER BY m.model_code
        ")
    End Function

    Public Function GetAllRoomTypes() As DataTable
        Return GetTable("SELECT room_type_code, name FROM room_types ORDER BY room_type_code")
    End Function

    ''' 部屋一覧（部屋種別名・機種名を結合した表示用）
    Public Function GetAllRooms() As DataTable
        Return GetTable("
            SELECT r.room_no, r.room_type_code, rt.name AS room_type_name, r.model_code, m.model_name, r.capacity_min, r.capacity_max
            FROM rooms r
            JOIN room_types rt ON rt.room_type_code = r.room_type_code
            JOIN models m ON m.model_code = r.model_code
            ORDER BY r.room_no
        ")
    End Function

End Module
