''' 全画面・常に最前面で表示するスクリーンセーバー用フォーム。
''' キーボード/マウスいずれかの操作を検知すると自動的に閉じ、Dismissedイベントを発生させる。
Public Class ScreenSaverForm
    Inherits Form

    ''' 何らかの操作が検知されて閉じられたときに発生する
    Public Event Dismissed As EventHandler

    Public Sub New()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.BackColor = Color.Black
        Me.Cursor = Cursors.Default
        Me.KeyPreview = True
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.Manual

        AddHandler Me.KeyDown, AddressOf OnActivity
        AddHandler Me.MouseDown, AddressOf OnActivity
        AddHandler Me.MouseMove, AddressOf OnActivity
        AddHandler Me.MouseWheel, AddressOf OnActivity
    End Sub

    Private Sub OnActivity(sender As Object, e As EventArgs)
        RaiseEvent Dismissed(Me, EventArgs.Empty)
        Me.Close()
    End Sub

End Class
