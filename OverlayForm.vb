''' 背面のメインウィンドウを透けたグレーアウト状態に見せるための全画面オーバーレイ。
''' 小窓(CashCountCheckFormなど)を表示する直前にShow、閉じた直後にCloseする想定。
Public Class OverlayForm
    Inherits Form

    Public Sub New()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.BackColor = Color.Black
        Me.Opacity = 0.8 ' 0.0(透明)〜1.0(不透明)。値を変えれば濃さを調整できる
        Me.ShowInTaskbar = False
        Me.TopMost = True
    End Sub

End Class
