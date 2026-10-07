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
        backbutton = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        registerbutton = New Button()
        TextBox4 = New TextBox()
        Label12 = New Label()
        ComboBox1 = New ComboBox()
        Label14 = New Label()
        TextBox11 = New TextBox()
        Button1 = New Button()
        Label6 = New Label()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label13 = New Label()
        TextBox13 = New TextBox()
        Label8 = New Label()
        ComboBox2 = New ComboBox()
        Label15 = New Label()
        ComboBox5 = New ComboBox()
        Label9 = New Label()
        ComboBox3 = New ComboBox()
        Label10 = New Label()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        Label11 = New Label()
        Label16 = New Label()
        ComboBox4 = New ComboBox()
        ComboBox6 = New ComboBox()
        TextBox10 = New TextBox()
        Button2 = New Button()
        TextBox12 = New TextBox()
        SuspendLayout()
        ' 
        ' backbutton
        ' 
        backbutton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        backbutton.FlatAppearance.BorderColor = Color.White
        backbutton.FlatAppearance.BorderSize = 2
        backbutton.FlatStyle = FlatStyle.Flat
        backbutton.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backbutton.Location = New Point(488, 692)
        backbutton.Name = "backbutton"
        backbutton.Size = New Size(122, 64)
        backbutton.TabIndex = 0
        backbutton.Text = "戻　る"
        backbutton.UseVisualStyleBackColor = False
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
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox1.Location = New Point(133, 280)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(88, 32)
        TextBox1.TabIndex = 2
        TextBox1.Text = "00:00"
        TextBox1.TextAlign = HorizontalAlignment.Center
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
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox2.Location = New Point(133, 45)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(303, 32)
        TextBox2.TabIndex = 2
        TextBox2.Text = "A1520080096099836B"
        TextBox2.TextAlign = HorizontalAlignment.Center
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
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox3.Location = New Point(133, 80)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(303, 32)
        TextBox3.TabIndex = 2
        TextBox3.Text = "レギュラー会員"
        TextBox3.TextAlign = HorizontalAlignment.Center
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
        ' registerbutton
        ' 
        registerbutton.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        registerbutton.FlatAppearance.BorderColor = Color.White
        registerbutton.FlatAppearance.BorderSize = 2
        registerbutton.FlatStyle = FlatStyle.Flat
        registerbutton.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        registerbutton.Location = New Point(8, 692)
        registerbutton.Name = "registerbutton"
        registerbutton.Size = New Size(122, 64)
        registerbutton.TabIndex = 0
        registerbutton.Text = "登　録"
        registerbutton.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox4.Location = New Point(339, 280)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(97, 32)
        TextBox4.TabIndex = 2
        TextBox4.Text = "00:00"
        TextBox4.TextAlign = HorizontalAlignment.Center
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
        ' ComboBox1
        ' 
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.Font = New Font("ＭＳ ゴシック", 16.5F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(133, 318)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(303, 30)
        ComboBox1.TabIndex = 3
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
        ' TextBox11
        ' 
        TextBox11.BorderStyle = BorderStyle.FixedSingle
        TextBox11.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox11.Location = New Point(133, 9)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(88, 32)
        TextBox11.TabIndex = 2
        TextBox11.Text = "00"
        TextBox11.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("ＭＳ ゴシック", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button1.Location = New Point(439, 80)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 32)
        Button1.TabIndex = 0
        Button1.Text = "備考"
        Button1.UseVisualStyleBackColor = False
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
        Label7.Text = "入室時間"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox5.Location = New Point(133, 354)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(97, 32)
        TextBox5.TabIndex = 2
        TextBox5.Text = "00:00"
        TextBox5.TextAlign = HorizontalAlignment.Center
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
        ' TextBox13
        ' 
        TextBox13.BorderStyle = BorderStyle.FixedSingle
        TextBox13.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox13.Location = New Point(323, 354)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(113, 32)
        TextBox13.TabIndex = 2
        TextBox13.Text = "可能"
        TextBox13.TextAlign = HorizontalAlignment.Center
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
        ' ComboBox2
        ' 
        ComboBox2.FlatStyle = FlatStyle.Flat
        ComboBox2.Font = New Font("ＭＳ ゴシック", 16.5F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(133, 392)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(266, 30)
        ComboBox2.TabIndex = 3
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
        ' ComboBox5
        ' 
        ComboBox5.FlatStyle = FlatStyle.Flat
        ComboBox5.Font = New Font("ＭＳ ゴシック", 16.5F)
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(133, 430)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(266, 30)
        ComboBox5.TabIndex = 3
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
        ' ComboBox3
        ' 
        ComboBox3.FlatStyle = FlatStyle.Flat
        ComboBox3.Font = New Font("ＭＳ ゴシック", 16.5F)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(133, 466)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(115, 30)
        ComboBox3.TabIndex = 3
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
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox6.Location = New Point(133, 502)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(152, 32)
        TextBox6.TabIndex = 2
        TextBox6.Text = "0"
        TextBox6.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox7.Location = New Point(286, 502)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(113, 32)
        TextBox7.TabIndex = 2
        TextBox7.Text = "0"
        TextBox7.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBox8
        ' 
        TextBox8.BorderStyle = BorderStyle.FixedSingle
        TextBox8.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox8.Location = New Point(400, 502)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(113, 32)
        TextBox8.TabIndex = 2
        TextBox8.Text = "0"
        TextBox8.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBox9
        ' 
        TextBox9.BorderStyle = BorderStyle.FixedSingle
        TextBox9.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox9.Location = New Point(514, 502)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(113, 32)
        TextBox9.TabIndex = 2
        TextBox9.Text = "0"
        TextBox9.TextAlign = HorizontalAlignment.Right
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
        ' ComboBox4
        ' 
        ComboBox4.FlatStyle = FlatStyle.Flat
        ComboBox4.Font = New Font("ＭＳ ゴシック", 16.5F)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(527, 392)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(266, 30)
        ComboBox4.TabIndex = 3
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FlatStyle = FlatStyle.Flat
        ComboBox6.Font = New Font("ＭＳ ゴシック", 16.5F)
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(527, 430)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(266, 30)
        ComboBox6.TabIndex = 3
        ' 
        ' TextBox10
        ' 
        TextBox10.BorderStyle = BorderStyle.FixedSingle
        TextBox10.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox10.Location = New Point(439, 45)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(184, 32)
        TextBox10.TabIndex = 2
        TextBox10.Text = "一般"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(154, 151)
        Button2.Name = "Button2"
        Button2.Size = New Size(122, 64)
        Button2.TabIndex = 0
        Button2.Text = "人数入力"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox12
        ' 
        TextBox12.BorderStyle = BorderStyle.FixedSingle
        TextBox12.Font = New Font("ＭＳ ゴシック", 18.5F)
        TextBox12.Location = New Point(433, 183)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(64, 32)
        TextBox12.TabIndex = 2
        TextBox12.Text = "一般"
        ' 
        ' EnterRoomForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1024, 768)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox6)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
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
        Controls.Add(Label3)
        Controls.Add(TextBox12)
        Controls.Add(TextBox10)
        Controls.Add(TextBox2)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox13)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label2)
        Controls.Add(TextBox11)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(registerbutton)
        Controls.Add(backbutton)
        FormBorderStyle = FormBorderStyle.None
        Name = "EnterRoomForm"
        StartPosition = FormStartPosition.Manual
        Text = "EnterRoomForm"
        TopMost = True
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents registerbutton As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox12 As TextBox

End Class
