''' 全画面・常に最前面で表示するスクリーンセーバー用フォーム。
''' キーボード/マウスいずれかの操作を検知すると自動的に閉じ、Dismissedイベントを発生させる。
Public Class ScreenSaverForm
    Inherits Form

    ''' 何らかの操作が検知されて閉じられたときに発生する
    Public Event Dismissed As EventHandler

    ' 表示直後にカーソルが置かれている位置。実際に動いた距離を判定するための基準点
    Private initialCursorPos As Point
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents info_label As Label
    Friend WithEvents desc_label As Label

    ' この距離(px)以上カーソルが動かない限り、表示直後のマウス座標更新を「操作」とみなさない
    Private Const MouseMoveThreshold As Integer = 5

    ' 小窓を表示中に別の操作イベントで二重に開いてしまうのを防ぐためのフラグ
    Private isPromptOpen As Boolean = False

    Public Sub New()
        InitializeComponent()

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Bounds = Screen.PrimaryScreen.Bounds
        Me.TopMost = True
        Me.Cursor = Cursors.Default
        Me.KeyPreview = True
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.Manual

        AddHandler Me.Shown, AddressOf ScreenSaverForm_Shown
        AddHandler Me.KeyDown, AddressOf OnActivity
        AddHandler Me.MouseDown, AddressOf OnActivity
        AddHandler Me.MouseMove, AddressOf OnMouseMoveActivity
        AddHandler Me.MouseWheel, AddressOf OnActivity

        ' PictureBoxやLabelなど子コントロールの上でのクリック/移動はフォームまで伝わらないため、
        ' 配置されている全ての子コントロールにも同じイベントを再帰的に仕込む
        For Each child As Control In Me.Controls
            HookChildActivity(child)
        Next
    End Sub

    Private Sub HookChildActivity(ctrl As Control)
        ' Clickも仕込むとMouseDownと二重に発火して小窓が連続で開いてしまうため、MouseDownのみにする
        AddHandler ctrl.MouseDown, AddressOf OnActivity
        AddHandler ctrl.MouseMove, AddressOf OnMouseMoveActivity
        AddHandler ctrl.MouseWheel, AddressOf OnActivity

        For Each grandChild As Control In ctrl.Controls
            HookChildActivity(grandChild)
        Next
    End Sub

    Private Sub ScreenSaverForm_Shown(sender As Object, e As EventArgs)
        ' 表示直後のカーソル位置を基準点として記録する
        initialCursorPos = Cursor.Position
    End Sub

    ''' 表示された瞬間、カーソルがその場にあるだけで発生する見かけ上のMouseMoveを無視するため、
    ''' 基準点から一定距離動いた場合のみ「操作があった」とみなす
    Private Sub OnMouseMoveActivity(sender As Object, e As MouseEventArgs)
        Dim current = Cursor.Position
        Dim dx = Math.Abs(current.X - initialCursorPos.X)
        Dim dy = Math.Abs(current.Y - initialCursorPos.Y)
        If dx > MouseMoveThreshold OrElse dy > MouseMoveThreshold Then
            OnActivity(sender, e)
        End If
    End Sub

    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        info_label = New Label()
        desc_label = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.EmiG3cvU8AAILk_
        PictureBox1.Location = New Point(51, 109)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(948, 521)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' info_label
        ' 
        info_label.AutoSize = True
        info_label.Font = New Font("ＭＳ ゴシック", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        info_label.ForeColor = Color.Black
        info_label.Location = New Point(367, 52)
        info_label.Name = "info_label"
        info_label.Size = New Size(290, 37)
        info_label.TabIndex = 1
        info_label.Text = "画面をロック中"
        ' 
        ' desc_label
        ' 
        desc_label.AutoSize = True
        desc_label.Font = New Font("ＭＳ ゴシック", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        desc_label.ForeColor = Color.Black
        desc_label.Location = New Point(244, 665)
        desc_label.Name = "desc_label"
        desc_label.Size = New Size(536, 48)
        desc_label.TabIndex = 1
        desc_label.Text = "画面ロックの解除は画面をタップしてから、" & vbCrLf & "従業員コードをQRリーダーにかざしてください"
        ' 
        ' ScreenSaverForm
        ' 
        BackColor = SystemColors.Control
        ClientSize = New Size(1024, 768)
        Controls.Add(desc_label)
        Controls.Add(info_label)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        KeyPreview = True
        Name = "ScreenSaverForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        TopMost = True
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    ''' 操作を検知したら即座には閉じず、バーコードスキャン待機用の小窓を開く。
    ''' 小窓で「閉じる」が押された場合はスクリーンセーバー状態に戻り、
    ''' コードがスキャンされた場合のみスクリーンセーバーごと閉じて元の画面に戻る。
    Private Sub OnActivity(sender As Object, e As EventArgs)
        If isPromptOpen Then Return
        isPromptOpen = True
        Try
            Using prompt As New ScreenSaverPromptForm()
                Dim result = prompt.ShowDialog(Me)
                If result = DialogResult.OK Then
                    RaiseEvent Dismissed(Me, EventArgs.Empty)
                    Me.Close()
                Else
                    ' キャンセルの場合は、次の操作を正しく検知できるよう基準点を現在位置にリセットする
                    initialCursorPos = Cursor.Position
                End If
            End Using
        Finally
            isPromptOpen = False
        End Try
    End Sub

End Class
