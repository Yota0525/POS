Public Class Form1

    ' デザイナーで配置した時の基準サイズ（Form1.Designer.vb の ClientSize と合わせる）
    Private ReadOnly DesignSize As New Size(1024, 768)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' 端末ごとに解像度が違うため、配置はそのままに実際の画面サイズへ拡大・縮小する
        Dim targetSize As Size = Screen.PrimaryScreen.Bounds.Size
        Dim scaleFactor As New SizeF(
            targetSize.Width / CSng(DesignSize.Width),
            targetSize.Height / CSng(DesignSize.Height))

        ScaleControls(Me, scaleFactor)

        Me.Bounds = Screen.PrimaryScreen.Bounds
    End Sub

    ' コントロールの位置・サイズ・フォントを指定倍率で再帰的に拡大縮小する
    Private Sub ScaleControls(parent As Control, factor As SizeF)
        For Each ctrl As Control In parent.Controls
            ctrl.Left = CInt(Math.Round(ctrl.Left * factor.Width))
            ctrl.Top = CInt(Math.Round(ctrl.Top * factor.Height))
            ctrl.Width = CInt(Math.Round(ctrl.Width * factor.Width))
            ctrl.Height = CInt(Math.Round(ctrl.Height * factor.Height))

            Dim avgFactor As Single = (factor.Width + factor.Height) / 2.0F
            ctrl.Font = New Font(ctrl.Font.FontFamily, ctrl.Font.Size * avgFactor, ctrl.Font.Style)

            Dim multiLineBtn = TryCast(ctrl, MultiLineButton)
            If multiLineBtn IsNot Nothing Then
                For Each line In multiLineBtn.Lines
                    line.Font = New Font(line.Font.FontFamily, line.Font.Size * avgFactor, line.Font.Style)
                Next
            End If

            If ctrl.Controls.Count > 0 Then
                ScaleControls(ctrl, factor)
            End If
        Next
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Alt+F4やタスクバー経由の終了操作を無効化し、業務フローからの明示的な終了のみ許可する
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub exit_button_Click(sender As Object, e As EventArgs) Handles menu_exit_button.Click
        Application.Exit()
    End Sub

    Private Sub date_time_timer_Tick(sender As Object, e As EventArgs) Handles date_time_timer.Tick
        Dim now_time As DateTime

        now_time = DateTime.Now
        date_time_label.Text = Format(now_time, "yyyy年MM月dd日 HH時mm分ss秒")
    End Sub
End Class
