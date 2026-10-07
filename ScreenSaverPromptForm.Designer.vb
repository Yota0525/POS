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
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' codeTextBox
        ' 
        codeTextBox.BorderStyle = BorderStyle.FixedSingle
        codeTextBox.Font = New Font("ＭＳ ゴシック", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        codeTextBox.Location = New Point(227, 156)
        codeTextBox.Margin = New Padding(0)
        codeTextBox.MaximumSize = New Size(0, 29)
        codeTextBox.MinimumSize = New Size(0, 29)
        codeTextBox.Name = "codeTextBox"
        codeTextBox.Size = New Size(224, 29)
        codeTextBox.TabIndex = 0
        ' 
        ' closeButton
        ' 
        closeButton.BackColor = Color.White
        closeButton.Font = New Font("ＭＳ ゴシック", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        closeButton.Location = New Point(212, 230)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(170, 68)
        closeButton.TabIndex = 1
        closeButton.Text = "戻る"
        closeButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(31, 34)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(20, 40, 20, 40)
        Label1.Size = New Size(532, 106)
        Label1.TabIndex = 2
        Label1.Text = "担当者バーコードをスキャンしてください。"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("ＭＳ ゴシック", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(126, 156)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(10, 3, 10, 3)
        Label2.Size = New Size(101, 29)
        Label2.TabIndex = 3
        Label2.Text = "担当者"
        ' 
        ' ScreenSaverPromptForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(595, 328)
        Controls.Add(Label2)
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
    Friend WithEvents Label2 As Label

End Class
