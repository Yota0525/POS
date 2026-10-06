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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("ＭＳ ゴシック", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(11, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(300, 19)
        Label1.TabIndex = 2
        Label1.Text = "0000年00月00日 00時00分00秒"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(325, 11)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 16)
        Label2.TabIndex = 2
        Label2.Text = "0000"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.Yellow
        Label3.Location = New Point(382, 11)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(245, 16)
        Label3.TabIndex = 2
        Label3.Text = "カラオケまねきねこ河原町本店"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.Yellow
        Label4.Location = New Point(722, 12)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 16)
        Label4.TabIndex = 2
        Label4.Text = "00"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold Or FontStyle.Underline)
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label5.Location = New Point(11, 38)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(191, 16)
        Label5.TabIndex = 2
        Label5.Text = "営業設定日:0000/00/00"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold Or FontStyle.Underline)
        Label6.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label6.Location = New Point(206, 38)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 16)
        Label6.TabIndex = 2
        Label6.Text = "曜日区分:＊～＊"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("ＭＳ ゴシック", 12F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(875, 12)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(138, 16)
        Label7.TabIndex = 2
        Label7.Text = "稼働中:00 未:00"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1024, 768)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label

End Class
