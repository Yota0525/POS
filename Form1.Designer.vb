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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' exit_button
        ' 
        exit_button.BackColor = Color.White
        exit_button.BackgroundImageLayout = ImageLayout.None
        exit_button.FlatStyle = FlatStyle.Popup
        exit_button.Location = New Point(65, 73)
        exit_button.Margin = New Padding(1)
        exit_button.Name = "exit_button"
        exit_button.Size = New Size(95, 53)
        exit_button.TabIndex = 0
        exit_button.Text = "終了"
        exit_button.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(286, 73)
        Button1.Margin = New Padding(1)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 41)
        Button1.TabIndex = 1
        Button1.Text = "flat"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(286, 125)
        Button2.Margin = New Padding(1)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 41)
        Button2.TabIndex = 1
        Button2.Text = "popup"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Location = New Point(286, 184)
        Button3.Margin = New Padding(1)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 41)
        Button3.TabIndex = 1
        Button3.Text = "standard"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.FlatStyle = FlatStyle.System
        Button4.Location = New Point(286, 241)
        Button4.Margin = New Padding(1)
        Button4.Name = "Button4"
        Button4.Size = New Size(87, 41)
        Button4.TabIndex = 1
        Button4.Text = "system"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("ＭＳ ゴシック", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(13, 12)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 17)
        Label1.TabIndex = 2
        Label1.Text = "0000年00月00日 00時00分00秒"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("ＭＳ ゴシック", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(265, 12)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 17)
        Label2.TabIndex = 2
        Label2.Text = "0000"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("ＭＳ ゴシック", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ForeColor = Color.Yellow
        Label3.Location = New Point(314, 12)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(274, 17)
        Label3.TabIndex = 2
        Label3.Text = "カラオケまねきねこ河原町本店"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1024, 768)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
