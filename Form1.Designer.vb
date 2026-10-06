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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        exit_button = New Button()
        date_time_label = New Label()
        store_no_label = New Label()
        store_name_label = New Label()
        register_no_label = New Label()
        operation_date_label = New Label()
        operation_week_label = New Label()
        room_count_label = New Label()
        Button1 = New MultiLineButton()
        Button2 = New MultiLineButton()
        Button3 = New MultiLineButton()
        Button4 = New MultiLineButton()
        Button5 = New MultiLineButton()
        Button6 = New MultiLineButton()
        Button7 = New MultiLineButton()
        Button8 = New MultiLineButton()
        Button9 = New MultiLineButton()
        Button10 = New MultiLineButton()
        Button11 = New MultiLineButton()
        Button12 = New MultiLineButton()
        Button13 = New MultiLineButton()
        Button14 = New MultiLineButton()
        Button15 = New MultiLineButton()
        Button16 = New MultiLineButton()
        Button17 = New MultiLineButton()
        Button18 = New MultiLineButton()
        Button19 = New MultiLineButton()
        Button20 = New MultiLineButton()
        Button21 = New MultiLineButton()
        Button22 = New MultiLineButton()
        Button23 = New MultiLineButton()
        Button24 = New MultiLineButton()
        Button25 = New MultiLineButton()
        Button26 = New MultiLineButton()
        Button27 = New MultiLineButton()
        Button28 = New MultiLineButton()
        Button29 = New MultiLineButton()
        Button30 = New MultiLineButton()
        Button31 = New MultiLineButton()
        Button32 = New MultiLineButton()
        Button33 = New MultiLineButton()
        Button34 = New MultiLineButton()
        Button35 = New MultiLineButton()
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
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(11, 57)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 90)
        Button1.TabIndex = 3
        Button1.TextAlignment = StringAlignment.Near
        Button1.UseVisualStyleBackColor = False
        Button1.VerticalPadding = 6F
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(211, 57)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 90)
        Button2.TabIndex = 3
        Button2.TextAlignment = StringAlignment.Near
        Button2.UseVisualStyleBackColor = False
        Button2.VerticalPadding = 6F
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(411, 57)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.Size = New Size(200, 90)
        Button3.TabIndex = 3
        Button3.TextAlignment = StringAlignment.Near
        Button3.UseVisualStyleBackColor = False
        Button3.VerticalPadding = 6F
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(611, 57)
        Button4.Margin = New Padding(0)
        Button4.Name = "Button4"
        Button4.Size = New Size(200, 90)
        Button4.TabIndex = 3
        Button4.TextAlignment = StringAlignment.Near
        Button4.UseVisualStyleBackColor = False
        Button4.VerticalPadding = 6F
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(811, 57)
        Button5.Margin = New Padding(0)
        Button5.Name = "Button5"
        Button5.Size = New Size(200, 90)
        Button5.TabIndex = 3
        Button5.TextAlignment = StringAlignment.Near
        Button5.UseVisualStyleBackColor = False
        Button5.VerticalPadding = 6F
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(11, 147)
        Button6.Margin = New Padding(0)
        Button6.Name = "Button6"
        Button6.Size = New Size(200, 90)
        Button6.TabIndex = 3
        Button6.TextAlignment = StringAlignment.Near
        Button6.UseVisualStyleBackColor = False
        Button6.VerticalPadding = 6F
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(411, 147)
        Button7.Margin = New Padding(0)
        Button7.Name = "Button7"
        Button7.Size = New Size(200, 90)
        Button7.TabIndex = 3
        Button7.TextAlignment = StringAlignment.Near
        Button7.UseVisualStyleBackColor = False
        Button7.VerticalPadding = 6F
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(211, 147)
        Button8.Margin = New Padding(0)
        Button8.Name = "Button8"
        Button8.Size = New Size(200, 90)
        Button8.TabIndex = 3
        Button8.TextAlignment = StringAlignment.Near
        Button8.UseVisualStyleBackColor = False
        Button8.VerticalPadding = 6F
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Location = New Point(611, 147)
        Button9.Margin = New Padding(0)
        Button9.Name = "Button9"
        Button9.Size = New Size(200, 90)
        Button9.TabIndex = 3
        Button9.TextAlignment = StringAlignment.Near
        Button9.UseVisualStyleBackColor = False
        Button9.VerticalPadding = 6F
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Location = New Point(811, 147)
        Button10.Margin = New Padding(0)
        Button10.Name = "Button10"
        Button10.Size = New Size(200, 90)
        Button10.TabIndex = 3
        Button10.TextAlignment = StringAlignment.Near
        Button10.UseVisualStyleBackColor = False
        Button10.VerticalPadding = 6F
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button11.FlatStyle = FlatStyle.Flat
        Button11.Location = New Point(11, 237)
        Button11.Margin = New Padding(0)
        Button11.Name = "Button11"
        Button11.Size = New Size(200, 90)
        Button11.TabIndex = 3
        Button11.TextAlignment = StringAlignment.Near
        Button11.UseVisualStyleBackColor = False
        Button11.VerticalPadding = 6F
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button12.FlatStyle = FlatStyle.Flat
        Button12.Location = New Point(411, 237)
        Button12.Margin = New Padding(0)
        Button12.Name = "Button12"
        Button12.Size = New Size(200, 90)
        Button12.TabIndex = 3
        Button12.TextAlignment = StringAlignment.Near
        Button12.UseVisualStyleBackColor = False
        Button12.VerticalPadding = 6F
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Location = New Point(211, 237)
        Button13.Margin = New Padding(0)
        Button13.Name = "Button13"
        Button13.Size = New Size(200, 90)
        Button13.TabIndex = 3
        Button13.TextAlignment = StringAlignment.Near
        Button13.UseVisualStyleBackColor = False
        Button13.VerticalPadding = 6F
        ' 
        ' Button14
        ' 
        Button14.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button14.FlatStyle = FlatStyle.Flat
        Button14.Location = New Point(611, 237)
        Button14.Margin = New Padding(0)
        Button14.Name = "Button14"
        Button14.Size = New Size(200, 90)
        Button14.TabIndex = 3
        Button14.TextAlignment = StringAlignment.Near
        Button14.UseVisualStyleBackColor = False
        Button14.VerticalPadding = 6F
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button15.FlatStyle = FlatStyle.Flat
        Button15.Location = New Point(811, 237)
        Button15.Margin = New Padding(0)
        Button15.Name = "Button15"
        Button15.Size = New Size(200, 90)
        Button15.TabIndex = 3
        Button15.TextAlignment = StringAlignment.Near
        Button15.UseVisualStyleBackColor = False
        Button15.VerticalPadding = 6F
        ' 
        ' Button16
        ' 
        Button16.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button16.FlatStyle = FlatStyle.Flat
        Button16.Location = New Point(11, 327)
        Button16.Margin = New Padding(0)
        Button16.Name = "Button16"
        Button16.Size = New Size(200, 90)
        Button16.TabIndex = 3
        Button16.TextAlignment = StringAlignment.Near
        Button16.UseVisualStyleBackColor = False
        Button16.VerticalPadding = 6F
        ' 
        ' Button17
        ' 
        Button17.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button17.FlatStyle = FlatStyle.Flat
        Button17.Location = New Point(411, 327)
        Button17.Margin = New Padding(0)
        Button17.Name = "Button17"
        Button17.Size = New Size(200, 90)
        Button17.TabIndex = 3
        Button17.TextAlignment = StringAlignment.Near
        Button17.UseVisualStyleBackColor = False
        Button17.VerticalPadding = 6F
        ' 
        ' Button18
        ' 
        Button18.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button18.FlatStyle = FlatStyle.Flat
        Button18.Location = New Point(211, 327)
        Button18.Margin = New Padding(0)
        Button18.Name = "Button18"
        Button18.Size = New Size(200, 90)
        Button18.TabIndex = 3
        Button18.TextAlignment = StringAlignment.Near
        Button18.UseVisualStyleBackColor = False
        Button18.VerticalPadding = 6F
        ' 
        ' Button19
        ' 
        Button19.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button19.FlatStyle = FlatStyle.Flat
        Button19.Location = New Point(611, 327)
        Button19.Margin = New Padding(0)
        Button19.Name = "Button19"
        Button19.Size = New Size(200, 90)
        Button19.TabIndex = 3
        Button19.TextAlignment = StringAlignment.Near
        Button19.UseVisualStyleBackColor = False
        Button19.VerticalPadding = 6F
        ' 
        ' Button20
        ' 
        Button20.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button20.FlatStyle = FlatStyle.Flat
        Button20.Location = New Point(811, 327)
        Button20.Margin = New Padding(0)
        Button20.Name = "Button20"
        Button20.Size = New Size(200, 90)
        Button20.TabIndex = 3
        Button20.TextAlignment = StringAlignment.Near
        Button20.UseVisualStyleBackColor = False
        Button20.VerticalPadding = 6F
        ' 
        ' Button21
        ' 
        Button21.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button21.FlatStyle = FlatStyle.Flat
        Button21.Location = New Point(11, 417)
        Button21.Margin = New Padding(0)
        Button21.Name = "Button21"
        Button21.Size = New Size(200, 90)
        Button21.TabIndex = 3
        Button21.TextAlignment = StringAlignment.Near
        Button21.UseVisualStyleBackColor = False
        Button21.VerticalPadding = 6F
        ' 
        ' Button22
        ' 
        Button22.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button22.FlatStyle = FlatStyle.Flat
        Button22.Location = New Point(411, 417)
        Button22.Margin = New Padding(0)
        Button22.Name = "Button22"
        Button22.Size = New Size(200, 90)
        Button22.TabIndex = 3
        Button22.TextAlignment = StringAlignment.Near
        Button22.UseVisualStyleBackColor = False
        Button22.VerticalPadding = 6F
        ' 
        ' Button23
        ' 
        Button23.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button23.FlatStyle = FlatStyle.Flat
        Button23.Location = New Point(211, 417)
        Button23.Margin = New Padding(0)
        Button23.Name = "Button23"
        Button23.Size = New Size(200, 90)
        Button23.TabIndex = 3
        Button23.TextAlignment = StringAlignment.Near
        Button23.UseVisualStyleBackColor = False
        Button23.VerticalPadding = 6F
        ' 
        ' Button24
        ' 
        Button24.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button24.FlatStyle = FlatStyle.Flat
        Button24.Location = New Point(611, 417)
        Button24.Margin = New Padding(0)
        Button24.Name = "Button24"
        Button24.Size = New Size(200, 90)
        Button24.TabIndex = 3
        Button24.TextAlignment = StringAlignment.Near
        Button24.UseVisualStyleBackColor = False
        Button24.VerticalPadding = 6F
        ' 
        ' Button25
        ' 
        Button25.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button25.FlatStyle = FlatStyle.Flat
        Button25.Location = New Point(811, 417)
        Button25.Margin = New Padding(0)
        Button25.Name = "Button25"
        Button25.Size = New Size(200, 90)
        Button25.TabIndex = 3
        Button25.TextAlignment = StringAlignment.Near
        Button25.UseVisualStyleBackColor = False
        Button25.VerticalPadding = 6F
        ' 
        ' Button26
        ' 
        Button26.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button26.FlatStyle = FlatStyle.Flat
        Button26.Location = New Point(11, 507)
        Button26.Margin = New Padding(0)
        Button26.Name = "Button26"
        Button26.Size = New Size(200, 90)
        Button26.TabIndex = 3
        Button26.TextAlignment = StringAlignment.Near
        Button26.UseVisualStyleBackColor = False
        Button26.VerticalPadding = 6F
        ' 
        ' Button27
        ' 
        Button27.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button27.FlatStyle = FlatStyle.Flat
        Button27.Location = New Point(411, 507)
        Button27.Margin = New Padding(0)
        Button27.Name = "Button27"
        Button27.Size = New Size(200, 90)
        Button27.TabIndex = 3
        Button27.TextAlignment = StringAlignment.Near
        Button27.UseVisualStyleBackColor = False
        Button27.VerticalPadding = 6F
        ' 
        ' Button28
        ' 
        Button28.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button28.FlatStyle = FlatStyle.Flat
        Button28.Location = New Point(211, 507)
        Button28.Margin = New Padding(0)
        Button28.Name = "Button28"
        Button28.Size = New Size(200, 90)
        Button28.TabIndex = 3
        Button28.TextAlignment = StringAlignment.Near
        Button28.UseVisualStyleBackColor = False
        Button28.VerticalPadding = 6F
        ' 
        ' Button29
        ' 
        Button29.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button29.FlatStyle = FlatStyle.Flat
        Button29.Location = New Point(611, 507)
        Button29.Margin = New Padding(0)
        Button29.Name = "Button29"
        Button29.Size = New Size(200, 90)
        Button29.TabIndex = 3
        Button29.TextAlignment = StringAlignment.Near
        Button29.UseVisualStyleBackColor = False
        Button29.VerticalPadding = 6F
        ' 
        ' Button30
        ' 
        Button30.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button30.FlatStyle = FlatStyle.Flat
        Button30.Location = New Point(811, 507)
        Button30.Margin = New Padding(0)
        Button30.Name = "Button30"
        Button30.Size = New Size(200, 90)
        Button30.TabIndex = 3
        Button30.TextAlignment = StringAlignment.Near
        Button30.UseVisualStyleBackColor = False
        Button30.VerticalPadding = 6F
        ' 
        ' Button31
        ' 
        Button31.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button31.FlatStyle = FlatStyle.Flat
        Button31.Location = New Point(11, 597)
        Button31.Margin = New Padding(0)
        Button31.Name = "Button31"
        Button31.Size = New Size(200, 90)
        Button31.TabIndex = 3
        Button31.TextAlignment = StringAlignment.Near
        Button31.UseVisualStyleBackColor = False
        Button31.VerticalPadding = 6F
        ' 
        ' Button32
        ' 
        Button32.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button32.FlatStyle = FlatStyle.Flat
        Button32.Location = New Point(411, 597)
        Button32.Margin = New Padding(0)
        Button32.Name = "Button32"
        Button32.Size = New Size(200, 90)
        Button32.TabIndex = 3
        Button32.TextAlignment = StringAlignment.Near
        Button32.UseVisualStyleBackColor = False
        Button32.VerticalPadding = 6F
        ' 
        ' Button33
        ' 
        Button33.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button33.FlatStyle = FlatStyle.Flat
        Button33.Location = New Point(211, 597)
        Button33.Margin = New Padding(0)
        Button33.Name = "Button33"
        Button33.Size = New Size(200, 90)
        Button33.TabIndex = 3
        Button33.TextAlignment = StringAlignment.Near
        Button33.UseVisualStyleBackColor = False
        Button33.VerticalPadding = 6F
        ' 
        ' Button34
        ' 
        Button34.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button34.FlatStyle = FlatStyle.Flat
        Button34.Location = New Point(611, 597)
        Button34.Margin = New Padding(0)
        Button34.Name = "Button34"
        Button34.Size = New Size(200, 90)
        Button34.TabIndex = 3
        Button34.TextAlignment = StringAlignment.Near
        Button34.UseVisualStyleBackColor = False
        Button34.VerticalPadding = 6F
        ' 
        ' Button35
        ' 
        Button35.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button35.FlatStyle = FlatStyle.Flat
        Button35.Location = New Point(811, 597)
        Button35.Margin = New Padding(0)
        Button35.Name = "Button35"
        Button35.Size = New Size(200, 90)
        Button35.TabIndex = 3
        Button35.TextAlignment = StringAlignment.Near
        Button35.UseVisualStyleBackColor = False
        Button35.VerticalPadding = 6F
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
    Friend WithEvents Button1 As MultiLineButton
    Friend WithEvents Button2 As MultiLineButton
    Friend WithEvents Button3 As MultiLineButton
    Friend WithEvents Button4 As MultiLineButton
    Friend WithEvents Button5 As MultiLineButton
    Friend WithEvents Button6 As MultiLineButton
    Friend WithEvents Button7 As MultiLineButton
    Friend WithEvents Button8 As MultiLineButton
    Friend WithEvents Button9 As MultiLineButton
    Friend WithEvents Button10 As MultiLineButton
    Friend WithEvents Button11 As MultiLineButton
    Friend WithEvents Button12 As MultiLineButton
    Friend WithEvents Button13 As MultiLineButton
    Friend WithEvents Button14 As MultiLineButton
    Friend WithEvents Button15 As MultiLineButton
    Friend WithEvents Button16 As MultiLineButton
    Friend WithEvents Button17 As MultiLineButton
    Friend WithEvents Button18 As MultiLineButton
    Friend WithEvents Button19 As MultiLineButton
    Friend WithEvents Button20 As MultiLineButton
    Friend WithEvents Button21 As MultiLineButton
    Friend WithEvents Button22 As MultiLineButton
    Friend WithEvents Button23 As MultiLineButton
    Friend WithEvents Button24 As MultiLineButton
    Friend WithEvents Button25 As MultiLineButton
    Friend WithEvents Button26 As MultiLineButton
    Friend WithEvents Button27 As MultiLineButton
    Friend WithEvents Button28 As MultiLineButton
    Friend WithEvents Button29 As MultiLineButton
    Friend WithEvents Button30 As MultiLineButton
    Friend WithEvents Button31 As MultiLineButton
    Friend WithEvents Button32 As MultiLineButton
    Friend WithEvents Button33 As MultiLineButton
    Friend WithEvents Button34 As MultiLineButton
    Friend WithEvents Button35 As MultiLineButton

End Class
