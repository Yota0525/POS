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
        components = New ComponentModel.Container()
        menu_exit_button = New Button()
        date_time_label = New Label()
        store_no_label = New Label()
        store_name_label = New Label()
        register_no_label = New Label()
        operation_date_label = New Label()
        operation_week_label = New Label()
        room_count_label = New Label()
        room_button_0 = New MultiLineButton()
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
        menu_next_button = New Button()
        menu_button_0 = New Button()
        menu_button_1 = New Button()
        menu_button_2 = New Button()
        menu_button_3 = New Button()
        menu_button_4 = New Button()
        menu_button_5 = New Button()
        menu_button_6 = New Button()
        menu_button_7 = New Button()
        menu_button_8 = New Button()
        date_time_timer = New Timer(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' menu_exit_button
        ' 
        menu_exit_button.BackColor = Color.White
        menu_exit_button.BackgroundImageLayout = ImageLayout.None
        menu_exit_button.FlatStyle = FlatStyle.Popup
        menu_exit_button.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_exit_button.Location = New Point(914, 695)
        menu_exit_button.Margin = New Padding(1)
        menu_exit_button.Name = "menu_exit_button"
        menu_exit_button.Size = New Size(83, 63)
        menu_exit_button.TabIndex = 0
        menu_exit_button.Text = "終了"
        menu_exit_button.UseVisualStyleBackColor = False
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
        store_no_label.Text = "9999"
        ' 
        ' store_name_label
        ' 
        store_name_label.AutoSize = True
        store_name_label.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        store_name_label.ForeColor = Color.Yellow
        store_name_label.Location = New Point(382, 11)
        store_name_label.Margin = New Padding(2, 0, 2, 0)
        store_name_label.Name = "store_name_label"
        store_name_label.Size = New Size(279, 16)
        store_name_label.TabIndex = 2
        store_name_label.Text = "カラオケまねきねこトレーニング店"
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
        register_no_label.Text = "01"
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
        operation_week_label.Text = "曜日区分:＊＊＊"
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
        ' room_button_0
        ' 
        room_button_0.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        room_button_0.BevelStyle = Border3DStyle.SunkenOuter
        room_button_0.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_0.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_0.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_0.FlatStyle = FlatStyle.Flat
        room_button_0.Location = New Point(13, 57)
        room_button_0.Margin = New Padding(0)
        room_button_0.Name = "room_button_0"
        room_button_0.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_0.Size = New Size(200, 91)
        room_button_0.TabIndex = 3
        room_button_0.TextAlignment = StringAlignment.Near
        room_button_0.UseVisualStyleBackColor = False
        room_button_0.VerticalPadding = 6F
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button2.BevelStyle = Border3DStyle.SunkenOuter
        Button2.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button2.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(213, 57)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button2.Size = New Size(200, 91)
        Button2.TabIndex = 3
        Button2.TextAlignment = StringAlignment.Near
        Button2.UseVisualStyleBackColor = False
        Button2.VerticalPadding = 6F
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button3.BevelStyle = Border3DStyle.SunkenOuter
        Button3.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button3.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(413, 57)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button3.Size = New Size(200, 91)
        Button3.TabIndex = 3
        Button3.TextAlignment = StringAlignment.Near
        Button3.UseVisualStyleBackColor = False
        Button3.VerticalPadding = 6F
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button4.BevelStyle = Border3DStyle.SunkenOuter
        Button4.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button4.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(613, 57)
        Button4.Margin = New Padding(0)
        Button4.Name = "Button4"
        Button4.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button4.Size = New Size(200, 91)
        Button4.TabIndex = 3
        Button4.TextAlignment = StringAlignment.Near
        Button4.UseVisualStyleBackColor = False
        Button4.VerticalPadding = 6F
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button5.BevelStyle = Border3DStyle.SunkenOuter
        Button5.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button5.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button5.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(813, 57)
        Button5.Margin = New Padding(0)
        Button5.Name = "Button5"
        Button5.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button5.Size = New Size(200, 91)
        Button5.TabIndex = 3
        Button5.TextAlignment = StringAlignment.Near
        Button5.UseVisualStyleBackColor = False
        Button5.VerticalPadding = 6F
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button6.BevelStyle = Border3DStyle.SunkenOuter
        Button6.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button6.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button6.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(13, 148)
        Button6.Margin = New Padding(0)
        Button6.Name = "Button6"
        Button6.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button6.Size = New Size(200, 91)
        Button6.TabIndex = 3
        Button6.TextAlignment = StringAlignment.Near
        Button6.UseVisualStyleBackColor = False
        Button6.VerticalPadding = 6F
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.White
        Button7.BevelStyle = Border3DStyle.SunkenOuter
        Button7.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button7.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button7.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(413, 148)
        Button7.Margin = New Padding(0)
        Button7.Name = "Button7"
        Button7.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button7.Size = New Size(200, 91)
        Button7.TabIndex = 3
        Button7.TextAlignment = StringAlignment.Near
        Button7.UseVisualStyleBackColor = False
        Button7.VerticalPadding = 6F
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button8.BevelStyle = Border3DStyle.SunkenOuter
        Button8.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button8.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button8.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(213, 148)
        Button8.Margin = New Padding(0)
        Button8.Name = "Button8"
        Button8.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button8.Size = New Size(200, 91)
        Button8.TabIndex = 3
        Button8.TextAlignment = StringAlignment.Near
        Button8.UseVisualStyleBackColor = False
        Button8.VerticalPadding = 6F
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.White
        Button9.BevelStyle = Border3DStyle.SunkenOuter
        Button9.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button9.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button9.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Location = New Point(613, 148)
        Button9.Margin = New Padding(0)
        Button9.Name = "Button9"
        Button9.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button9.Size = New Size(200, 91)
        Button9.TabIndex = 3
        Button9.TextAlignment = StringAlignment.Near
        Button9.UseVisualStyleBackColor = False
        Button9.VerticalPadding = 6F
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.White
        Button10.BevelStyle = Border3DStyle.SunkenOuter
        Button10.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button10.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button10.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Location = New Point(813, 148)
        Button10.Margin = New Padding(0)
        Button10.Name = "Button10"
        Button10.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button10.Size = New Size(200, 91)
        Button10.TabIndex = 3
        Button10.TextAlignment = StringAlignment.Near
        Button10.UseVisualStyleBackColor = False
        Button10.VerticalPadding = 6F
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.White
        Button11.BevelStyle = Border3DStyle.SunkenOuter
        Button11.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button11.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button11.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button11.FlatStyle = FlatStyle.Flat
        Button11.Location = New Point(13, 239)
        Button11.Margin = New Padding(0)
        Button11.Name = "Button11"
        Button11.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button11.Size = New Size(200, 91)
        Button11.TabIndex = 3
        Button11.TextAlignment = StringAlignment.Near
        Button11.UseVisualStyleBackColor = False
        Button11.VerticalPadding = 6F
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.White
        Button12.BevelStyle = Border3DStyle.SunkenOuter
        Button12.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button12.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button12.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button12.FlatStyle = FlatStyle.Flat
        Button12.Location = New Point(413, 239)
        Button12.Margin = New Padding(0)
        Button12.Name = "Button12"
        Button12.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button12.Size = New Size(200, 91)
        Button12.TabIndex = 3
        Button12.TextAlignment = StringAlignment.Near
        Button12.UseVisualStyleBackColor = False
        Button12.VerticalPadding = 6F
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.White
        Button13.BevelStyle = Border3DStyle.SunkenOuter
        Button13.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button13.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button13.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Location = New Point(213, 239)
        Button13.Margin = New Padding(0)
        Button13.Name = "Button13"
        Button13.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button13.Size = New Size(200, 91)
        Button13.TabIndex = 3
        Button13.TextAlignment = StringAlignment.Near
        Button13.UseVisualStyleBackColor = False
        Button13.VerticalPadding = 6F
        ' 
        ' Button14
        ' 
        Button14.BackColor = Color.White
        Button14.BevelStyle = Border3DStyle.SunkenOuter
        Button14.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button14.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button14.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button14.FlatStyle = FlatStyle.Flat
        Button14.Location = New Point(613, 239)
        Button14.Margin = New Padding(0)
        Button14.Name = "Button14"
        Button14.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button14.Size = New Size(200, 91)
        Button14.TabIndex = 3
        Button14.TextAlignment = StringAlignment.Near
        Button14.UseVisualStyleBackColor = False
        Button14.VerticalPadding = 6F
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button15.BevelStyle = Border3DStyle.SunkenOuter
        Button15.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button15.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button15.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button15.FlatStyle = FlatStyle.Flat
        Button15.Location = New Point(813, 239)
        Button15.Margin = New Padding(0)
        Button15.Name = "Button15"
        Button15.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button15.Size = New Size(200, 91)
        Button15.TabIndex = 3
        Button15.TextAlignment = StringAlignment.Near
        Button15.UseVisualStyleBackColor = False
        Button15.VerticalPadding = 6F
        ' 
        ' Button16
        ' 
        Button16.BackColor = Color.White
        Button16.BevelStyle = Border3DStyle.SunkenOuter
        Button16.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button16.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button16.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button16.FlatStyle = FlatStyle.Flat
        Button16.Location = New Point(13, 330)
        Button16.Margin = New Padding(0)
        Button16.Name = "Button16"
        Button16.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button16.Size = New Size(200, 91)
        Button16.TabIndex = 3
        Button16.TextAlignment = StringAlignment.Near
        Button16.UseVisualStyleBackColor = False
        Button16.VerticalPadding = 6F
        ' 
        ' Button17
        ' 
        Button17.BackColor = Color.White
        Button17.BevelStyle = Border3DStyle.SunkenOuter
        Button17.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button17.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button17.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button17.FlatStyle = FlatStyle.Flat
        Button17.Location = New Point(413, 330)
        Button17.Margin = New Padding(0)
        Button17.Name = "Button17"
        Button17.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button17.Size = New Size(200, 91)
        Button17.TabIndex = 3
        Button17.TextAlignment = StringAlignment.Near
        Button17.UseVisualStyleBackColor = False
        Button17.VerticalPadding = 6F
        ' 
        ' Button18
        ' 
        Button18.BackColor = Color.White
        Button18.BevelStyle = Border3DStyle.SunkenOuter
        Button18.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button18.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button18.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button18.FlatStyle = FlatStyle.Flat
        Button18.Location = New Point(213, 330)
        Button18.Margin = New Padding(0)
        Button18.Name = "Button18"
        Button18.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button18.Size = New Size(200, 91)
        Button18.TabIndex = 3
        Button18.TextAlignment = StringAlignment.Near
        Button18.UseVisualStyleBackColor = False
        Button18.VerticalPadding = 6F
        ' 
        ' Button19
        ' 
        Button19.BackColor = Color.White
        Button19.BevelStyle = Border3DStyle.SunkenOuter
        Button19.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button19.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button19.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button19.FlatStyle = FlatStyle.Flat
        Button19.Location = New Point(613, 330)
        Button19.Margin = New Padding(0)
        Button19.Name = "Button19"
        Button19.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button19.Size = New Size(200, 91)
        Button19.TabIndex = 3
        Button19.TextAlignment = StringAlignment.Near
        Button19.UseVisualStyleBackColor = False
        Button19.VerticalPadding = 6F
        ' 
        ' Button20
        ' 
        Button20.BackColor = Color.White
        Button20.BevelStyle = Border3DStyle.SunkenOuter
        Button20.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button20.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button20.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button20.FlatStyle = FlatStyle.Flat
        Button20.Location = New Point(813, 330)
        Button20.Margin = New Padding(0)
        Button20.Name = "Button20"
        Button20.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button20.Size = New Size(200, 91)
        Button20.TabIndex = 3
        Button20.TextAlignment = StringAlignment.Near
        Button20.UseVisualStyleBackColor = False
        Button20.VerticalPadding = 6F
        ' 
        ' Button21
        ' 
        Button21.BackColor = Color.White
        Button21.BevelStyle = Border3DStyle.SunkenOuter
        Button21.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button21.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button21.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button21.FlatStyle = FlatStyle.Flat
        Button21.Location = New Point(13, 421)
        Button21.Margin = New Padding(0)
        Button21.Name = "Button21"
        Button21.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button21.Size = New Size(200, 91)
        Button21.TabIndex = 3
        Button21.TextAlignment = StringAlignment.Near
        Button21.UseVisualStyleBackColor = False
        Button21.VerticalPadding = 6F
        ' 
        ' Button22
        ' 
        Button22.BackColor = Color.White
        Button22.BevelStyle = Border3DStyle.SunkenOuter
        Button22.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button22.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button22.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button22.FlatStyle = FlatStyle.Flat
        Button22.Location = New Point(413, 421)
        Button22.Margin = New Padding(0)
        Button22.Name = "Button22"
        Button22.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button22.Size = New Size(200, 91)
        Button22.TabIndex = 3
        Button22.TextAlignment = StringAlignment.Near
        Button22.UseVisualStyleBackColor = False
        Button22.VerticalPadding = 6F
        ' 
        ' Button23
        ' 
        Button23.BackColor = Color.White
        Button23.BevelStyle = Border3DStyle.SunkenOuter
        Button23.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button23.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button23.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button23.FlatStyle = FlatStyle.Flat
        Button23.Location = New Point(213, 421)
        Button23.Margin = New Padding(0)
        Button23.Name = "Button23"
        Button23.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button23.Size = New Size(200, 91)
        Button23.TabIndex = 3
        Button23.TextAlignment = StringAlignment.Near
        Button23.UseVisualStyleBackColor = False
        Button23.VerticalPadding = 6F
        ' 
        ' Button24
        ' 
        Button24.BackColor = Color.White
        Button24.BevelStyle = Border3DStyle.SunkenOuter
        Button24.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button24.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button24.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button24.FlatStyle = FlatStyle.Flat
        Button24.Location = New Point(613, 421)
        Button24.Margin = New Padding(0)
        Button24.Name = "Button24"
        Button24.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button24.Size = New Size(200, 91)
        Button24.TabIndex = 3
        Button24.TextAlignment = StringAlignment.Near
        Button24.UseVisualStyleBackColor = False
        Button24.VerticalPadding = 6F
        ' 
        ' Button25
        ' 
        Button25.BackColor = Color.White
        Button25.BevelStyle = Border3DStyle.SunkenOuter
        Button25.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        Button25.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button25.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button25.FlatStyle = FlatStyle.Flat
        Button25.Location = New Point(813, 421)
        Button25.Margin = New Padding(0)
        Button25.Name = "Button25"
        Button25.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button25.Size = New Size(200, 91)
        Button25.TabIndex = 3
        Button25.TextAlignment = StringAlignment.Near
        Button25.UseVisualStyleBackColor = False
        Button25.VerticalPadding = 6F
        ' 
        ' Button26
        ' 
        Button26.BackColor = Color.Silver
        Button26.BevelStyle = Border3DStyle.SunkenOuter
        Button26.DisplayText = ""
        Button26.Enabled = False
        Button26.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button26.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button26.FlatStyle = FlatStyle.Flat
        Button26.Location = New Point(13, 512)
        Button26.Margin = New Padding(0)
        Button26.Name = "Button26"
        Button26.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button26.Size = New Size(200, 91)
        Button26.TabIndex = 3
        Button26.TextAlignment = StringAlignment.Near
        Button26.UseVisualStyleBackColor = False
        Button26.VerticalPadding = 6F
        ' 
        ' Button27
        ' 
        Button27.BackColor = Color.Silver
        Button27.BevelStyle = Border3DStyle.SunkenOuter
        Button27.DisplayText = ""
        Button27.Enabled = False
        Button27.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button27.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button27.FlatStyle = FlatStyle.Flat
        Button27.Location = New Point(413, 512)
        Button27.Margin = New Padding(0)
        Button27.Name = "Button27"
        Button27.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button27.Size = New Size(200, 91)
        Button27.TabIndex = 3
        Button27.TextAlignment = StringAlignment.Near
        Button27.UseVisualStyleBackColor = False
        Button27.VerticalPadding = 6F
        ' 
        ' Button28
        ' 
        Button28.BackColor = Color.Silver
        Button28.BevelStyle = Border3DStyle.SunkenOuter
        Button28.DisplayText = ""
        Button28.Enabled = False
        Button28.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button28.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button28.FlatStyle = FlatStyle.Flat
        Button28.Location = New Point(213, 512)
        Button28.Margin = New Padding(0)
        Button28.Name = "Button28"
        Button28.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button28.Size = New Size(200, 91)
        Button28.TabIndex = 3
        Button28.TextAlignment = StringAlignment.Near
        Button28.UseVisualStyleBackColor = False
        Button28.VerticalPadding = 6F
        ' 
        ' Button29
        ' 
        Button29.BackColor = Color.Silver
        Button29.BevelStyle = Border3DStyle.SunkenOuter
        Button29.DisplayText = ""
        Button29.Enabled = False
        Button29.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button29.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button29.FlatStyle = FlatStyle.Flat
        Button29.Location = New Point(613, 512)
        Button29.Margin = New Padding(0)
        Button29.Name = "Button29"
        Button29.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button29.Size = New Size(200, 91)
        Button29.TabIndex = 3
        Button29.TextAlignment = StringAlignment.Near
        Button29.UseVisualStyleBackColor = False
        Button29.VerticalPadding = 6F
        ' 
        ' Button30
        ' 
        Button30.BackColor = Color.Silver
        Button30.BevelStyle = Border3DStyle.SunkenOuter
        Button30.DisplayText = ""
        Button30.Enabled = False
        Button30.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button30.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button30.FlatStyle = FlatStyle.Flat
        Button30.Location = New Point(813, 512)
        Button30.Margin = New Padding(0)
        Button30.Name = "Button30"
        Button30.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button30.Size = New Size(200, 91)
        Button30.TabIndex = 3
        Button30.TextAlignment = StringAlignment.Near
        Button30.UseVisualStyleBackColor = False
        Button30.VerticalPadding = 6F
        ' 
        ' Button31
        ' 
        Button31.BackColor = Color.Silver
        Button31.BevelStyle = Border3DStyle.SunkenOuter
        Button31.DisplayText = ""
        Button31.Enabled = False
        Button31.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button31.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button31.FlatStyle = FlatStyle.Flat
        Button31.Location = New Point(13, 603)
        Button31.Margin = New Padding(0)
        Button31.Name = "Button31"
        Button31.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button31.Size = New Size(200, 91)
        Button31.TabIndex = 3
        Button31.TextAlignment = StringAlignment.Near
        Button31.UseVisualStyleBackColor = False
        Button31.VerticalPadding = 6F
        ' 
        ' Button32
        ' 
        Button32.BackColor = Color.Silver
        Button32.BevelStyle = Border3DStyle.SunkenOuter
        Button32.DisplayText = ""
        Button32.Enabled = False
        Button32.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button32.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button32.FlatStyle = FlatStyle.Flat
        Button32.Location = New Point(413, 603)
        Button32.Margin = New Padding(0)
        Button32.Name = "Button32"
        Button32.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button32.Size = New Size(200, 91)
        Button32.TabIndex = 3
        Button32.TextAlignment = StringAlignment.Near
        Button32.UseVisualStyleBackColor = False
        Button32.VerticalPadding = 6F
        ' 
        ' Button33
        ' 
        Button33.BackColor = Color.Silver
        Button33.BevelStyle = Border3DStyle.SunkenOuter
        Button33.DisplayText = ""
        Button33.Enabled = False
        Button33.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button33.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button33.FlatStyle = FlatStyle.Flat
        Button33.Location = New Point(213, 603)
        Button33.Margin = New Padding(0)
        Button33.Name = "Button33"
        Button33.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button33.Size = New Size(200, 91)
        Button33.TabIndex = 3
        Button33.TextAlignment = StringAlignment.Near
        Button33.UseVisualStyleBackColor = False
        Button33.VerticalPadding = 6F
        ' 
        ' Button34
        ' 
        Button34.BackColor = Color.Silver
        Button34.BevelStyle = Border3DStyle.SunkenOuter
        Button34.DisplayText = ""
        Button34.Enabled = False
        Button34.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button34.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button34.FlatStyle = FlatStyle.Flat
        Button34.Location = New Point(613, 603)
        Button34.Margin = New Padding(0)
        Button34.Name = "Button34"
        Button34.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button34.Size = New Size(200, 91)
        Button34.TabIndex = 3
        Button34.TextAlignment = StringAlignment.Near
        Button34.UseVisualStyleBackColor = False
        Button34.VerticalPadding = 6F
        ' 
        ' Button35
        ' 
        Button35.BackColor = Color.Silver
        Button35.BevelStyle = Border3DStyle.SunkenOuter
        Button35.DisplayText = ""
        Button35.Enabled = False
        Button35.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Button35.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button35.FlatStyle = FlatStyle.Flat
        Button35.Location = New Point(813, 603)
        Button35.Margin = New Padding(0)
        Button35.Name = "Button35"
        Button35.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        Button35.Size = New Size(200, 91)
        Button35.TabIndex = 3
        Button35.TextAlignment = StringAlignment.Near
        Button35.UseVisualStyleBackColor = False
        Button35.VerticalPadding = 6F
        ' 
        ' menu_next_button
        ' 
        menu_next_button.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        menu_next_button.BackgroundImageLayout = ImageLayout.None
        menu_next_button.FlatStyle = FlatStyle.Popup
        menu_next_button.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_next_button.Location = New Point(27, 695)
        menu_next_button.Margin = New Padding(1)
        menu_next_button.Name = "menu_next_button"
        menu_next_button.Size = New Size(85, 63)
        menu_next_button.TabIndex = 0
        menu_next_button.Text = "次へ"
        menu_next_button.UseVisualStyleBackColor = False
        ' 
        ' menu_button_0
        ' 
        menu_button_0.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        menu_button_0.BackgroundImageLayout = ImageLayout.None
        menu_button_0.FlatStyle = FlatStyle.Popup
        menu_button_0.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_0.Location = New Point(122, 695)
        menu_button_0.Margin = New Padding(1)
        menu_button_0.Name = "menu_button_0"
        menu_button_0.Size = New Size(85, 63)
        menu_button_0.TabIndex = 0
        menu_button_0.Text = "＊＊＊＊"
        menu_button_0.UseVisualStyleBackColor = False
        ' 
        ' menu_button_1
        ' 
        menu_button_1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        menu_button_1.BackgroundImageLayout = ImageLayout.None
        menu_button_1.FlatStyle = FlatStyle.Popup
        menu_button_1.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_1.Location = New Point(209, 695)
        menu_button_1.Margin = New Padding(1)
        menu_button_1.Name = "menu_button_1"
        menu_button_1.Size = New Size(85, 63)
        menu_button_1.TabIndex = 0
        menu_button_1.Text = "＊＊＊＊"
        menu_button_1.UseVisualStyleBackColor = False
        ' 
        ' menu_button_2
        ' 
        menu_button_2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        menu_button_2.BackgroundImageLayout = ImageLayout.None
        menu_button_2.FlatStyle = FlatStyle.Popup
        menu_button_2.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_2.Location = New Point(296, 695)
        menu_button_2.Margin = New Padding(1)
        menu_button_2.Name = "menu_button_2"
        menu_button_2.Size = New Size(85, 63)
        menu_button_2.TabIndex = 0
        menu_button_2.Text = "＊＊＊＊"
        menu_button_2.UseVisualStyleBackColor = False
        ' 
        ' menu_button_3
        ' 
        menu_button_3.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        menu_button_3.BackgroundImageLayout = ImageLayout.None
        menu_button_3.FlatStyle = FlatStyle.Popup
        menu_button_3.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_3.Location = New Point(383, 695)
        menu_button_3.Margin = New Padding(1)
        menu_button_3.Name = "menu_button_3"
        menu_button_3.Size = New Size(85, 63)
        menu_button_3.TabIndex = 0
        menu_button_3.Text = "＊＊＊＊"
        menu_button_3.UseVisualStyleBackColor = False
        ' 
        ' menu_button_4
        ' 
        menu_button_4.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        menu_button_4.BackgroundImageLayout = ImageLayout.None
        menu_button_4.FlatStyle = FlatStyle.Popup
        menu_button_4.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_4.Location = New Point(470, 695)
        menu_button_4.Margin = New Padding(1)
        menu_button_4.Name = "menu_button_4"
        menu_button_4.Size = New Size(85, 63)
        menu_button_4.TabIndex = 0
        menu_button_4.Text = "＊＊＊＊"
        menu_button_4.UseVisualStyleBackColor = False
        ' 
        ' menu_button_5
        ' 
        menu_button_5.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        menu_button_5.BackgroundImageLayout = ImageLayout.None
        menu_button_5.FlatStyle = FlatStyle.Popup
        menu_button_5.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_5.Location = New Point(557, 695)
        menu_button_5.Margin = New Padding(1)
        menu_button_5.Name = "menu_button_5"
        menu_button_5.Size = New Size(85, 63)
        menu_button_5.TabIndex = 0
        menu_button_5.Text = "＊＊＊＊"
        menu_button_5.UseVisualStyleBackColor = False
        ' 
        ' menu_button_6
        ' 
        menu_button_6.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        menu_button_6.BackgroundImageLayout = ImageLayout.None
        menu_button_6.FlatStyle = FlatStyle.Popup
        menu_button_6.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_6.Location = New Point(644, 695)
        menu_button_6.Margin = New Padding(1)
        menu_button_6.Name = "menu_button_6"
        menu_button_6.Size = New Size(85, 63)
        menu_button_6.TabIndex = 0
        menu_button_6.Text = "＊＊＊＊"
        menu_button_6.UseVisualStyleBackColor = False
        ' 
        ' menu_button_7
        ' 
        menu_button_7.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        menu_button_7.BackgroundImageLayout = ImageLayout.None
        menu_button_7.FlatStyle = FlatStyle.Popup
        menu_button_7.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_7.Location = New Point(731, 695)
        menu_button_7.Margin = New Padding(1)
        menu_button_7.Name = "menu_button_7"
        menu_button_7.Size = New Size(85, 63)
        menu_button_7.TabIndex = 0
        menu_button_7.Text = "＊＊＊＊"
        menu_button_7.UseVisualStyleBackColor = False
        ' 
        ' menu_button_8
        ' 
        menu_button_8.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        menu_button_8.BackgroundImageLayout = ImageLayout.None
        menu_button_8.FlatStyle = FlatStyle.Popup
        menu_button_8.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_8.Location = New Point(818, 695)
        menu_button_8.Margin = New Padding(1)
        menu_button_8.Name = "menu_button_8"
        menu_button_8.Size = New Size(85, 63)
        menu_button_8.TabIndex = 0
        menu_button_8.Text = "＊＊＊＊"
        menu_button_8.UseVisualStyleBackColor = False
        ' 
        ' date_time_timer
        ' 
        date_time_timer.Enabled = True
        date_time_timer.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.Cyan
        Label1.Location = New Point(944, 38)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 16)
        Label1.TabIndex = 2
        Label1.Text = "フロア1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1024, 768)
        Controls.Add(Button35)
        Controls.Add(Button5)
        Controls.Add(operation_week_label)
        Controls.Add(Button34)
        Controls.Add(operation_date_label)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Button30)
        Controls.Add(room_count_label)
        Controls.Add(Button2)
        Controls.Add(register_no_label)
        Controls.Add(Button29)
        Controls.Add(store_name_label)
        Controls.Add(Button3)
        Controls.Add(store_no_label)
        Controls.Add(Button25)
        Controls.Add(date_time_label)
        Controls.Add(room_button_0)
        Controls.Add(Button24)
        Controls.Add(menu_button_8)
        Controls.Add(Button20)
        Controls.Add(menu_button_7)
        Controls.Add(Button19)
        Controls.Add(menu_button_6)
        Controls.Add(Button33)
        Controls.Add(menu_button_5)
        Controls.Add(Button15)
        Controls.Add(menu_button_4)
        Controls.Add(Button28)
        Controls.Add(menu_button_3)
        Controls.Add(Button14)
        Controls.Add(menu_button_2)
        Controls.Add(Button23)
        Controls.Add(menu_button_1)
        Controls.Add(Button10)
        Controls.Add(menu_button_0)
        Controls.Add(Button18)
        Controls.Add(menu_next_button)
        Controls.Add(Button32)
        Controls.Add(menu_exit_button)
        Controls.Add(Button9)
        Controls.Add(Button6)
        Controls.Add(Button27)
        Controls.Add(Button11)
        Controls.Add(Button13)
        Controls.Add(Button7)
        Controls.Add(Button22)
        Controls.Add(Button16)
        Controls.Add(Button17)
        Controls.Add(Button21)
        Controls.Add(Button31)
        Controls.Add(Button12)
        Controls.Add(Button8)
        Controls.Add(Button26)
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

    Friend WithEvents menu_exit_button As Button
    Friend WithEvents date_time_label As Label
    Friend WithEvents store_no_label As Label
    Friend WithEvents store_name_label As Label
    Friend WithEvents register_no_label As Label
    Friend WithEvents operation_date_label As Label
    Friend WithEvents operation_week_label As Label
    Friend WithEvents room_count_label As Label
    Friend WithEvents room_button_0 As MultiLineButton
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
    Friend WithEvents menu_next_button As Button
    Friend WithEvents menu_button_0 As Button
    Friend WithEvents menu_button_1 As Button
    Friend WithEvents menu_button_2 As Button
    Friend WithEvents menu_button_3 As Button
    Friend WithEvents menu_button_4 As Button
    Friend WithEvents menu_button_5 As Button
    Friend WithEvents menu_button_6 As Button
    Friend WithEvents menu_button_7 As Button
    Friend WithEvents menu_button_8 As Button
    Friend WithEvents date_time_timer As Timer
    Friend WithEvents Label1 As Label

End Class
