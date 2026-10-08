<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnterRoomForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        back_button = New Button()
        Label1 = New Label()
        entry_time = New TextBox()
        Label2 = New Label()
        member_code = New TextBox()
        Label3 = New Label()
        member_rank = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        register_button = New Button()
        exit_time = New TextBox()
        Label12 = New Label()
        course_combo = New ComboBox()
        Label14 = New Label()
        room_no = New TextBox()
        description_button = New Button()
        Label6 = New Label()
        Label7 = New Label()
        use_time = New TextBox()
        Label13 = New Label()
        additional_ability = New TextBox()
        Label8 = New Label()
        maker_combo = New ComboBox()
        Label15 = New Label()
        roomtype_combo = New ComboBox()
        Label9 = New Label()
        service_combo = New ComboBox()
        Label10 = New Label()
        price_1 = New TextBox()
        price_2 = New TextBox()
        price_3 = New TextBox()
        price_4 = New TextBox()
        Label11 = New Label()
        Label16 = New Label()
        machine_combo = New ComboBox()
        option_combo = New ComboBox()
        member_category = New TextBox()
        enter_count_button = New Button()
        age_7to15 = New TextBox()
        age_20 = New TextBox()
        Label17 = New Label()
        Label18 = New Label()
        age_6 = New TextBox()
        age_18to19 = New TextBox()
        Label19 = New Label()
        Label20 = New Label()
        high_school = New CheckBox()
        add_register_button = New Button()
        GroupBox1 = New GroupBox()
        key_button_0 = New Button()
        key_panel = New Panel()
        key_button_3 = New Button()
        key_button_6 = New Button()
        key_button_2 = New Button()
        key_button_5 = New Button()
        key_button_9 = New Button()
        key_button_1 = New Button()
        key_button_8 = New Button()
        key_button_4 = New Button()
        key_button_c = New Button()
        key_button_7 = New Button()
        Button5 = New Button()
        GroupBox1.SuspendLayout()
        key_panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' back_button
        ' 
        back_button.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        back_button.FlatAppearance.BorderColor = Color.White
        back_button.FlatAppearance.BorderSize = 2
        back_button.FlatStyle = FlatStyle.Flat
        back_button.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        back_button.Location = New Point(488, 692)
        back_button.Name = "back_button"
        back_button.Size = New Size(122, 64)
        back_button.TabIndex = 0
        back_button.Text = "戻　る"
        back_button.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Silver
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(17, 3, 17, 3)
        Label1.Size = New Size(118, 32)
        Label1.TabIndex = 1
        Label1.Text = "部屋No"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' entry_time
        ' 
        entry_time.BorderStyle = BorderStyle.FixedSingle
        entry_time.Font = New Font("ＭＳ ゴシック", 18.5F)
        entry_time.Location = New Point(133, 280)
        entry_time.Name = "entry_time"
        entry_time.Size = New Size(88, 32)
        entry_time.TabIndex = 2
        entry_time.Text = "00:00"
        entry_time.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 45)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(17, 3, 17, 3)
        Label2.Size = New Size(118, 32)
        Label2.TabIndex = 1
        Label2.Text = "会　員"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' member_code
        ' 
        member_code.BorderStyle = BorderStyle.FixedSingle
        member_code.Font = New Font("ＭＳ ゴシック", 18.5F)
        member_code.Location = New Point(133, 45)
        member_code.Name = "member_code"
        member_code.Size = New Size(303, 32)
        member_code.TabIndex = 2
        member_code.Text = "A1520080096099836B"
        member_code.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Silver
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 80)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(17, 3, 17, 3)
        Label3.Size = New Size(118, 32)
        Label3.TabIndex = 1
        Label3.Text = "ランク"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' member_rank
        ' 
        member_rank.BorderStyle = BorderStyle.FixedSingle
        member_rank.Font = New Font("ＭＳ ゴシック", 18.5F)
        member_rank.Location = New Point(133, 80)
        member_rank.Name = "member_rank"
        member_rank.Size = New Size(303, 32)
        member_rank.TabIndex = 2
        member_rank.Text = "レギュラー会員"
        member_rank.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Silver
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 168)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(17, 3, 17, 3)
        Label4.Size = New Size(118, 32)
        Label4.TabIndex = 1
        Label4.Text = "人　数"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Silver
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 280)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(5, 3, 5, 3)
        Label5.Size = New Size(118, 32)
        Label5.TabIndex = 1
        Label5.Text = "入室時間"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' register_button
        ' 
        register_button.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        register_button.FlatAppearance.BorderColor = Color.White
        register_button.FlatAppearance.BorderSize = 2
        register_button.FlatStyle = FlatStyle.Flat
        register_button.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        register_button.Location = New Point(8, 692)
        register_button.Name = "register_button"
        register_button.Size = New Size(122, 64)
        register_button.TabIndex = 0
        register_button.Text = "登　録"
        register_button.UseVisualStyleBackColor = False
        ' 
        ' exit_time
        ' 
        exit_time.BorderStyle = BorderStyle.FixedSingle
        exit_time.Font = New Font("ＭＳ ゴシック", 18.5F)
        exit_time.Location = New Point(339, 280)
        exit_time.Name = "exit_time"
        exit_time.Size = New Size(97, 32)
        exit_time.TabIndex = 2
        exit_time.Text = "00:00"
        exit_time.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Silver
        Label12.BorderStyle = BorderStyle.FixedSingle
        Label12.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(224, 280)
        Label12.Name = "Label12"
        Label12.Padding = New Padding(2, 3, 2, 3)
        Label12.Size = New Size(112, 32)
        Label12.TabIndex = 1
        Label12.Text = "退室時間"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' course_combo
        ' 
        course_combo.FlatStyle = FlatStyle.Flat
        course_combo.Font = New Font("ＭＳ ゴシック", 17.25F, FontStyle.Bold)
        course_combo.FormattingEnabled = True
        course_combo.Items.AddRange(New Object() {"時間制料金", "時間制料金1名", "昼フリータイム", "昼フリータイム1名", "0円コース", "ｲﾝﾊﾞｳﾝﾄﾞｿﾌﾄ飲放", "ｲﾝﾊﾞｳﾝﾄﾞｱﾙｺｰﾙ飲放", "ｲﾝﾊﾞｳﾝﾄﾞﾌｰﾄﾞ＆ｿﾌﾄ-2H", "ｲﾝﾊﾞｳﾝﾄﾞﾌｰﾄﾞ＆ｱﾙ-2H", "宴会コース2時間", "宴会コース3時間"})
        course_combo.Location = New Point(133, 318)
        course_combo.Name = "course_combo"
        course_combo.Size = New Size(303, 31)
        course_combo.TabIndex = 3
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Teal
        Label14.FlatStyle = FlatStyle.System
        Label14.Font = New Font("ＭＳ ゴシック", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label14.Location = New Point(254, 470)
        Label14.Name = "Label14"
        Label14.Size = New Size(40, 27)
        Label14.TabIndex = 1
        Label14.Text = "分"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' room_no
        ' 
        room_no.BorderStyle = BorderStyle.FixedSingle
        room_no.Font = New Font("ＭＳ ゴシック", 18.5F)
        room_no.Location = New Point(133, 9)
        room_no.Name = "room_no"
        room_no.Size = New Size(88, 32)
        room_no.TabIndex = 2
        room_no.Text = "00"
        room_no.TextAlign = HorizontalAlignment.Center
        ' 
        ' description_button
        ' 
        description_button.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        description_button.FlatAppearance.BorderColor = Color.White
        description_button.FlatAppearance.BorderSize = 2
        description_button.FlatStyle = FlatStyle.Flat
        description_button.Font = New Font("ＭＳ ゴシック", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        description_button.Location = New Point(439, 80)
        description_button.Name = "description_button"
        description_button.Size = New Size(150, 32)
        description_button.TabIndex = 0
        description_button.Text = "備考"
        description_button.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Silver
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 317)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(17, 3, 17, 3)
        Label6.Size = New Size(118, 32)
        Label6.TabIndex = 1
        Label6.Text = "コース"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Silver
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 354)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(5, 3, 5, 3)
        Label7.Size = New Size(118, 32)
        Label7.TabIndex = 1
        Label7.Text = "利用時間"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' use_time
        ' 
        use_time.BorderStyle = BorderStyle.FixedSingle
        use_time.Font = New Font("ＭＳ ゴシック", 18.5F)
        use_time.Location = New Point(133, 354)
        use_time.Name = "use_time"
        use_time.Size = New Size(97, 32)
        use_time.TabIndex = 2
        use_time.Text = "00:00"
        use_time.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Silver
        Label13.BorderStyle = BorderStyle.FixedSingle
        Label13.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(231, 354)
        Label13.Name = "Label13"
        Label13.Padding = New Padding(15, 3, 15, 3)
        Label13.Size = New Size(90, 32)
        Label13.TabIndex = 1
        Label13.Text = "延長"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' additional_ability
        ' 
        additional_ability.BorderStyle = BorderStyle.FixedSingle
        additional_ability.Font = New Font("ＭＳ ゴシック", 18.5F)
        additional_ability.Location = New Point(323, 354)
        additional_ability.Name = "additional_ability"
        additional_ability.Size = New Size(113, 32)
        additional_ability.TabIndex = 2
        additional_ability.Text = "可能"
        additional_ability.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Silver
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 391)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(5, 3, 5, 3)
        Label8.Size = New Size(118, 32)
        Label8.TabIndex = 1
        Label8.Text = "機種ﾒｰｶｰ"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' maker_combo
        ' 
        maker_combo.FlatStyle = FlatStyle.Flat
        maker_combo.Font = New Font("ＭＳ ゴシック", 17.25F, FontStyle.Bold)
        maker_combo.FormattingEnabled = True
        maker_combo.Items.AddRange(New Object() {"JOYSOUND", "DAM", "E-bo"})
        maker_combo.Location = New Point(133, 392)
        maker_combo.Name = "maker_combo"
        maker_combo.Size = New Size(266, 31)
        maker_combo.TabIndex = 3
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Silver
        Label15.BorderStyle = BorderStyle.FixedSingle
        Label15.Font = New Font("ＭＳ ゴシック", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label15.Location = New Point(12, 428)
        Label15.Name = "Label15"
        Label15.Padding = New Padding(1, 5, 1, 5)
        Label15.Size = New Size(118, 32)
        Label15.TabIndex = 1
        Label15.Text = "コンセプト"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' roomtype_combo
        ' 
        roomtype_combo.FlatStyle = FlatStyle.Flat
        roomtype_combo.Font = New Font("ＭＳ ゴシック", 17.25F, FontStyle.Bold)
        roomtype_combo.FormattingEnabled = True
        roomtype_combo.Items.AddRange(New Object() {"パーティールーム", "ミラPon!"})
        roomtype_combo.Location = New Point(133, 430)
        roomtype_combo.Name = "roomtype_combo"
        roomtype_combo.Size = New Size(266, 31)
        roomtype_combo.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Silver
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(12, 465)
        Label9.Name = "Label9"
        Label9.Padding = New Padding(5, 3, 5, 3)
        Label9.Size = New Size(118, 32)
        Label9.TabIndex = 1
        Label9.Text = "サービス"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' service_combo
        ' 
        service_combo.FlatStyle = FlatStyle.Flat
        service_combo.Font = New Font("ＭＳ ゴシック", 17.25F, FontStyle.Bold)
        service_combo.FormattingEnabled = True
        service_combo.Location = New Point(133, 466)
        service_combo.Name = "service_combo"
        service_combo.Size = New Size(115, 31)
        service_combo.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Silver
        Label10.BorderStyle = BorderStyle.FixedSingle
        Label10.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(12, 502)
        Label10.Name = "Label10"
        Label10.Padding = New Padding(5, 3, 5, 3)
        Label10.Size = New Size(118, 32)
        Label10.TabIndex = 1
        Label10.Text = "予定金額"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' price_1
        ' 
        price_1.BorderStyle = BorderStyle.FixedSingle
        price_1.Font = New Font("ＭＳ ゴシック", 18.5F)
        price_1.Location = New Point(133, 502)
        price_1.Name = "price_1"
        price_1.Size = New Size(152, 32)
        price_1.TabIndex = 2
        price_1.Text = "0"
        price_1.TextAlign = HorizontalAlignment.Right
        ' 
        ' price_2
        ' 
        price_2.BorderStyle = BorderStyle.FixedSingle
        price_2.Font = New Font("ＭＳ ゴシック", 18.5F)
        price_2.Location = New Point(286, 502)
        price_2.Name = "price_2"
        price_2.Size = New Size(113, 32)
        price_2.TabIndex = 2
        price_2.Text = "0"
        price_2.TextAlign = HorizontalAlignment.Right
        ' 
        ' price_3
        ' 
        price_3.BorderStyle = BorderStyle.FixedSingle
        price_3.Font = New Font("ＭＳ ゴシック", 18.5F)
        price_3.Location = New Point(400, 502)
        price_3.Name = "price_3"
        price_3.Size = New Size(113, 32)
        price_3.TabIndex = 2
        price_3.Text = "0"
        price_3.TextAlign = HorizontalAlignment.Right
        ' 
        ' price_4
        ' 
        price_4.BorderStyle = BorderStyle.FixedSingle
        price_4.Font = New Font("ＭＳ ゴシック", 18.5F)
        price_4.Location = New Point(514, 502)
        price_4.Name = "price_4"
        price_4.Size = New Size(113, 32)
        price_4.TabIndex = 2
        price_4.Text = "0"
        price_4.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Silver
        Label11.BorderStyle = BorderStyle.FixedSingle
        Label11.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(405, 391)
        Label11.Name = "Label11"
        Label11.Padding = New Padding(29, 3, 29, 3)
        Label11.Size = New Size(118, 32)
        Label11.TabIndex = 1
        Label11.Text = "機種"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Silver
        Label16.BorderStyle = BorderStyle.FixedSingle
        Label16.Font = New Font("ＭＳ ゴシック", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label16.Location = New Point(405, 430)
        Label16.Name = "Label16"
        Label16.Padding = New Padding(1, 5, 1, 5)
        Label16.Size = New Size(118, 32)
        Label16.TabIndex = 1
        Label16.Text = "オプション"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' machine_combo
        ' 
        machine_combo.FlatStyle = FlatStyle.Flat
        machine_combo.Font = New Font("ＭＳ ゴシック", 17.25F, FontStyle.Bold)
        machine_combo.FormattingEnabled = True
        machine_combo.Location = New Point(527, 392)
        machine_combo.Name = "machine_combo"
        machine_combo.Size = New Size(266, 31)
        machine_combo.TabIndex = 3
        ' 
        ' option_combo
        ' 
        option_combo.FlatStyle = FlatStyle.Flat
        option_combo.Font = New Font("ＭＳ ゴシック", 17.25F, FontStyle.Bold)
        option_combo.FormattingEnabled = True
        option_combo.Location = New Point(527, 430)
        option_combo.Name = "option_combo"
        option_combo.Size = New Size(266, 31)
        option_combo.TabIndex = 3
        ' 
        ' member_category
        ' 
        member_category.BorderStyle = BorderStyle.FixedSingle
        member_category.Font = New Font("ＭＳ ゴシック", 18.5F)
        member_category.Location = New Point(439, 45)
        member_category.Name = "member_category"
        member_category.Size = New Size(184, 32)
        member_category.TabIndex = 2
        member_category.Text = "一般"
        ' 
        ' enter_count_button
        ' 
        enter_count_button.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        enter_count_button.FlatAppearance.BorderColor = Color.White
        enter_count_button.FlatAppearance.BorderSize = 2
        enter_count_button.FlatStyle = FlatStyle.Flat
        enter_count_button.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        enter_count_button.Location = New Point(154, 151)
        enter_count_button.Name = "enter_count_button"
        enter_count_button.Size = New Size(131, 64)
        enter_count_button.TabIndex = 0
        enter_count_button.Text = "人数入力"
        enter_count_button.UseVisualStyleBackColor = False
        ' 
        ' age_7to15
        ' 
        age_7to15.BorderStyle = BorderStyle.FixedSingle
        age_7to15.Font = New Font("ＭＳ ゴシック", 18.5F)
        age_7to15.Location = New Point(433, 183)
        age_7to15.Name = "age_7to15"
        age_7to15.Size = New Size(64, 32)
        age_7to15.TabIndex = 2
        age_7to15.Text = "0"
        age_7to15.TextAlign = HorizontalAlignment.Center
        ' 
        ' age_20
        ' 
        age_20.BorderStyle = BorderStyle.FixedSingle
        age_20.Font = New Font("ＭＳ ゴシック", 18.5F)
        age_20.Location = New Point(433, 148)
        age_20.Name = "age_20"
        age_20.Size = New Size(64, 32)
        age_20.TabIndex = 2
        age_20.Text = "0"
        age_20.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Teal
        Label17.FlatStyle = FlatStyle.System
        Label17.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label17.Location = New Point(323, 151)
        Label17.Name = "Label17"
        Label17.Size = New Size(106, 24)
        Label17.TabIndex = 1
        Label17.Text = "20歳以上"
        Label17.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Teal
        Label18.FlatStyle = FlatStyle.System
        Label18.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label18.Location = New Point(311, 185)
        Label18.Name = "Label18"
        Label18.Size = New Size(118, 24)
        Label18.TabIndex = 1
        Label18.Text = "7歳～15歳"
        Label18.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' age_6
        ' 
        age_6.BorderStyle = BorderStyle.FixedSingle
        age_6.Font = New Font("ＭＳ ゴシック", 18.5F)
        age_6.Location = New Point(631, 183)
        age_6.Name = "age_6"
        age_6.Size = New Size(64, 32)
        age_6.TabIndex = 2
        age_6.Text = "0"
        age_6.TextAlign = HorizontalAlignment.Center
        ' 
        ' age_18to19
        ' 
        age_18to19.BorderStyle = BorderStyle.FixedSingle
        age_18to19.Font = New Font("ＭＳ ゴシック", 18.5F)
        age_18to19.Location = New Point(631, 148)
        age_18to19.Name = "age_18to19"
        age_18to19.Size = New Size(64, 32)
        age_18to19.TabIndex = 2
        age_18to19.Text = "0"
        age_18to19.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Teal
        Label19.FlatStyle = FlatStyle.System
        Label19.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label19.Location = New Point(497, 151)
        Label19.Name = "Label19"
        Label19.Size = New Size(130, 24)
        Label19.TabIndex = 1
        Label19.Text = "18歳～19歳"
        Label19.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Teal
        Label20.FlatStyle = FlatStyle.System
        Label20.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label20.Location = New Point(533, 185)
        Label20.Name = "Label20"
        Label20.Size = New Size(94, 24)
        Label20.TabIndex = 1
        Label20.Text = "6歳以下"
        Label20.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' high_school
        ' 
        high_school.AutoSize = True
        high_school.BackColor = Color.Teal
        high_school.FlatAppearance.BorderColor = Color.White
        high_school.FlatAppearance.CheckedBackColor = Color.White
        high_school.FlatAppearance.MouseDownBackColor = Color.White
        high_school.FlatAppearance.MouseOverBackColor = Color.White
        high_school.FlatStyle = FlatStyle.System
        high_school.Font = New Font("ＭＳ ゴシック", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        high_school.Location = New Point(514, 123)
        high_school.Name = "high_school"
        high_school.Size = New Size(173, 26)
        high_school.TabIndex = 4
        high_school.Text = "高校生がいる"
        high_school.UseVisualStyleBackColor = False
        ' 
        ' add_register_button
        ' 
        add_register_button.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        add_register_button.FlatAppearance.BorderColor = Color.White
        add_register_button.FlatAppearance.BorderSize = 2
        add_register_button.FlatStyle = FlatStyle.Flat
        add_register_button.Font = New Font("ＭＳ ゴシック", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        add_register_button.Location = New Point(6, 15)
        add_register_button.Name = "add_register_button"
        add_register_button.Size = New Size(115, 32)
        add_register_button.TabIndex = 0
        add_register_button.Text = "切替登録"
        add_register_button.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(add_register_button)
        GroupBox1.Location = New Point(456, 212)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(556, 174)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        ' 
        ' key_button_0
        ' 
        key_button_0.BackColor = Color.White
        key_button_0.FlatAppearance.BorderColor = Color.Gray
        key_button_0.FlatStyle = FlatStyle.Flat
        key_button_0.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_0.Location = New Point(3, 207)
        key_button_0.Name = "key_button_0"
        key_button_0.Size = New Size(79, 65)
        key_button_0.TabIndex = 7
        key_button_0.Text = "0"
        key_button_0.UseVisualStyleBackColor = False
        ' 
        ' key_panel
        ' 
        key_panel.BackColor = SystemColors.Control
        key_panel.Controls.Add(key_button_3)
        key_panel.Controls.Add(key_button_6)
        key_panel.Controls.Add(key_button_2)
        key_panel.Controls.Add(key_button_5)
        key_panel.Controls.Add(key_button_9)
        key_panel.Controls.Add(key_button_1)
        key_panel.Controls.Add(key_button_8)
        key_panel.Controls.Add(key_button_4)
        key_panel.Controls.Add(key_button_c)
        key_panel.Controls.Add(key_button_7)
        key_panel.Controls.Add(Button5)
        key_panel.Controls.Add(key_button_0)
        key_panel.Location = New Point(633, 480)
        key_panel.Name = "key_panel"
        key_panel.Size = New Size(250, 276)
        key_panel.TabIndex = 8
        ' 
        ' key_button_3
        ' 
        key_button_3.BackColor = Color.White
        key_button_3.FlatAppearance.BorderColor = Color.Gray
        key_button_3.FlatStyle = FlatStyle.Flat
        key_button_3.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_3.Location = New Point(167, 3)
        key_button_3.Name = "key_button_3"
        key_button_3.Size = New Size(79, 65)
        key_button_3.TabIndex = 7
        key_button_3.Text = "3"
        key_button_3.UseVisualStyleBackColor = False
        ' 
        ' key_button_6
        ' 
        key_button_6.BackColor = Color.White
        key_button_6.FlatAppearance.BorderColor = Color.Gray
        key_button_6.FlatStyle = FlatStyle.Flat
        key_button_6.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_6.Location = New Point(167, 71)
        key_button_6.Name = "key_button_6"
        key_button_6.Size = New Size(79, 65)
        key_button_6.TabIndex = 7
        key_button_6.Text = "6"
        key_button_6.UseVisualStyleBackColor = False
        ' 
        ' key_button_2
        ' 
        key_button_2.BackColor = Color.White
        key_button_2.FlatAppearance.BorderColor = Color.Gray
        key_button_2.FlatStyle = FlatStyle.Flat
        key_button_2.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_2.Location = New Point(85, 3)
        key_button_2.Name = "key_button_2"
        key_button_2.Size = New Size(79, 65)
        key_button_2.TabIndex = 7
        key_button_2.Text = "2"
        key_button_2.UseVisualStyleBackColor = False
        ' 
        ' key_button_5
        ' 
        key_button_5.BackColor = Color.White
        key_button_5.FlatAppearance.BorderColor = Color.Gray
        key_button_5.FlatStyle = FlatStyle.Flat
        key_button_5.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_5.Location = New Point(85, 71)
        key_button_5.Name = "key_button_5"
        key_button_5.Size = New Size(79, 65)
        key_button_5.TabIndex = 7
        key_button_5.Text = "5"
        key_button_5.UseVisualStyleBackColor = False
        ' 
        ' key_button_9
        ' 
        key_button_9.BackColor = Color.White
        key_button_9.FlatAppearance.BorderColor = Color.Gray
        key_button_9.FlatStyle = FlatStyle.Flat
        key_button_9.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_9.Location = New Point(167, 139)
        key_button_9.Name = "key_button_9"
        key_button_9.Size = New Size(79, 65)
        key_button_9.TabIndex = 7
        key_button_9.Text = "9"
        key_button_9.UseVisualStyleBackColor = False
        ' 
        ' key_button_1
        ' 
        key_button_1.BackColor = Color.White
        key_button_1.FlatAppearance.BorderColor = Color.Gray
        key_button_1.FlatStyle = FlatStyle.Flat
        key_button_1.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_1.Location = New Point(3, 3)
        key_button_1.Name = "key_button_1"
        key_button_1.Size = New Size(79, 65)
        key_button_1.TabIndex = 7
        key_button_1.Text = "1"
        key_button_1.UseVisualStyleBackColor = False
        ' 
        ' key_button_8
        ' 
        key_button_8.BackColor = Color.White
        key_button_8.FlatAppearance.BorderColor = Color.Gray
        key_button_8.FlatStyle = FlatStyle.Flat
        key_button_8.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_8.Location = New Point(85, 139)
        key_button_8.Name = "key_button_8"
        key_button_8.Size = New Size(79, 65)
        key_button_8.TabIndex = 7
        key_button_8.Text = "8"
        key_button_8.UseVisualStyleBackColor = False
        ' 
        ' key_button_4
        ' 
        key_button_4.BackColor = Color.White
        key_button_4.FlatAppearance.BorderColor = Color.Gray
        key_button_4.FlatStyle = FlatStyle.Flat
        key_button_4.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_4.Location = New Point(3, 71)
        key_button_4.Name = "key_button_4"
        key_button_4.Size = New Size(79, 65)
        key_button_4.TabIndex = 7
        key_button_4.Text = "4"
        key_button_4.UseVisualStyleBackColor = False
        ' 
        ' key_button_c
        ' 
        key_button_c.BackColor = Color.White
        key_button_c.FlatAppearance.BorderColor = Color.Gray
        key_button_c.FlatStyle = FlatStyle.Flat
        key_button_c.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_c.Location = New Point(167, 207)
        key_button_c.Name = "key_button_c"
        key_button_c.Size = New Size(79, 65)
        key_button_c.TabIndex = 7
        key_button_c.Text = "C"
        key_button_c.UseVisualStyleBackColor = False
        ' 
        ' key_button_7
        ' 
        key_button_7.BackColor = Color.White
        key_button_7.FlatAppearance.BorderColor = Color.Gray
        key_button_7.FlatStyle = FlatStyle.Flat
        key_button_7.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        key_button_7.Location = New Point(3, 139)
        key_button_7.Name = "key_button_7"
        key_button_7.Size = New Size(79, 65)
        key_button_7.TabIndex = 7
        key_button_7.Text = "7"
        key_button_7.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.White
        Button5.Enabled = False
        Button5.FlatAppearance.BorderColor = Color.Gray
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button5.Location = New Point(85, 207)
        Button5.Name = "Button5"
        Button5.Size = New Size(79, 65)
        Button5.TabIndex = 7
        Button5.UseVisualStyleBackColor = False
        ' 
        ' EnterRoomForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1024, 768)
        Controls.Add(key_panel)
        Controls.Add(high_school)
        Controls.Add(service_combo)
        Controls.Add(option_combo)
        Controls.Add(roomtype_combo)
        Controls.Add(machine_combo)
        Controls.Add(maker_combo)
        Controls.Add(course_combo)
        Controls.Add(member_rank)
        Controls.Add(Label20)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(Label17)
        Controls.Add(Label14)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label11)
        Controls.Add(Label8)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(age_18to19)
        Controls.Add(Label3)
        Controls.Add(age_6)
        Controls.Add(age_20)
        Controls.Add(age_7to15)
        Controls.Add(member_category)
        Controls.Add(member_code)
        Controls.Add(price_4)
        Controls.Add(price_3)
        Controls.Add(price_2)
        Controls.Add(price_1)
        Controls.Add(additional_ability)
        Controls.Add(use_time)
        Controls.Add(exit_time)
        Controls.Add(Label2)
        Controls.Add(room_no)
        Controls.Add(entry_time)
        Controls.Add(Label1)
        Controls.Add(description_button)
        Controls.Add(enter_count_button)
        Controls.Add(register_button)
        Controls.Add(back_button)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "EnterRoomForm"
        StartPosition = FormStartPosition.Manual
        Text = "EnterRoomForm"
        TopMost = True
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        key_panel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents back_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents entry_time As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents member_code As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents member_rank As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents register_button As Button
    Friend WithEvents exit_time As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents course_combo As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents room_no As TextBox
    Friend WithEvents description_button As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents use_time As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents additional_ability As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents maker_combo As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents roomtype_combo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents service_combo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents price_1 As TextBox
    Friend WithEvents price_2 As TextBox
    Friend WithEvents price_3 As TextBox
    Friend WithEvents price_4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents machine_combo As ComboBox
    Friend WithEvents option_combo As ComboBox
    Friend WithEvents member_category As TextBox
    Friend WithEvents enter_count_button As Button
    Friend WithEvents age_7to15 As TextBox
    Friend WithEvents age_20 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents age_6 As TextBox
    Friend WithEvents age_18to19 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents high_school As CheckBox
    Friend WithEvents add_register_button As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents key_button_0 As Button
    Friend WithEvents key_panel As Panel
    Friend WithEvents key_button_9 As Button
    Friend WithEvents key_button_8 As Button
    Friend WithEvents key_button_c As Button
    Friend WithEvents key_button_7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents key_button_3 As Button
    Friend WithEvents key_button_6 As Button
    Friend WithEvents key_button_2 As Button
    Friend WithEvents key_button_5 As Button
    Friend WithEvents key_button_1 As Button
    Friend WithEvents key_button_4 As Button

End Class
