<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        exit_button = New Button()
        date_time_label = New Label()
        store_no_label = New Label()
        store_name_label = New Label()
        register_no_label = New Label()
        operation_date_label = New Label()
        operation_week_label = New Label()
        room_count_label = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Button13 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Button16 = New Button()
        Button17 = New Button()
        Button18 = New Button()
        Button19 = New Button()
        Button20 = New Button()
        Button21 = New Button()
        Button22 = New Button()
        Button23 = New Button()
        Button24 = New Button()
        Button25 = New Button()
        Button26 = New Button()
        Button27 = New Button()
        Button28 = New Button()
        Button29 = New Button()
        Button30 = New Button()
        Button31 = New Button()
        Button32 = New Button()
        Button33 = New Button()
        Button34 = New Button()
        Button35 = New Button()
        SuspendLayout()
        ' 
        ' exit_button
        ' 
        exit_button.BackColor = Color.White
        exit_button.BackgroundImageLayout = ImageLayout.None
        exit_button.FlatStyle = FlatStyle.Popup
        exit_button.Location = New Point(930, 718)
        exit_button.Margin = New Padding(1)
        exit_button.Name = "exit_button"
        exit_button.Size = New Size(83, 40)
        exit_button.TabIndex = 0
        exit_button.Text = "終了"
        exit_button.UseVisualStyleBackColor = False
        ' 
        ' date_time_label
        ' 
        date_time_label.AutoSize = True
        date_time_label.Font = New Font("ＭＳ ゴシック", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(128))
        date_time_label.ForeColor = Color.White
        date_time_label.Location = New Point(11, 9)
        date_time_label.Margin = New Padding(2, 0, 2, 0)
        date_time_label.Name = "date_time_label"
        date_time_label.Size = New Size(300, 19)
        date_time_label.TabIndex = 2
        date_time_label.Text = "0000年00月00日 00時00分00秒"
        ' 
        ' store_no_label
        ' 
        store_no_label.AutoSize = True
        store_no_label.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        store_no_label.ForeColor = Color.Yellow
        store_no_label.Location = New Point(325, 11)
        store_no_label.Margin = New Padding(2, 0, 2, 0)
        store_no_label.Name = "store_no_label"
        store_no_label.Size = New Size(43, 16)
        store_no_label.TabIndex = 2
        store_no_label.Text = "0000"
        ' 
        ' store_name_label
        ' 
        store_name_label.AutoSize = True
        store_name_label.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        store_name_label.ForeColor = Color.Yellow
        store_name_label.Location = New Point(382, 11)
        store_name_label.Margin = New Padding(2, 0, 2, 0)
        store_name_label.Name = "store_name_label"
        store_name_label.Size = New Size(245, 16)
        store_name_label.TabIndex = 2
        store_name_label.Text = "カラオケまねきねこ河原町本店"
        ' 
        ' register_no_label
        ' 
        register_no_label.AutoSize = True
        register_no_label.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        register_no_label.ForeColor = Color.Yellow
        register_no_label.Location = New Point(722, 12)
        register_no_label.Margin = New Padding(2, 0, 2, 0)
        register_no_label.Name = "register_no_label"
        register_no_label.Size = New Size(25, 16)
        register_no_label.TabIndex = 2
        register_no_label.Text = "00"
        ' 
        ' operation_date_label
        ' 
        operation_date_label.AutoSize = True
        operation_date_label.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold Or FontStyle.Underline)
        operation_date_label.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        operation_date_label.Location = New Point(11, 38)
        operation_date_label.Margin = New Padding(2, 0, 2, 0)
        operation_date_label.Name = "operation_date_label"
        operation_date_label.Size = New Size(191, 16)
        operation_date_label.TabIndex = 2
        operation_date_label.Text = "営業設定日:0000/00/00"
        ' 
        ' operation_week_label
        ' 
        operation_week_label.AutoSize = True
        operation_week_label.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold Or FontStyle.Underline)
        operation_week_label.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        operation_week_label.Location = New Point(206, 38)
        operation_week_label.Margin = New Padding(2, 0, 2, 0)
        operation_week_label.Name = "operation_week_label"
        operation_week_label.Size = New Size(135, 16)
        operation_week_label.TabIndex = 2
        operation_week_label.Text = "曜日区分:＊～＊"
        ' 
        ' room_count_label
        ' 
        room_count_label.AutoSize = True
        room_count_label.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_count_label.ForeColor = Color.White
        room_count_label.Location = New Point(875, 12)
        room_count_label.Margin = New Padding(2, 0, 2, 0)
        room_count_label.Name = "room_count_label"
        room_count_label.Size = New Size(138, 16)
        room_count_label.TabIndex = 2
        room_count_label.Text = "稼働中:00 未:00"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button1.Location = New Point(11, 57)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 90)
        Button1.TabIndex = 3
        Button1.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button1.TextAlign = ContentAlignment.TopLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gray
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button2.Location = New Point(211, 57)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 90)
        Button2.TabIndex = 3
        Button2.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button2.TextAlign = ContentAlignment.TopLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gray
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button3.Location = New Point(411, 57)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.Size = New Size(200, 90)
        Button3.TabIndex = 3
        Button3.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button3.TextAlign = ContentAlignment.TopLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gray
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button4.Location = New Point(611, 57)
        Button4.Margin = New Padding(0)
        Button4.Name = "Button4"
        Button4.Size = New Size(200, 90)
        Button4.TabIndex = 3
        Button4.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button4.TextAlign = ContentAlignment.TopLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Gray
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button5.Location = New Point(811, 57)
        Button5.Margin = New Padding(0)
        Button5.Name = "Button5"
        Button5.Size = New Size(200, 90)
        Button5.TabIndex = 3
        Button5.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button5.TextAlign = ContentAlignment.TopLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Gray
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button6.Location = New Point(11, 147)
        Button6.Margin = New Padding(0)
        Button6.Name = "Button6"
        Button6.Size = New Size(200, 90)
        Button6.TabIndex = 3
        Button6.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button6.TextAlign = ContentAlignment.TopLeft
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Gray
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button7.Location = New Point(411, 147)
        Button7.Margin = New Padding(0)
        Button7.Name = "Button7"
        Button7.Size = New Size(200, 90)
        Button7.TabIndex = 3
        Button7.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button7.TextAlign = ContentAlignment.TopLeft
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Gray
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button8.Location = New Point(211, 147)
        Button8.Margin = New Padding(0)
        Button8.Name = "Button8"
        Button8.Size = New Size(200, 90)
        Button8.TabIndex = 3
        Button8.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button8.TextAlign = ContentAlignment.TopLeft
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Gray
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button9.Location = New Point(611, 147)
        Button9.Margin = New Padding(0)
        Button9.Name = "Button9"
        Button9.Size = New Size(200, 90)
        Button9.TabIndex = 3
        Button9.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button9.TextAlign = ContentAlignment.TopLeft
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Gray
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button10.Location = New Point(811, 147)
        Button10.Margin = New Padding(0)
        Button10.Name = "Button10"
        Button10.Size = New Size(200, 90)
        Button10.TabIndex = 3
        Button10.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button10.TextAlign = ContentAlignment.TopLeft
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.Gray
        Button11.FlatStyle = FlatStyle.Flat
        Button11.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button11.Location = New Point(11, 237)
        Button11.Margin = New Padding(0)
        Button11.Name = "Button11"
        Button11.Size = New Size(200, 90)
        Button11.TabIndex = 3
        Button11.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button11.TextAlign = ContentAlignment.TopLeft
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.Gray
        Button12.FlatStyle = FlatStyle.Flat
        Button12.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button12.Location = New Point(411, 237)
        Button12.Margin = New Padding(0)
        Button12.Name = "Button12"
        Button12.Size = New Size(200, 90)
        Button12.TabIndex = 3
        Button12.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button12.TextAlign = ContentAlignment.TopLeft
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.Gray
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button13.Location = New Point(211, 237)
        Button13.Margin = New Padding(0)
        Button13.Name = "Button13"
        Button13.Size = New Size(200, 90)
        Button13.TabIndex = 3
        Button13.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button13.TextAlign = ContentAlignment.TopLeft
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.BackColor = Color.Gray
        Button14.FlatStyle = FlatStyle.Flat
        Button14.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button14.Location = New Point(611, 237)
        Button14.Margin = New Padding(0)
        Button14.Name = "Button14"
        Button14.Size = New Size(200, 90)
        Button14.TabIndex = 3
        Button14.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button14.TextAlign = ContentAlignment.TopLeft
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.Gray
        Button15.FlatStyle = FlatStyle.Flat
        Button15.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button15.Location = New Point(811, 237)
        Button15.Margin = New Padding(0)
        Button15.Name = "Button15"
        Button15.Size = New Size(200, 90)
        Button15.TabIndex = 3
        Button15.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button15.TextAlign = ContentAlignment.TopLeft
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Button16
        ' 
        Button16.BackColor = Color.Gray
        Button16.FlatStyle = FlatStyle.Flat
        Button16.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button16.Location = New Point(11, 327)
        Button16.Margin = New Padding(0)
        Button16.Name = "Button16"
        Button16.Size = New Size(200, 90)
        Button16.TabIndex = 3
        Button16.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button16.TextAlign = ContentAlignment.TopLeft
        Button16.UseVisualStyleBackColor = False
        ' 
        ' Button17
        ' 
        Button17.BackColor = Color.Gray
        Button17.FlatStyle = FlatStyle.Flat
        Button17.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button17.Location = New Point(411, 327)
        Button17.Margin = New Padding(0)
        Button17.Name = "Button17"
        Button17.Size = New Size(200, 90)
        Button17.TabIndex = 3
        Button17.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button17.TextAlign = ContentAlignment.TopLeft
        Button17.UseVisualStyleBackColor = False
        ' 
        ' Button18
        ' 
        Button18.BackColor = Color.Gray
        Button18.FlatStyle = FlatStyle.Flat
        Button18.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button18.Location = New Point(211, 327)
        Button18.Margin = New Padding(0)
        Button18.Name = "Button18"
        Button18.Size = New Size(200, 90)
        Button18.TabIndex = 3
        Button18.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button18.TextAlign = ContentAlignment.TopLeft
        Button18.UseVisualStyleBackColor = False
        ' 
        ' Button19
        ' 
        Button19.BackColor = Color.Gray
        Button19.FlatStyle = FlatStyle.Flat
        Button19.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button19.Location = New Point(611, 327)
        Button19.Margin = New Padding(0)
        Button19.Name = "Button19"
        Button19.Size = New Size(200, 90)
        Button19.TabIndex = 3
        Button19.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button19.TextAlign = ContentAlignment.TopLeft
        Button19.UseVisualStyleBackColor = False
        ' 
        ' Button20
        ' 
        Button20.BackColor = Color.Gray
        Button20.FlatStyle = FlatStyle.Flat
        Button20.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button20.Location = New Point(811, 327)
        Button20.Margin = New Padding(0)
        Button20.Name = "Button20"
        Button20.Size = New Size(200, 90)
        Button20.TabIndex = 3
        Button20.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button20.TextAlign = ContentAlignment.TopLeft
        Button20.UseVisualStyleBackColor = False
        ' 
        ' Button21
        ' 
        Button21.BackColor = Color.Gray
        Button21.FlatStyle = FlatStyle.Flat
        Button21.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button21.Location = New Point(11, 417)
        Button21.Margin = New Padding(0)
        Button21.Name = "Button21"
        Button21.Size = New Size(200, 90)
        Button21.TabIndex = 3
        Button21.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button21.TextAlign = ContentAlignment.TopLeft
        Button21.UseVisualStyleBackColor = False
        ' 
        ' Button22
        ' 
        Button22.BackColor = Color.Gray
        Button22.FlatStyle = FlatStyle.Flat
        Button22.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button22.Location = New Point(411, 417)
        Button22.Margin = New Padding(0)
        Button22.Name = "Button22"
        Button22.Size = New Size(200, 90)
        Button22.TabIndex = 3
        Button22.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button22.TextAlign = ContentAlignment.TopLeft
        Button22.UseVisualStyleBackColor = False
        ' 
        ' Button23
        ' 
        Button23.BackColor = Color.Gray
        Button23.FlatStyle = FlatStyle.Flat
        Button23.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button23.Location = New Point(211, 417)
        Button23.Margin = New Padding(0)
        Button23.Name = "Button23"
        Button23.Size = New Size(200, 90)
        Button23.TabIndex = 3
        Button23.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button23.TextAlign = ContentAlignment.TopLeft
        Button23.UseVisualStyleBackColor = False
        ' 
        ' Button24
        ' 
        Button24.BackColor = Color.Gray
        Button24.FlatStyle = FlatStyle.Flat
        Button24.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button24.Location = New Point(611, 417)
        Button24.Margin = New Padding(0)
        Button24.Name = "Button24"
        Button24.Size = New Size(200, 90)
        Button24.TabIndex = 3
        Button24.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button24.TextAlign = ContentAlignment.TopLeft
        Button24.UseVisualStyleBackColor = False
        ' 
        ' Button25
        ' 
        Button25.BackColor = Color.Gray
        Button25.FlatStyle = FlatStyle.Flat
        Button25.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button25.Location = New Point(811, 417)
        Button25.Margin = New Padding(0)
        Button25.Name = "Button25"
        Button25.Size = New Size(200, 90)
        Button25.TabIndex = 3
        Button25.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button25.TextAlign = ContentAlignment.TopLeft
        Button25.UseVisualStyleBackColor = False
        ' 
        ' Button26
        ' 
        Button26.BackColor = Color.Gray
        Button26.FlatStyle = FlatStyle.Flat
        Button26.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button26.Location = New Point(11, 507)
        Button26.Margin = New Padding(0)
        Button26.Name = "Button26"
        Button26.Size = New Size(200, 90)
        Button26.TabIndex = 3
        Button26.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button26.TextAlign = ContentAlignment.TopLeft
        Button26.UseVisualStyleBackColor = False
        ' 
        ' Button27
        ' 
        Button27.BackColor = Color.Gray
        Button27.FlatStyle = FlatStyle.Flat
        Button27.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button27.Location = New Point(411, 507)
        Button27.Margin = New Padding(0)
        Button27.Name = "Button27"
        Button27.Size = New Size(200, 90)
        Button27.TabIndex = 3
        Button27.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button27.TextAlign = ContentAlignment.TopLeft
        Button27.UseVisualStyleBackColor = False
        ' 
        ' Button28
        ' 
        Button28.BackColor = Color.Gray
        Button28.FlatStyle = FlatStyle.Flat
        Button28.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button28.Location = New Point(211, 507)
        Button28.Margin = New Padding(0)
        Button28.Name = "Button28"
        Button28.Size = New Size(200, 90)
        Button28.TabIndex = 3
        Button28.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button28.TextAlign = ContentAlignment.TopLeft
        Button28.UseVisualStyleBackColor = False
        ' 
        ' Button29
        ' 
        Button29.BackColor = Color.Gray
        Button29.FlatStyle = FlatStyle.Flat
        Button29.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button29.Location = New Point(611, 507)
        Button29.Margin = New Padding(0)
        Button29.Name = "Button29"
        Button29.Size = New Size(200, 90)
        Button29.TabIndex = 3
        Button29.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button29.TextAlign = ContentAlignment.TopLeft
        Button29.UseVisualStyleBackColor = False
        ' 
        ' Button30
        ' 
        Button30.BackColor = Color.Gray
        Button30.FlatStyle = FlatStyle.Flat
        Button30.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button30.Location = New Point(811, 507)
        Button30.Margin = New Padding(0)
        Button30.Name = "Button30"
        Button30.Size = New Size(200, 90)
        Button30.TabIndex = 3
        Button30.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button30.TextAlign = ContentAlignment.TopLeft
        Button30.UseVisualStyleBackColor = False
        ' 
        ' Button31
        ' 
        Button31.BackColor = Color.Gray
        Button31.FlatStyle = FlatStyle.Flat
        Button31.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button31.Location = New Point(11, 597)
        Button31.Margin = New Padding(0)
        Button31.Name = "Button31"
        Button31.Size = New Size(200, 90)
        Button31.TabIndex = 3
        Button31.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button31.TextAlign = ContentAlignment.TopLeft
        Button31.UseVisualStyleBackColor = False
        ' 
        ' Button32
        ' 
        Button32.BackColor = Color.Gray
        Button32.FlatStyle = FlatStyle.Flat
        Button32.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button32.Location = New Point(411, 597)
        Button32.Margin = New Padding(0)
        Button32.Name = "Button32"
        Button32.Size = New Size(200, 90)
        Button32.TabIndex = 3
        Button32.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button32.TextAlign = ContentAlignment.TopLeft
        Button32.UseVisualStyleBackColor = False
        ' 
        ' Button33
        ' 
        Button33.BackColor = Color.Gray
        Button33.FlatStyle = FlatStyle.Flat
        Button33.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button33.Location = New Point(211, 597)
        Button33.Margin = New Padding(0)
        Button33.Name = "Button33"
        Button33.Size = New Size(200, 90)
        Button33.TabIndex = 3
        Button33.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button33.TextAlign = ContentAlignment.TopLeft
        Button33.UseVisualStyleBackColor = False
        ' 
        ' Button34
        ' 
        Button34.BackColor = Color.Gray
        Button34.FlatStyle = FlatStyle.Flat
        Button34.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button34.Location = New Point(611, 597)
        Button34.Margin = New Padding(0)
        Button34.Name = "Button34"
        Button34.Size = New Size(200, 90)
        Button34.TabIndex = 3
        Button34.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button34.TextAlign = ContentAlignment.TopLeft
        Button34.UseVisualStyleBackColor = False
        ' 
        ' Button35
        ' 
        Button35.BackColor = Color.Gray
        Button35.FlatStyle = FlatStyle.Flat
        Button35.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button35.Location = New Point(811, 597)
        Button35.Margin = New Padding(0)
        Button35.Name = "Button35"
        Button35.Size = New Size(200, 90)
        Button35.TabIndex = 3
        Button35.Text = "00 ＊＊＊　＊＊" & vbCrLf & " 00:00～00:00　000分" & vbCrLf & "  0人( 00- 00)" & vbCrLf & " ＊"
        Button35.TextAlign = ContentAlignment.TopLeft
        Button35.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1024, 768)
        Controls.Add(Button35)
        Controls.Add(Button34)
        Controls.Add(Button30)
        Controls.Add(Button29)
        Controls.Add(Button25)
        Controls.Add(Button24)
        Controls.Add(Button20)
        Controls.Add(Button19)
        Controls.Add(Button33)
        Controls.Add(Button15)
        Controls.Add(Button28)
        Controls.Add(Button14)
        Controls.Add(Button23)
        Controls.Add(Button10)
        Controls.Add(Button18)
        Controls.Add(Button32)
        Controls.Add(Button9)
        Controls.Add(Button27)
        Controls.Add(Button13)
        Controls.Add(Button22)
        Controls.Add(Button5)
        Controls.Add(Button17)
        Controls.Add(Button31)
        Controls.Add(Button8)
        Controls.Add(Button26)
        Controls.Add(Button12)
        Controls.Add(Button21)
        Controls.Add(Button4)
        Controls.Add(Button16)
        Controls.Add(Button7)
        Controls.Add(Button11)
        Controls.Add(Button2)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(operation_week_label)
        Controls.Add(operation_date_label)
        Controls.Add(room_count_label)
        Controls.Add(register_no_label)
        Controls.Add(store_name_label)
        Controls.Add(store_no_label)
        Controls.Add(date_time_label)
        Controls.Add(exit_button)
        FormBorderStyle = FormBorderStyle.None
        KeyPreview = True
        Margin = New Padding(1)
        Name = "Form1"
        Text = "Form1"
        TopMost = True
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents exit_button As Button
    Friend WithEvents date_time_label As Label
    Friend WithEvents store_no_label As Label
    Friend WithEvents store_name_label As Label
    Friend WithEvents register_no_label As Label
    Friend WithEvents operation_date_label As Label
    Friend WithEvents operation_week_label As Label
    Friend WithEvents room_count_label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button32 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents Button35 As Button

End Class
