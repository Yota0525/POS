Public Class EnterRoomForm

    ''' 部屋番号を指定せずに開いた場合はNothing
    Public ReadOnly Property RoomNo As Integer?

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(roomNo As Integer)
        InitializeComponent()
        roomNo = roomNo
    End Sub

    Private Sub EnterRoomForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' 端末ごとに解像度が違うため、実際の画面サイズに確実に合わせる
        Me.Bounds = Screen.PrimaryScreen.Bounds
    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Me.Close()
    End Sub
End Class
