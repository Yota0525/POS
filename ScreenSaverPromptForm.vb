''' スクリーンセーバー上で操作を検知した際に表示する小窓。
''' バーコードリーダーのコードスキャンを待機し、スキャンがあればOK、
''' 「閉じる」ボタンが押されればキャンセルとしてDialogResultを返す。
Public Class ScreenSaverPromptForm
    Inherits Form

    Private codeTextBox As TextBox
    Private closeButton As Button

    Public ReadOnly Property ScannedCode As String
        Get
            Return codeTextBox.Text
        End Get
    End Property

    Public Sub New()
        Me.Text = "画面ロック解除"
        Me.FormBorderStyle = FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ClientSize = New Size(360, 200)
        Me.TopMost = True ' スクリーンセーバー自体もTopMostのため、こちらも設定しないと裏に隠れてしまう

        codeTextBox = New TextBox() With {
            .Location = New Point(20, 20),
            .Width = 320,
            .Font = New Font("ＭＳ ゴシック", 12)
        }
        AddHandler codeTextBox.KeyDown, AddressOf CodeTextBox_KeyDown

        closeButton = New Button() With {
            .Text = "",
            .BackColor = Color.White,
            .Size = New Size(100, 40),
            .Location = New Point((Me.ClientSize.Width - 100) \ 2, 120),
            .FlatStyle = FlatStyle.Flat
        }
        AddHandler closeButton.Click, AddressOf CloseButton_Click

        Me.Controls.Add(codeTextBox)
        Me.Controls.Add(closeButton)

        AddHandler Me.Shown, Sub(s, e) codeTextBox.Focus()
    End Sub

    ''' バーコードリーダーはスキャン完了時にEnterキーを送出するのが一般的なため、それをスキャン完了の合図とする
    Private Sub CodeTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter AndAlso Not String.IsNullOrWhiteSpace(codeTextBox.Text) Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
