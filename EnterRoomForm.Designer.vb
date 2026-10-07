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
        SuspendLayout()
        ' 
        ' backbutton
        ' 
        backbutton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        backbutton.FlatAppearance.BorderColor = Color.White
        backbutton.FlatAppearance.BorderSize = 2
        backbutton.FlatStyle = FlatStyle.Flat
        backbutton.Font = New Font("ÇlÇr ÉSÉVÉbÉN", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        backbutton.Location = New Point(549, 650)
        backbutton.Name = "backbutton"
        backbutton.Size = New Size(134, 78)
        backbutton.TabIndex = 0
        backbutton.Text = "ñﬂÅ@ÇÈ"
        backbutton.UseVisualStyleBackColor = False
        ' 
        ' EnterRoomForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1024, 768)
        Controls.Add(backbutton)
        FormBorderStyle = FormBorderStyle.None
        Name = "EnterRoomForm"
        StartPosition = FormStartPosition.Manual
        Text = "EnterRoomForm"
        TopMost = True
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
    End Sub

    Friend WithEvents backbutton As Button

End Class
