<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScreenSaverPromptForm
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
        codeTextBox = New TextBox()
        closeButton = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' codeTextBox
        ' 
        codeTextBox.Font = New Font("ＭＳ ゴシック", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        codeTextBox.Location = New Point(20, 46)
        codeTextBox.MaximumSize = New Size(320, 50)
        codeTextBox.MinimumSize = New Size(320, 50)
        codeTextBox.Name = "codeTextBox"
        codeTextBox.Size = New Size(320, 50)
        codeTextBox.TabIndex = 0
        ' 
        ' closeButton
        ' 
        closeButton.BackColor = Color.White
        closeButton.FlatStyle = FlatStyle.Flat
        closeButton.Location = New Point(144, 120)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(72, 68)
        closeButton.TabIndex = 1
        closeButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Silver
        Label1.Location = New Point(-10, -22)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(380, 50, 0, 0)
        Label1.Size = New Size(380, 65)
        Label1.TabIndex = 2
        ' 
        ' ScreenSaverPromptForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(360, 200)
        Controls.Add(Label1)
        Controls.Add(closeButton)
        Controls.Add(codeTextBox)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "ScreenSaverPromptForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "画面ロック解除"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents codeTextBox As TextBox
    Friend WithEvents closeButton As Button
    Friend WithEvents Label1 As Label

End Class
