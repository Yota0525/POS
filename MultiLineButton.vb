Imports System.ComponentModel
Imports System.Linq

Public Class MultiLineButton
    Inherits Button

    Public Class LineItem
        Public Property Text As String
        Public Property Font As Font

        Public Sub New(text As String, font As Font)
            Me.Text = text
            Me.Font = font
        End Sub
    End Class

    ' Listはデザイナーが正しくシリアライズできないため、デザイナー上では非表示にする。
    ' 代わりにDisplayText（単純な文字列プロパティ）経由で設定・保存する。
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <Browsable(False)>
    Public Property Lines As New List(Of LineItem)
    Public Property TextAlignment As StringAlignment = StringAlignment.Center
    Public Property VerticalPadding As Single = 6.0F

    Public Property FirstLineFont As New Font("ＭＳ ゴシック", 12, FontStyle.Bold)
    Public Property OtherLineFont As New Font("ＭＳ ゴシック", 10, FontStyle.Bold)

    Public Sub New()
        Me.Text = "" ' 標準のテキスト描画は使わず、Linesを自前で描画する
    End Sub

    ''' 改行区切りの1つの文字列からLinesを組み立てる（1行目=FirstLineFont、2行目以降=OtherLineFont）
    Public Property DisplayText As String
        Get
            Return String.Join(vbLf, Lines.Select(Function(l) l.Text))
        End Get
        Set(value As String)
            Lines.Clear()
            Dim normalized = value.Replace("\n", vbLf).Replace(vbCrLf, vbLf).Replace(vbCr, vbLf)
            Dim parts = normalized.Split(vbLf)
            For i = 0 To parts.Length - 1
                Dim f = If(i = 0, FirstLineFont, OtherLineFont)
                Lines.Add(New LineItem(parts(i), f))
            Next
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e) ' 背景・枠は標準描画のまま使う

        If Lines.Count = 0 Then Return

        Dim g = e.Graphics
        Dim sf As New StringFormat With {.Alignment = TextAlignment}

        Using brush As New SolidBrush(Me.ForeColor)
            Dim heights(Lines.Count - 1) As Single
            Dim totalHeight As Single = 0
            For i = 0 To Lines.Count - 1
                heights(i) = Lines(i).Font.GetHeight(g)
                totalHeight += heights(i)
            Next

            If Lines.Count = 1 Then
                Dim y As Single = (Me.Height - heights(0)) / 2
                g.DrawString(Lines(0).Text, Lines(0).Font, brush, New RectangleF(0, y, Me.Width, heights(0)), sf)
                Return
            End If

            ' 上下にVerticalPadding分の余白を確保し、その内側で行間を均等配分する
            Dim availableHeight As Single = Me.Height - (VerticalPadding * 2)
            Dim gap As Single = (availableHeight - totalHeight) / (Lines.Count - 1)

            Dim yPos As Single = VerticalPadding
            For i = 0 To Lines.Count - 1
                g.DrawString(Lines(i).Text, Lines(i).Font, brush, New RectangleF(0, yPos, Me.Width, heights(i)), sf)
                yPos += heights(i) + gap
            Next
        End Using
    End Sub
End Class
