Public Class CashCountCheckForm

    ''' 表示元で生成したOverlayFormを受け取っておき、閉じるときに自分で閉じる
    Public Property OverlayToClose As Form

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        If OverlayToClose IsNot Nothing Then OverlayToClose.Close()

        Me.Close()
    End Sub

    ''' row_1〜row_8は表示専用のため、ReadOnlyは使わずキー入力自体をブロックする。
    ''' (ReadOnly=Trueだと環境によってForeColorが無視され黒で表示されてしまうため)
    Private Sub RowTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles row_1.KeyPress, row_2.KeyPress, row_3.KeyPress, row_4.KeyPress, row_5.KeyPress, row_6.KeyPress, row_7.KeyPress, row_8.KeyPress
        e.Handled = True
    End Sub

    ''' Ctrl+V(貼り付け)もブロックする
    Private Sub RowTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles row_1.KeyDown, row_2.KeyDown, row_3.KeyDown, row_4.KeyDown, row_5.KeyDown, row_6.KeyDown, row_7.KeyDown, row_8.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            e.SuppressKeyPress = True
        End If
    End Sub

End Class
