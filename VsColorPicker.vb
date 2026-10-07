Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms.Design

''' Visual Studioのプロパティウィンドウで色を指定する際と同じパレット
''' (カスタム / Web / システムの3タブ)をランタイムで表示するためのヘルパー。
Public Module VsColorPicker

    Private Class EditorService
        Implements IWindowsFormsEditorService

        Private dropDownHost As Form

        Public Sub CloseDropDown() Implements IWindowsFormsEditorService.CloseDropDown
            If dropDownHost IsNot Nothing Then
                dropDownHost.Close()
            End If
        End Sub

        Public Sub DropDownControl(control As Control) Implements IWindowsFormsEditorService.DropDownControl
            dropDownHost = New Form() With {
                .FormBorderStyle = FormBorderStyle.None,
                .StartPosition = FormStartPosition.Manual,
                .ShowInTaskbar = False,
                .TopMost = True
            }
            control.Dock = DockStyle.Fill
            dropDownHost.Controls.Add(control)
            dropDownHost.Size = control.Size
            dropDownHost.Location = Cursor.Position
            dropDownHost.ShowDialog()
        End Sub

        Public Function ShowDialog(dialog As Form) As DialogResult Implements IWindowsFormsEditorService.ShowDialog
            Return dialog.ShowDialog()
        End Function
    End Class

    ''' ColorEditor.EditValueが要求する最小限のITypeDescriptorContext実装
    Private Class EditorContext
        Implements ITypeDescriptorContext

        Private ReadOnly service As New EditorService()

        Public ReadOnly Property Container As IContainer Implements ITypeDescriptorContext.Container
            Get
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property Instance As Object Implements ITypeDescriptorContext.Instance
            Get
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property PropertyDescriptor As PropertyDescriptor Implements ITypeDescriptorContext.PropertyDescriptor
            Get
                Return Nothing
            End Get
        End Property

        Public Sub OnComponentChanged() Implements ITypeDescriptorContext.OnComponentChanged
        End Sub

        Public Function OnComponentChanging() As Boolean Implements ITypeDescriptorContext.OnComponentChanging
            Return True
        End Function

        Public Function GetService(serviceType As Type) As Object Implements IServiceProvider.GetService
            If serviceType Is GetType(IWindowsFormsEditorService) Then
                Return service
            End If
            Return Nothing
        End Function
    End Class

    ''' VSのプロパティウィンドウと同じ色選択パレットを表示する。
    ''' キャンセルされた場合はNothingを返す。
    Public Function PickColor(initial As Color) As Color?
        Dim editor As New ColorEditor()
        Dim context As New EditorContext()
        Dim result = editor.EditValue(context, context, initial)

        If TypeOf result Is Color Then
            Return CType(result, Color)
        End If
        Return Nothing
    End Function

End Module
