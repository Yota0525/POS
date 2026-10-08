Imports System.Data
Imports Microsoft.Data.Sqlite

''' DB接続の確立とテーブル初期化を行う
Public Module Database

    Private ReadOnly DbFileName As String = "maneki-casher.db"

    Public ReadOnly Property DbPath As String
        Get
            ' bin\Debug\net8.0-windows から3つ上がるとプロジェクトルート(.vbprojのある場所)になる。
            ' ここに置くことでgit管理下に入り、チームでデータを共有できる(bin/はgitignoreされているため)。
            Dim projectRoot = IO.Path.GetFullPath(IO.Path.Combine(Application.StartupPath, "..", "..", ".."))
            Return IO.Path.Combine(projectRoot, DbFileName)
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
                        name TEXT NOT NULL,
                        fee INTEGER NOT NULL DEFAULT 0,
                        short_name TEXT NOT NULL DEFAULT ''
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

                    CREATE TABLE IF NOT EXISTS member_categories (
                        category_code TEXT PRIMARY KEY,
                        category_name TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS member_ranks (
                        rank_code TEXT PRIMARY KEY,
                        rank_name TEXT NOT NULL,
                        discount_note TEXT
                    );

                    CREATE TABLE IF NOT EXISTS members (
                        member_code TEXT PRIMARY KEY,
                        category_code TEXT NOT NULL,
                        rank_code TEXT NOT NULL,
                        notes TEXT,
                        FOREIGN KEY (category_code) REFERENCES member_categories(category_code),
                        FOREIGN KEY (rank_code) REFERENCES member_ranks(rank_code)
                    );

                    CREATE TABLE IF NOT EXISTS courses (
                        course_code TEXT PRIMARY KEY,
                        course_name TEXT NOT NULL,
                        time_system_type INTEGER NOT NULL,
                        fee INTEGER NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS options (
                        option_code TEXT PRIMARY KEY,
                        option_name TEXT NOT NULL,
                        fee INTEGER NOT NULL,
                        short_name TEXT NOT NULL DEFAULT ''
                    );

                    CREATE TABLE IF NOT EXISTS entries (
                        entry_code TEXT PRIMARY KEY,
                        room_no INTEGER NOT NULL,
                        member_code TEXT,
                        count_adult INTEGER,
                        count_age_7_15 INTEGER,
                        count_age_18_19 INTEGER,
                        count_child INTEGER,
                        is_high_school INTEGER NOT NULL DEFAULT 0,
                        entry_time TEXT NOT NULL,
                        exit_time TEXT,
                        course_code TEXT NOT NULL,
                        usage_minutes INTEGER,
                        manufacturer_code TEXT NOT NULL,
                        model_code TEXT NOT NULL,
                        room_type_code TEXT,
                        option_code TEXT,
                        service_minutes INTEGER,
                        planned_amount_total INTEGER,
                        planned_amount_adjust1 INTEGER,
                        planned_amount_adjust2 INTEGER,
                        planned_amount_adjust3 INTEGER,
                        additional_entry_code TEXT,
                        FOREIGN KEY (room_no) REFERENCES rooms(room_no),
                        FOREIGN KEY (member_code) REFERENCES members(member_code),
                        FOREIGN KEY (course_code) REFERENCES courses(course_code),
                        FOREIGN KEY (manufacturer_code) REFERENCES manufacturers(manufacturer_code),
                        FOREIGN KEY (model_code) REFERENCES models(model_code),
                        FOREIGN KEY (room_type_code) REFERENCES room_types(room_type_code),
                        FOREIGN KEY (option_code) REFERENCES options(option_code),
                        FOREIGN KEY (additional_entry_code) REFERENCES entries(entry_code)
                    );
                "
                cmd.ExecuteNonQuery()
            End Using

            ' 既存のDBファイルに無い列を後から追加するための移行処理
            AddColumnIfMissing(conn, "menu_buttons", "is_enabled", "INTEGER NOT NULL DEFAULT 1")
            AddColumnIfMissing(conn, "room_types", "fee", "INTEGER NOT NULL DEFAULT 0")
            AddColumnIfMissing(conn, "room_types", "short_name", "TEXT NOT NULL DEFAULT ''")
            AddColumnIfMissing(conn, "options", "short_name", "TEXT NOT NULL DEFAULT ''")
        End Using
    End Sub

    ''' 指定したテーブルに指定した列が無ければ追加する(既存DBファイルへの移行用)
    Private Sub AddColumnIfMissing(conn As SqliteConnection, tableName As String, columnName As String, columnDefinition As String)
        Dim hasColumn As Boolean = False
        Using cmd = conn.CreateCommand()
            cmd.CommandText = $"PRAGMA table_info({tableName})"
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    If reader("name").ToString() = columnName Then
                        hasColumn = True
                        Exit While
                    End If
                End While
            End Using
        End Using

        If Not hasColumn Then
            Using cmd = conn.CreateCommand()
                cmd.CommandText = $"ALTER TABLE {tableName} ADD COLUMN {columnName} {columnDefinition}"
                cmd.ExecuteNonQuery()
            End Using
        End If
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

    Public Sub InsertRoomType(roomTypeCode As String, name As String, fee As Integer, shortName As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "INSERT INTO room_types (room_type_code, name, fee, short_name) VALUES ($code, $name, $fee, $shortName)"
                cmd.Parameters.AddWithValue("$code", roomTypeCode)
                cmd.Parameters.AddWithValue("$name", name)
                cmd.Parameters.AddWithValue("$fee", fee)
                cmd.Parameters.AddWithValue("$shortName", shortName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub InsertMemberCategory(categoryCode As String, categoryName As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "INSERT INTO member_categories (category_code, category_name) VALUES ($code, $name)"
                cmd.Parameters.AddWithValue("$code", categoryCode)
                cmd.Parameters.AddWithValue("$name", categoryName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub InsertMemberRank(rankCode As String, rankName As String, discountNote As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "INSERT INTO member_ranks (rank_code, rank_name, discount_note) VALUES ($code, $name, $note)"
                cmd.Parameters.AddWithValue("$code", rankCode)
                cmd.Parameters.AddWithValue("$name", rankName)
                cmd.Parameters.AddWithValue("$note", If(String.IsNullOrEmpty(discountNote), CType(DBNull.Value, Object), discountNote))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub InsertCourse(courseCode As String, courseName As String, timeSystemType As Integer, fee As Integer)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "INSERT INTO courses (course_code, course_name, time_system_type, fee) VALUES ($code, $name, $type, $fee)"
                cmd.Parameters.AddWithValue("$code", courseCode)
                cmd.Parameters.AddWithValue("$name", courseName)
                cmd.Parameters.AddWithValue("$type", timeSystemType)
                cmd.Parameters.AddWithValue("$fee", fee)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub InsertOption(optionCode As String, optionName As String, fee As Integer, shortName As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "INSERT INTO options (option_code, option_name, fee, short_name) VALUES ($code, $name, $fee, $shortName)"
                cmd.Parameters.AddWithValue("$code", optionCode)
                cmd.Parameters.AddWithValue("$name", optionName)
                cmd.Parameters.AddWithValue("$fee", fee)
                cmd.Parameters.AddWithValue("$shortName", shortName)
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

    Public Sub UpdateRoomType(roomTypeCode As String, name As String, fee As Integer, shortName As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE room_types SET name = $name, fee = $fee, short_name = $shortName WHERE room_type_code = $code"
                cmd.Parameters.AddWithValue("$code", roomTypeCode)
                cmd.Parameters.AddWithValue("$name", name)
                cmd.Parameters.AddWithValue("$fee", fee)
                cmd.Parameters.AddWithValue("$shortName", shortName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateMemberCategory(categoryCode As String, categoryName As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE member_categories SET category_name = $name WHERE category_code = $code"
                cmd.Parameters.AddWithValue("$code", categoryCode)
                cmd.Parameters.AddWithValue("$name", categoryName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateMemberRank(rankCode As String, rankName As String, discountNote As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE member_ranks SET rank_name = $name, discount_note = $note WHERE rank_code = $code"
                cmd.Parameters.AddWithValue("$code", rankCode)
                cmd.Parameters.AddWithValue("$name", rankName)
                cmd.Parameters.AddWithValue("$note", If(String.IsNullOrEmpty(discountNote), CType(DBNull.Value, Object), discountNote))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateCourse(courseCode As String, courseName As String, timeSystemType As Integer, fee As Integer)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE courses SET course_name = $name, time_system_type = $type, fee = $fee WHERE course_code = $code"
                cmd.Parameters.AddWithValue("$code", courseCode)
                cmd.Parameters.AddWithValue("$name", courseName)
                cmd.Parameters.AddWithValue("$type", timeSystemType)
                cmd.Parameters.AddWithValue("$fee", fee)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateOption(optionCode As String, optionName As String, fee As Integer, shortName As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE options SET option_name = $name, fee = $fee, short_name = $shortName WHERE option_code = $code"
                cmd.Parameters.AddWithValue("$code", optionCode)
                cmd.Parameters.AddWithValue("$name", optionName)
                cmd.Parameters.AddWithValue("$fee", fee)
                cmd.Parameters.AddWithValue("$shortName", shortName)
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

    Public Sub DeleteMemberCategory(categoryCode As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "DELETE FROM member_categories WHERE category_code = $code"
                cmd.Parameters.AddWithValue("$code", categoryCode)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteMemberRank(rankCode As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "DELETE FROM member_ranks WHERE rank_code = $code"
                cmd.Parameters.AddWithValue("$code", rankCode)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteCourse(courseCode As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "DELETE FROM courses WHERE course_code = $code"
                cmd.Parameters.AddWithValue("$code", courseCode)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteOption(optionCode As String)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "DELETE FROM options WHERE option_code = $code"
                cmd.Parameters.AddWithValue("$code", optionCode)
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

    Public Function GetNextMemberCategoryCode() As String
        Return GetNextCode("member_categories", "category_code")
    End Function

    Public Function GetNextMemberRankCode() As String
        Return GetNextCode("member_ranks", "rank_code")
    End Function

    Public Function GetNextMemberCode() As String
        Return GetNextCode("members", "member_code")
    End Function

    Public Function GetNextCourseCode() As String
        Return GetNextCode("courses", "course_code")
    End Function

    Public Function GetNextOptionCode() As String
        Return GetNextCode("options", "option_code")
    End Function

    Public Function GetNextEntryCode() As String
        Return GetNextCode("entries", "entry_code")
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
        Return GetTable("SELECT room_type_code, name, fee, short_name FROM room_types ORDER BY room_type_code")
    End Function

    Public Function GetAllMemberCategories() As DataTable
        Return GetTable("SELECT category_code, category_name FROM member_categories ORDER BY category_code")
    End Function

    Public Function GetAllMemberRanks() As DataTable
        Return GetTable("SELECT rank_code, rank_name, discount_note FROM member_ranks ORDER BY rank_code")
    End Function

    Public Function GetAllCourses() As DataTable
        Return GetTable("SELECT course_code, course_name, time_system_type, fee FROM courses ORDER BY course_code")
    End Function

    Public Function GetAllOptions() As DataTable
        Return GetTable("SELECT option_code, option_name, fee, short_name FROM options ORDER BY option_code")
    End Function

    ''' 部屋一覧（部屋種別名・短縮名・機種名を結合した表示用）
    Public Function GetAllRooms() As DataTable
        Return GetTable("
            SELECT r.room_no, r.room_type_code, rt.name AS room_type_name, rt.short_name AS room_type_short_name,
                   r.model_code, m.model_name, r.capacity_min, r.capacity_max
            FROM rooms r
            JOIN room_types rt ON rt.room_type_code = r.room_type_code
            JOIN models m ON m.model_code = r.model_code
            ORDER BY r.room_no
        ")
    End Function

    ''' 現在使用中(退室時間が未記録)の入室情報一覧。部屋番号ごとに1件を想定
    Public Function GetActiveEntries() As DataTable
        Return GetTable("
            SELECT e.room_no, e.entry_time, e.usage_minutes,
                   e.count_adult, e.count_age_7_15, e.count_age_18_19, e.count_child,
                   c.course_name,
                   o.option_name, o.short_name AS option_short_name
            FROM entries e
            JOIN courses c ON c.course_code = e.course_code
            LEFT JOIN options o ON o.option_code = e.option_code
            WHERE e.exit_time IS NULL
        ")
    End Function

    ''' 指定したメーカーに属する機種一覧(EnterRoomFormの機種コンボ絞り込み用)
    Public Function GetModelsByManufacturer(manufacturerCode As String) As DataTable
        Dim table As New DataTable()
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "SELECT model_code, model_name FROM models WHERE manufacturer_code = $code ORDER BY model_code"
                cmd.Parameters.AddWithValue("$code", manufacturerCode)
                Using reader = cmd.ExecuteReader()
                    table.Load(reader)
                End Using
            End Using
        End Using
        Return table
    End Function

    ''' 会員コードから区分名・ランク名を参照する(見つからなければNothing)
    Public Function GetMemberInfo(memberCode As String) As DataRow
        Dim table As New DataTable()
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "
                    SELECT mc.category_name, mr.rank_name
                    FROM members m
                    JOIN member_categories mc ON mc.category_code = m.category_code
                    JOIN member_ranks mr ON mr.rank_code = m.rank_code
                    WHERE m.member_code = $code
                "
                cmd.Parameters.AddWithValue("$code", memberCode)
                Using reader = cmd.ExecuteReader()
                    table.Load(reader)
                End Using
            End Using
        End Using
        If table.Rows.Count = 0 Then Return Nothing
        Return table.Rows(0)
    End Function

    ''' DBNull変換ヘルパー。Nothingや空文字をDBNullに変換する
    Private Function NzParam(value As Object) As Object
        If value Is Nothing Then Return DBNull.Value
        If TypeOf value Is String AndAlso String.IsNullOrEmpty(CStr(value)) Then Return DBNull.Value
        Return value
    End Function

    ''' 入室情報を1件登録する
    Public Sub InsertEntry(entryCode As String, roomNo As Integer, memberCode As String,
                            countAdult As Integer?, countAge7To15 As Integer?, countAge18To19 As Integer?, countChild As Integer?,
                            isHighSchool As Boolean, entryTime As DateTime, courseCode As String, usageMinutes As Integer?,
                            manufacturerCode As String, modelCode As String, roomTypeCode As String, optionCode As String,
                            serviceMinutes As Integer?, plannedAmountTotal As Integer?, plannedAmountAdjust1 As Integer?,
                            plannedAmountAdjust2 As Integer?, plannedAmountAdjust3 As Integer?)
        Using conn = GetConnection()
            Using cmd = conn.CreateCommand()
                cmd.CommandText = "
                    INSERT INTO entries (
                        entry_code, room_no, member_code, count_adult, count_age_7_15, count_age_18_19, count_child,
                        is_high_school, entry_time, exit_time, course_code, usage_minutes, manufacturer_code, model_code,
                        room_type_code, option_code, service_minutes, planned_amount_total, planned_amount_adjust1,
                        planned_amount_adjust2, planned_amount_adjust3, additional_entry_code
                    ) VALUES (
                        $entryCode, $roomNo, $memberCode, $countAdult, $count7_15, $count18_19, $countChild,
                        $isHighSchool, $entryTime, NULL, $courseCode, $usageMinutes, $makerCode, $modelCode,
                        $roomTypeCode, $optionCode, $serviceMinutes, $amountTotal, $amountAdjust1,
                        $amountAdjust2, $amountAdjust3, NULL
                    )
                "
                cmd.Parameters.AddWithValue("$entryCode", entryCode)
                cmd.Parameters.AddWithValue("$roomNo", roomNo)
                cmd.Parameters.AddWithValue("$memberCode", NzParam(memberCode))
                cmd.Parameters.AddWithValue("$countAdult", NzParam(countAdult))
                cmd.Parameters.AddWithValue("$count7_15", NzParam(countAge7To15))
                cmd.Parameters.AddWithValue("$count18_19", NzParam(countAge18To19))
                cmd.Parameters.AddWithValue("$countChild", NzParam(countChild))
                cmd.Parameters.AddWithValue("$isHighSchool", If(isHighSchool, 1, 0))
                cmd.Parameters.AddWithValue("$entryTime", entryTime.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.Parameters.AddWithValue("$courseCode", courseCode)
                cmd.Parameters.AddWithValue("$usageMinutes", NzParam(usageMinutes))
                cmd.Parameters.AddWithValue("$makerCode", manufacturerCode)
                cmd.Parameters.AddWithValue("$modelCode", modelCode)
                cmd.Parameters.AddWithValue("$roomTypeCode", NzParam(roomTypeCode))
                cmd.Parameters.AddWithValue("$optionCode", NzParam(optionCode))
                cmd.Parameters.AddWithValue("$serviceMinutes", NzParam(serviceMinutes))
                cmd.Parameters.AddWithValue("$amountTotal", NzParam(plannedAmountTotal))
                cmd.Parameters.AddWithValue("$amountAdjust1", NzParam(plannedAmountAdjust1))
                cmd.Parameters.AddWithValue("$amountAdjust2", NzParam(plannedAmountAdjust2))
                cmd.Parameters.AddWithValue("$amountAdjust3", NzParam(plannedAmountAdjust3))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
