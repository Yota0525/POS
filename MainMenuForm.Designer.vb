<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
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
        room_button_1 = New MultiLineButton()
        room_button_2 = New MultiLineButton()
        room_button_3 = New MultiLineButton()
        room_button_4 = New MultiLineButton()
        room_button_5 = New MultiLineButton()
        room_button_7 = New MultiLineButton()
        room_button_6 = New MultiLineButton()
        room_button_8 = New MultiLineButton()
        room_button_9 = New MultiLineButton()
        room_button_10 = New MultiLineButton()
        room_button_12 = New MultiLineButton()
        room_button_11 = New MultiLineButton()
        room_button_13 = New MultiLineButton()
        room_button_14 = New MultiLineButton()
        room_button_15 = New MultiLineButton()
        room_button_17 = New MultiLineButton()
        room_button_16 = New MultiLineButton()
        room_button_18 = New MultiLineButton()
        room_button_19 = New MultiLineButton()
        room_button_20 = New MultiLineButton()
        room_button_22 = New MultiLineButton()
        room_button_21 = New MultiLineButton()
        room_button_23 = New MultiLineButton()
        room_button_24 = New MultiLineButton()
        room_button_25 = New MultiLineButton()
        room_button_27 = New MultiLineButton()
        room_button_26 = New MultiLineButton()
        room_button_28 = New MultiLineButton()
        room_button_29 = New MultiLineButton()
        room_button_30 = New MultiLineButton()
        room_button_32 = New MultiLineButton()
        room_button_31 = New MultiLineButton()
        room_button_33 = New MultiLineButton()
        room_button_34 = New MultiLineButton()
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
        room_button_0.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
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
        ' room_button_1
        ' 
        room_button_1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_1.BevelStyle = Border3DStyle.SunkenOuter
        room_button_1.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_1.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_1.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_1.FlatStyle = FlatStyle.Flat
        room_button_1.Location = New Point(213, 57)
        room_button_1.Margin = New Padding(0)
        room_button_1.Name = "room_button_1"
        room_button_1.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_1.Size = New Size(200, 91)
        room_button_1.TabIndex = 3
        room_button_1.TextAlignment = StringAlignment.Near
        room_button_1.UseVisualStyleBackColor = False
        room_button_1.VerticalPadding = 6F
        ' 
        ' room_button_2
        ' 
        room_button_2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_2.BevelStyle = Border3DStyle.SunkenOuter
        room_button_2.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_2.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_2.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_2.FlatStyle = FlatStyle.Flat
        room_button_2.Location = New Point(413, 57)
        room_button_2.Margin = New Padding(0)
        room_button_2.Name = "room_button_2"
        room_button_2.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_2.Size = New Size(200, 91)
        room_button_2.TabIndex = 3
        room_button_2.TextAlignment = StringAlignment.Near
        room_button_2.UseVisualStyleBackColor = False
        room_button_2.VerticalPadding = 6F
        ' 
        ' room_button_3
        ' 
        room_button_3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_3.BevelStyle = Border3DStyle.SunkenOuter
        room_button_3.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_3.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_3.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_3.FlatStyle = FlatStyle.Flat
        room_button_3.Location = New Point(613, 57)
        room_button_3.Margin = New Padding(0)
        room_button_3.Name = "room_button_3"
        room_button_3.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_3.Size = New Size(200, 91)
        room_button_3.TabIndex = 3
        room_button_3.TextAlignment = StringAlignment.Near
        room_button_3.UseVisualStyleBackColor = False
        room_button_3.VerticalPadding = 6F
        ' 
        ' room_button_4
        ' 
        room_button_4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_4.BevelStyle = Border3DStyle.SunkenOuter
        room_button_4.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_4.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_4.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_4.FlatStyle = FlatStyle.Flat
        room_button_4.Location = New Point(813, 57)
        room_button_4.Margin = New Padding(0)
        room_button_4.Name = "room_button_4"
        room_button_4.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_4.Size = New Size(200, 91)
        room_button_4.TabIndex = 3
        room_button_4.TextAlignment = StringAlignment.Near
        room_button_4.UseVisualStyleBackColor = False
        room_button_4.VerticalPadding = 6F
        ' 
        ' room_button_5
        ' 
        room_button_5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_5.BevelStyle = Border3DStyle.SunkenOuter
        room_button_5.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_5.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_5.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_5.FlatStyle = FlatStyle.Flat
        room_button_5.Location = New Point(13, 148)
        room_button_5.Margin = New Padding(0)
        room_button_5.Name = "room_button_5"
        room_button_5.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_5.Size = New Size(200, 91)
        room_button_5.TabIndex = 3
        room_button_5.TextAlignment = StringAlignment.Near
        room_button_5.UseVisualStyleBackColor = False
        room_button_5.VerticalPadding = 6F
        ' 
        ' room_button_7
        ' 
        room_button_7.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_7.BevelStyle = Border3DStyle.SunkenOuter
        room_button_7.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_7.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_7.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_7.FlatStyle = FlatStyle.Flat
        room_button_7.Location = New Point(413, 148)
        room_button_7.Margin = New Padding(0)
        room_button_7.Name = "room_button_7"
        room_button_7.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_7.Size = New Size(200, 91)
        room_button_7.TabIndex = 3
        room_button_7.TextAlignment = StringAlignment.Near
        room_button_7.UseVisualStyleBackColor = False
        room_button_7.VerticalPadding = 6F
        ' 
        ' room_button_6
        ' 
        room_button_6.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_6.BevelStyle = Border3DStyle.SunkenOuter
        room_button_6.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_6.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_6.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_6.FlatStyle = FlatStyle.Flat
        room_button_6.Location = New Point(213, 148)
        room_button_6.Margin = New Padding(0)
        room_button_6.Name = "room_button_6"
        room_button_6.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_6.Size = New Size(200, 91)
        room_button_6.TabIndex = 3
        room_button_6.TextAlignment = StringAlignment.Near
        room_button_6.UseVisualStyleBackColor = False
        room_button_6.VerticalPadding = 6F
        ' 
        ' room_button_8
        ' 
        room_button_8.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_8.BevelStyle = Border3DStyle.SunkenOuter
        room_button_8.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_8.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_8.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_8.FlatStyle = FlatStyle.Flat
        room_button_8.Location = New Point(613, 148)
        room_button_8.Margin = New Padding(0)
        room_button_8.Name = "room_button_8"
        room_button_8.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_8.Size = New Size(200, 91)
        room_button_8.TabIndex = 3
        room_button_8.TextAlignment = StringAlignment.Near
        room_button_8.UseVisualStyleBackColor = False
        room_button_8.VerticalPadding = 6F
        ' 
        ' room_button_9
        ' 
        room_button_9.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_9.BevelStyle = Border3DStyle.SunkenOuter
        room_button_9.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_9.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_9.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_9.FlatStyle = FlatStyle.Flat
        room_button_9.Location = New Point(813, 148)
        room_button_9.Margin = New Padding(0)
        room_button_9.Name = "room_button_9"
        room_button_9.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_9.Size = New Size(200, 91)
        room_button_9.TabIndex = 3
        room_button_9.TextAlignment = StringAlignment.Near
        room_button_9.UseVisualStyleBackColor = False
        room_button_9.VerticalPadding = 6F
        ' 
        ' room_button_10
        ' 
        room_button_10.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_10.BevelStyle = Border3DStyle.SunkenOuter
        room_button_10.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_10.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_10.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_10.FlatStyle = FlatStyle.Flat
        room_button_10.Location = New Point(13, 239)
        room_button_10.Margin = New Padding(0)
        room_button_10.Name = "room_button_10"
        room_button_10.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_10.Size = New Size(200, 91)
        room_button_10.TabIndex = 3
        room_button_10.TextAlignment = StringAlignment.Near
        room_button_10.UseVisualStyleBackColor = False
        room_button_10.VerticalPadding = 6F
        ' 
        ' room_button_12
        ' 
        room_button_12.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_12.BevelStyle = Border3DStyle.SunkenOuter
        room_button_12.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_12.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_12.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_12.FlatStyle = FlatStyle.Flat
        room_button_12.Location = New Point(413, 239)
        room_button_12.Margin = New Padding(0)
        room_button_12.Name = "room_button_12"
        room_button_12.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_12.Size = New Size(200, 91)
        room_button_12.TabIndex = 3
        room_button_12.TextAlignment = StringAlignment.Near
        room_button_12.UseVisualStyleBackColor = False
        room_button_12.VerticalPadding = 6F
        ' 
        ' room_button_11
        ' 
        room_button_11.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_11.BevelStyle = Border3DStyle.SunkenOuter
        room_button_11.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_11.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_11.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_11.FlatStyle = FlatStyle.Flat
        room_button_11.Location = New Point(213, 239)
        room_button_11.Margin = New Padding(0)
        room_button_11.Name = "room_button_11"
        room_button_11.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_11.Size = New Size(200, 91)
        room_button_11.TabIndex = 3
        room_button_11.TextAlignment = StringAlignment.Near
        room_button_11.UseVisualStyleBackColor = False
        room_button_11.VerticalPadding = 6F
        ' 
        ' room_button_13
        ' 
        room_button_13.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_13.BevelStyle = Border3DStyle.SunkenOuter
        room_button_13.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_13.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_13.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_13.FlatStyle = FlatStyle.Flat
        room_button_13.Location = New Point(613, 239)
        room_button_13.Margin = New Padding(0)
        room_button_13.Name = "room_button_13"
        room_button_13.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_13.Size = New Size(200, 91)
        room_button_13.TabIndex = 3
        room_button_13.TextAlignment = StringAlignment.Near
        room_button_13.UseVisualStyleBackColor = False
        room_button_13.VerticalPadding = 6F
        ' 
        ' room_button_14
        ' 
        room_button_14.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_14.BevelStyle = Border3DStyle.SunkenOuter
        room_button_14.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_14.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_14.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_14.FlatStyle = FlatStyle.Flat
        room_button_14.Location = New Point(813, 239)
        room_button_14.Margin = New Padding(0)
        room_button_14.Name = "room_button_14"
        room_button_14.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_14.Size = New Size(200, 91)
        room_button_14.TabIndex = 3
        room_button_14.TextAlignment = StringAlignment.Near
        room_button_14.UseVisualStyleBackColor = False
        room_button_14.VerticalPadding = 6F
        ' 
        ' room_button_15
        ' 
        room_button_15.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_15.BevelStyle = Border3DStyle.SunkenOuter
        room_button_15.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_15.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_15.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_15.FlatStyle = FlatStyle.Flat
        room_button_15.Location = New Point(13, 330)
        room_button_15.Margin = New Padding(0)
        room_button_15.Name = "room_button_15"
        room_button_15.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_15.Size = New Size(200, 91)
        room_button_15.TabIndex = 3
        room_button_15.TextAlignment = StringAlignment.Near
        room_button_15.UseVisualStyleBackColor = False
        room_button_15.VerticalPadding = 6F
        ' 
        ' room_button_17
        ' 
        room_button_17.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_17.BevelStyle = Border3DStyle.SunkenOuter
        room_button_17.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_17.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_17.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_17.FlatStyle = FlatStyle.Flat
        room_button_17.Location = New Point(413, 330)
        room_button_17.Margin = New Padding(0)
        room_button_17.Name = "room_button_17"
        room_button_17.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_17.Size = New Size(200, 91)
        room_button_17.TabIndex = 3
        room_button_17.TextAlignment = StringAlignment.Near
        room_button_17.UseVisualStyleBackColor = False
        room_button_17.VerticalPadding = 6F
        ' 
        ' room_button_16
        ' 
        room_button_16.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_16.BevelStyle = Border3DStyle.SunkenOuter
        room_button_16.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_16.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_16.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_16.FlatStyle = FlatStyle.Flat
        room_button_16.Location = New Point(213, 330)
        room_button_16.Margin = New Padding(0)
        room_button_16.Name = "room_button_16"
        room_button_16.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_16.Size = New Size(200, 91)
        room_button_16.TabIndex = 3
        room_button_16.TextAlignment = StringAlignment.Near
        room_button_16.UseVisualStyleBackColor = False
        room_button_16.VerticalPadding = 6F
        ' 
        ' room_button_18
        ' 
        room_button_18.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_18.BevelStyle = Border3DStyle.SunkenOuter
        room_button_18.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_18.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_18.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_18.FlatStyle = FlatStyle.Flat
        room_button_18.Location = New Point(613, 330)
        room_button_18.Margin = New Padding(0)
        room_button_18.Name = "room_button_18"
        room_button_18.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_18.Size = New Size(200, 91)
        room_button_18.TabIndex = 3
        room_button_18.TextAlignment = StringAlignment.Near
        room_button_18.UseVisualStyleBackColor = False
        room_button_18.VerticalPadding = 6F
        ' 
        ' room_button_19
        ' 
        room_button_19.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_19.BevelStyle = Border3DStyle.SunkenOuter
        room_button_19.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_19.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_19.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_19.FlatStyle = FlatStyle.Flat
        room_button_19.Location = New Point(813, 330)
        room_button_19.Margin = New Padding(0)
        room_button_19.Name = "room_button_19"
        room_button_19.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_19.Size = New Size(200, 91)
        room_button_19.TabIndex = 3
        room_button_19.TextAlignment = StringAlignment.Near
        room_button_19.UseVisualStyleBackColor = False
        room_button_19.VerticalPadding = 6F
        ' 
        ' room_button_20
        ' 
        room_button_20.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_20.BevelStyle = Border3DStyle.SunkenOuter
        room_button_20.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_20.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_20.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_20.FlatStyle = FlatStyle.Flat
        room_button_20.Location = New Point(13, 421)
        room_button_20.Margin = New Padding(0)
        room_button_20.Name = "room_button_20"
        room_button_20.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_20.Size = New Size(200, 91)
        room_button_20.TabIndex = 3
        room_button_20.TextAlignment = StringAlignment.Near
        room_button_20.UseVisualStyleBackColor = False
        room_button_20.VerticalPadding = 6F
        ' 
        ' room_button_22
        ' 
        room_button_22.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_22.BevelStyle = Border3DStyle.SunkenOuter
        room_button_22.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_22.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_22.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_22.FlatStyle = FlatStyle.Flat
        room_button_22.Location = New Point(413, 421)
        room_button_22.Margin = New Padding(0)
        room_button_22.Name = "room_button_22"
        room_button_22.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_22.Size = New Size(200, 91)
        room_button_22.TabIndex = 3
        room_button_22.TextAlignment = StringAlignment.Near
        room_button_22.UseVisualStyleBackColor = False
        room_button_22.VerticalPadding = 6F
        ' 
        ' room_button_21
        ' 
        room_button_21.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_21.BevelStyle = Border3DStyle.SunkenOuter
        room_button_21.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_21.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_21.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_21.FlatStyle = FlatStyle.Flat
        room_button_21.Location = New Point(213, 421)
        room_button_21.Margin = New Padding(0)
        room_button_21.Name = "room_button_21"
        room_button_21.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_21.Size = New Size(200, 91)
        room_button_21.TabIndex = 3
        room_button_21.TextAlignment = StringAlignment.Near
        room_button_21.UseVisualStyleBackColor = False
        room_button_21.VerticalPadding = 6F
        ' 
        ' room_button_23
        ' 
        room_button_23.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_23.BevelStyle = Border3DStyle.SunkenOuter
        room_button_23.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_23.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_23.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_23.FlatStyle = FlatStyle.Flat
        room_button_23.Location = New Point(613, 421)
        room_button_23.Margin = New Padding(0)
        room_button_23.Name = "room_button_23"
        room_button_23.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_23.Size = New Size(200, 91)
        room_button_23.TabIndex = 3
        room_button_23.TextAlignment = StringAlignment.Near
        room_button_23.UseVisualStyleBackColor = False
        room_button_23.VerticalPadding = 6F
        ' 
        ' room_button_24
        ' 
        room_button_24.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_24.BevelStyle = Border3DStyle.SunkenOuter
        room_button_24.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_24.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_24.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_24.FlatStyle = FlatStyle.Flat
        room_button_24.Location = New Point(813, 421)
        room_button_24.Margin = New Padding(0)
        room_button_24.Name = "room_button_24"
        room_button_24.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_24.Size = New Size(200, 91)
        room_button_24.TabIndex = 3
        room_button_24.TextAlignment = StringAlignment.Near
        room_button_24.UseVisualStyleBackColor = False
        room_button_24.VerticalPadding = 6F
        ' 
        ' room_button_25
        ' 
        room_button_25.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_25.BevelStyle = Border3DStyle.SunkenOuter
        room_button_25.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_25.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_25.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_25.FlatStyle = FlatStyle.Flat
        room_button_25.Location = New Point(13, 512)
        room_button_25.Margin = New Padding(0)
        room_button_25.Name = "room_button_25"
        room_button_25.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_25.Size = New Size(200, 91)
        room_button_25.TabIndex = 3
        room_button_25.TextAlignment = StringAlignment.Near
        room_button_25.UseVisualStyleBackColor = False
        room_button_25.VerticalPadding = 6F
        ' 
        ' room_button_27
        ' 
        room_button_27.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_27.BevelStyle = Border3DStyle.SunkenOuter
        room_button_27.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_27.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_27.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_27.FlatStyle = FlatStyle.Flat
        room_button_27.Location = New Point(413, 512)
        room_button_27.Margin = New Padding(0)
        room_button_27.Name = "room_button_27"
        room_button_27.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_27.Size = New Size(200, 91)
        room_button_27.TabIndex = 3
        room_button_27.TextAlignment = StringAlignment.Near
        room_button_27.UseVisualStyleBackColor = False
        room_button_27.VerticalPadding = 6F
        ' 
        ' room_button_26
        ' 
        room_button_26.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_26.BevelStyle = Border3DStyle.SunkenOuter
        room_button_26.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_26.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_26.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_26.FlatStyle = FlatStyle.Flat
        room_button_26.Location = New Point(213, 512)
        room_button_26.Margin = New Padding(0)
        room_button_26.Name = "room_button_26"
        room_button_26.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_26.Size = New Size(200, 91)
        room_button_26.TabIndex = 3
        room_button_26.TextAlignment = StringAlignment.Near
        room_button_26.UseVisualStyleBackColor = False
        room_button_26.VerticalPadding = 6F
        ' 
        ' room_button_28
        ' 
        room_button_28.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_28.BevelStyle = Border3DStyle.SunkenOuter
        room_button_28.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_28.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_28.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_28.FlatStyle = FlatStyle.Flat
        room_button_28.Location = New Point(613, 512)
        room_button_28.Margin = New Padding(0)
        room_button_28.Name = "room_button_28"
        room_button_28.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_28.Size = New Size(200, 91)
        room_button_28.TabIndex = 3
        room_button_28.TextAlignment = StringAlignment.Near
        room_button_28.UseVisualStyleBackColor = False
        room_button_28.VerticalPadding = 6F
        ' 
        ' room_button_29
        ' 
        room_button_29.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_29.BevelStyle = Border3DStyle.SunkenOuter
        room_button_29.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_29.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_29.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_29.FlatStyle = FlatStyle.Flat
        room_button_29.Location = New Point(813, 512)
        room_button_29.Margin = New Padding(0)
        room_button_29.Name = "room_button_29"
        room_button_29.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_29.Size = New Size(200, 91)
        room_button_29.TabIndex = 3
        room_button_29.TextAlignment = StringAlignment.Near
        room_button_29.UseVisualStyleBackColor = False
        room_button_29.VerticalPadding = 6F
        ' 
        ' room_button_30
        ' 
        room_button_30.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_30.BevelStyle = Border3DStyle.SunkenOuter
        room_button_30.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_30.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_30.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_30.FlatStyle = FlatStyle.Flat
        room_button_30.Location = New Point(13, 603)
        room_button_30.Margin = New Padding(0)
        room_button_30.Name = "room_button_30"
        room_button_30.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_30.Size = New Size(200, 91)
        room_button_30.TabIndex = 3
        room_button_30.TextAlignment = StringAlignment.Near
        room_button_30.UseVisualStyleBackColor = False
        room_button_30.VerticalPadding = 6F
        ' 
        ' room_button_32
        ' 
        room_button_32.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_32.BevelStyle = Border3DStyle.SunkenOuter
        room_button_32.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_32.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_32.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_32.FlatStyle = FlatStyle.Flat
        room_button_32.Location = New Point(413, 603)
        room_button_32.Margin = New Padding(0)
        room_button_32.Name = "room_button_32"
        room_button_32.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_32.Size = New Size(200, 91)
        room_button_32.TabIndex = 3
        room_button_32.TextAlignment = StringAlignment.Near
        room_button_32.UseVisualStyleBackColor = False
        room_button_32.VerticalPadding = 6F
        ' 
        ' room_button_31
        ' 
        room_button_31.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_31.BevelStyle = Border3DStyle.SunkenOuter
        room_button_31.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_31.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_31.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_31.FlatStyle = FlatStyle.Flat
        room_button_31.Location = New Point(213, 603)
        room_button_31.Margin = New Padding(0)
        room_button_31.Name = "room_button_31"
        room_button_31.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_31.Size = New Size(200, 91)
        room_button_31.TabIndex = 3
        room_button_31.TextAlignment = StringAlignment.Near
        room_button_31.UseVisualStyleBackColor = False
        room_button_31.VerticalPadding = 6F
        ' 
        ' room_button_33
        ' 
        room_button_33.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_33.BevelStyle = Border3DStyle.SunkenOuter
        room_button_33.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_33.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_33.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_33.FlatStyle = FlatStyle.Flat
        room_button_33.Location = New Point(613, 603)
        room_button_33.Margin = New Padding(0)
        room_button_33.Name = "room_button_33"
        room_button_33.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_33.Size = New Size(200, 91)
        room_button_33.TabIndex = 3
        room_button_33.TextAlignment = StringAlignment.Near
        room_button_33.UseVisualStyleBackColor = False
        room_button_33.VerticalPadding = 6F
        ' 
        ' room_button_34
        ' 
        room_button_34.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_34.BevelStyle = Border3DStyle.SunkenOuter
        room_button_34.DisplayText = "00 ＊＊＊　＊＊" & vbLf & " 00:00～00:00　000分" & vbLf & "  0人( 00- 00)" & vbLf & " ＊"
        room_button_34.FirstLineFont = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        room_button_34.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        room_button_34.FlatStyle = FlatStyle.Flat
        room_button_34.Location = New Point(813, 603)
        room_button_34.Margin = New Padding(0)
        room_button_34.Name = "room_button_34"
        room_button_34.OtherLineFont = New Font("ＭＳ ゴシック", 10F, FontStyle.Bold)
        room_button_34.Size = New Size(200, 91)
        room_button_34.TabIndex = 3
        room_button_34.TextAlignment = StringAlignment.Near
        room_button_34.UseVisualStyleBackColor = False
        room_button_34.VerticalPadding = 6F
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
        menu_button_0.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        menu_button_0.BackgroundImageLayout = ImageLayout.None
        menu_button_0.Enabled = False
        menu_button_0.FlatStyle = FlatStyle.Popup
        menu_button_0.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_0.Location = New Point(122, 695)
        menu_button_0.Margin = New Padding(1)
        menu_button_0.Name = "menu_button_0"
        menu_button_0.Size = New Size(85, 63)
        menu_button_0.TabIndex = 0
        menu_button_0.Text = "＊＊＊＊" & vbCrLf & "＊＊＊＊"
        menu_button_0.UseVisualStyleBackColor = False
        ' 
        ' menu_button_1
        ' 
        menu_button_1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        menu_button_1.BackgroundImageLayout = ImageLayout.None
        menu_button_1.Enabled = False
        menu_button_1.FlatStyle = FlatStyle.Popup
        menu_button_1.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_1.Location = New Point(209, 695)
        menu_button_1.Margin = New Padding(1)
        menu_button_1.Name = "menu_button_1"
        menu_button_1.Size = New Size(85, 63)
        menu_button_1.TabIndex = 0
        menu_button_1.Text = "＊＊＊＊" & vbCrLf & "＊＊＊＊"
        menu_button_1.UseVisualStyleBackColor = False
        ' 
        ' menu_button_2
        ' 
        menu_button_2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        menu_button_2.BackgroundImageLayout = ImageLayout.None
        menu_button_2.Enabled = False
        menu_button_2.FlatStyle = FlatStyle.Popup
        menu_button_2.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_2.Location = New Point(296, 695)
        menu_button_2.Margin = New Padding(1)
        menu_button_2.Name = "menu_button_2"
        menu_button_2.Size = New Size(85, 63)
        menu_button_2.TabIndex = 0
        menu_button_2.Text = "＊＊＊＊" & vbCrLf & "＊＊＊＊"
        menu_button_2.UseVisualStyleBackColor = False
        ' 
        ' menu_button_3
        ' 
        menu_button_3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        menu_button_3.BackgroundImageLayout = ImageLayout.None
        menu_button_3.Enabled = False
        menu_button_3.FlatStyle = FlatStyle.Popup
        menu_button_3.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_3.Location = New Point(383, 695)
        menu_button_3.Margin = New Padding(1)
        menu_button_3.Name = "menu_button_3"
        menu_button_3.Size = New Size(85, 63)
        menu_button_3.TabIndex = 0
        menu_button_3.Text = "＊＊＊＊" & vbCrLf & "＊＊＊＊"
        menu_button_3.UseVisualStyleBackColor = False
        ' 
        ' menu_button_4
        ' 
        menu_button_4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        menu_button_4.BackgroundImageLayout = ImageLayout.None
        menu_button_4.Enabled = False
        menu_button_4.FlatStyle = FlatStyle.Popup
        menu_button_4.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_4.Location = New Point(470, 695)
        menu_button_4.Margin = New Padding(1)
        menu_button_4.Name = "menu_button_4"
        menu_button_4.Size = New Size(85, 63)
        menu_button_4.TabIndex = 0
        menu_button_4.Text = "＊＊＊＊" & vbCrLf & "＊＊＊＊"
        menu_button_4.UseVisualStyleBackColor = False
        ' 
        ' menu_button_5
        ' 
        menu_button_5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        menu_button_5.BackgroundImageLayout = ImageLayout.None
        menu_button_5.Enabled = False
        menu_button_5.FlatStyle = FlatStyle.Popup
        menu_button_5.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_5.Location = New Point(557, 695)
        menu_button_5.Margin = New Padding(1)
        menu_button_5.Name = "menu_button_5"
        menu_button_5.Size = New Size(85, 63)
        menu_button_5.TabIndex = 0
        menu_button_5.Text = "＊＊＊＊" & vbCrLf & "＊＊＊＊"
        menu_button_5.UseVisualStyleBackColor = False
        ' 
        ' menu_button_6
        ' 
        menu_button_6.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        menu_button_6.BackgroundImageLayout = ImageLayout.None
        menu_button_6.Enabled = False
        menu_button_6.FlatStyle = FlatStyle.Popup
        menu_button_6.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_6.Location = New Point(644, 695)
        menu_button_6.Margin = New Padding(1)
        menu_button_6.Name = "menu_button_6"
        menu_button_6.Size = New Size(85, 63)
        menu_button_6.TabIndex = 0
        menu_button_6.Text = "＊＊＊＊" & vbCrLf & "＊＊＊＊"
        menu_button_6.UseVisualStyleBackColor = False
        ' 
        ' menu_button_7
        ' 
        menu_button_7.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        menu_button_7.BackgroundImageLayout = ImageLayout.None
        menu_button_7.Enabled = False
        menu_button_7.FlatStyle = FlatStyle.Popup
        menu_button_7.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_7.Location = New Point(731, 695)
        menu_button_7.Margin = New Padding(1)
        menu_button_7.Name = "menu_button_7"
        menu_button_7.Size = New Size(85, 63)
        menu_button_7.TabIndex = 0
        menu_button_7.Text = "＊＊＊＊" & vbCrLf & "＊＊＊＊"
        menu_button_7.UseVisualStyleBackColor = False
        ' 
        ' menu_button_8
        ' 
        menu_button_8.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        menu_button_8.BackgroundImageLayout = ImageLayout.None
        menu_button_8.Enabled = False
        menu_button_8.FlatStyle = FlatStyle.Popup
        menu_button_8.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        menu_button_8.Location = New Point(818, 695)
        menu_button_8.Margin = New Padding(1)
        menu_button_8.Name = "menu_button_8"
        menu_button_8.Size = New Size(85, 63)
        menu_button_8.TabIndex = 0
        menu_button_8.Text = "＊＊＊＊" & vbCrLf & "＊＊＊＊"
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
        ' MainMenuForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1024, 768)
        Controls.Add(room_button_34)
        Controls.Add(room_button_4)
        Controls.Add(operation_week_label)
        Controls.Add(room_button_33)
        Controls.Add(operation_date_label)
        Controls.Add(room_button_3)
        Controls.Add(Label1)
        Controls.Add(room_button_29)
        Controls.Add(room_count_label)
        Controls.Add(room_button_1)
        Controls.Add(register_no_label)
        Controls.Add(room_button_28)
        Controls.Add(store_name_label)
        Controls.Add(room_button_2)
        Controls.Add(store_no_label)
        Controls.Add(room_button_24)
        Controls.Add(date_time_label)
        Controls.Add(room_button_0)
        Controls.Add(room_button_23)
        Controls.Add(menu_button_8)
        Controls.Add(room_button_19)
        Controls.Add(menu_button_7)
        Controls.Add(room_button_18)
        Controls.Add(menu_button_6)
        Controls.Add(room_button_31)
        Controls.Add(menu_button_5)
        Controls.Add(room_button_14)
        Controls.Add(menu_button_4)
        Controls.Add(room_button_26)
        Controls.Add(menu_button_3)
        Controls.Add(room_button_13)
        Controls.Add(menu_button_2)
        Controls.Add(room_button_21)
        Controls.Add(menu_button_1)
        Controls.Add(room_button_9)
        Controls.Add(menu_button_0)
        Controls.Add(room_button_16)
        Controls.Add(menu_next_button)
        Controls.Add(room_button_32)
        Controls.Add(menu_exit_button)
        Controls.Add(room_button_8)
        Controls.Add(room_button_5)
        Controls.Add(room_button_27)
        Controls.Add(room_button_10)
        Controls.Add(room_button_11)
        Controls.Add(room_button_7)
        Controls.Add(room_button_22)
        Controls.Add(room_button_15)
        Controls.Add(room_button_17)
        Controls.Add(room_button_20)
        Controls.Add(room_button_30)
        Controls.Add(room_button_12)
        Controls.Add(room_button_6)
        Controls.Add(room_button_25)
        FormBorderStyle = FormBorderStyle.None
        KeyPreview = True
        Margin = New Padding(1)
        Name = "MainMenuForm"
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
    Friend WithEvents room_button_1 As MultiLineButton
    Friend WithEvents room_button_2 As MultiLineButton
    Friend WithEvents room_button_3 As MultiLineButton
    Friend WithEvents room_button_4 As MultiLineButton
    Friend WithEvents room_button_5 As MultiLineButton
    Friend WithEvents room_button_7 As MultiLineButton
    Friend WithEvents room_button_6 As MultiLineButton
    Friend WithEvents room_button_8 As MultiLineButton
    Friend WithEvents room_button_9 As MultiLineButton
    Friend WithEvents room_button_10 As MultiLineButton
    Friend WithEvents room_button_12 As MultiLineButton
    Friend WithEvents room_button_11 As MultiLineButton
    Friend WithEvents room_button_13 As MultiLineButton
    Friend WithEvents room_button_14 As MultiLineButton
    Friend WithEvents room_button_15 As MultiLineButton
    Friend WithEvents room_button_17 As MultiLineButton
    Friend WithEvents room_button_16 As MultiLineButton
    Friend WithEvents room_button_18 As MultiLineButton
    Friend WithEvents room_button_19 As MultiLineButton
    Friend WithEvents room_button_20 As MultiLineButton
    Friend WithEvents room_button_22 As MultiLineButton
    Friend WithEvents room_button_21 As MultiLineButton
    Friend WithEvents room_button_23 As MultiLineButton
    Friend WithEvents room_button_24 As MultiLineButton
    Friend WithEvents room_button_25 As MultiLineButton
    Friend WithEvents room_button_27 As MultiLineButton
    Friend WithEvents room_button_26 As MultiLineButton
    Friend WithEvents room_button_28 As MultiLineButton
    Friend WithEvents room_button_29 As MultiLineButton
    Friend WithEvents room_button_30 As MultiLineButton
    Friend WithEvents room_button_32 As MultiLineButton
    Friend WithEvents room_button_31 As MultiLineButton
    Friend WithEvents room_button_33 As MultiLineButton
    Friend WithEvents room_button_34 As MultiLineButton
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
