''' スクリーンセーバー上で操作を検知した際に表示する小窓。
''' バーコードリーダーのコードスキャンを待機し、スキャンがあればOK、
''' 「閉じる」ボタンが押されればキャンセルとしてDialogResultを返す。
Public Class ScreenSaverPromptForm

    Public ReadOnly Property ScannedCode As String
        Get
            Return codeTextBox.Text
        End Get
    End Property

    Private Sub ScreenSaverPromptForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        codeTextBox.Focus()
    End Sub

    ''' バーコードリーダーはスキャン完了時にEnterキーを送出するのが一般的なため、それをスキャン完了の合図とする
    Private Sub CodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles codeTextBox.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not String.IsNullOrWhiteSpace(codeTextBox.Text) Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
