Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraBars.ViewInfo

Namespace testSample
    Public Class TableSizePopupControlContainer
        Inherits SizeChooserPopupControlContainer

        Public Sub New()

        End Sub
        Public Sub New(ByVal control As XtraUserControl)
            If control IsNot Nothing Then
                InitMenu(control)
            End If
        End Sub

        ' Fields...   
        Public Overridable Sub InitMenu(ByVal control As XtraUserControl)
            Dim c1 As XtraUserControl = control
            Dim height As Integer = 0
            For Each item2 As Control In Panel.Controls
                If TypeOf item2 Is LabelControl Then
                    item2.Dock = DockStyle.Top
                    height = item2.Height
                End If
            Next item2
            If Width > control.Width Then
                c1.Location = New Point(InnerMargin * 2 + Width / 2 - c1.Width \ 2, height * 2)
                c1.Visible = True
            Else
                c1.Location = New Point(InnerMargin * 2, height * 2)
                c1.Size = New Size(Width, control.Height)
                c1.Visible = True
            End If
            For Each item As Control In c1.Controls
                item.Visible = True
            Next item
            Panel.Controls.Add(c1)
            Panel.Visible = True
            Visible = True
            Panel.Height = height * 3 + control.Height
        End Sub
        Public Overridable Sub InitPanelButtons(ByVal buttonsNumber As Integer)
            Dim height As Integer = 0
            For Each item As Control In Controls
                If TypeOf item Is PanelControl Then
                    For Each item2 As Control In CType(item, PanelControl).Controls
                        If TypeOf item2 Is LabelControl Then
                            item2.Dock = DockStyle.Top
                            height = item2.Height
                        End If
                    Next item2
                    For i As Integer = 1 To buttonsNumber
                        Dim sb1 As New SimpleButton() With {.Text = "Line" & i}
                        sb1.Size = New Size(item.Width, sb1.Height)
                        sb1.Location = New Point(InnerMargin * 2, height + sb1.Height * (i - 1) + 3 * i)
                        sb1.Appearance.TextOptions.VAlignment = VertAlignment.Center
                        sb1.Appearance.TextOptions.HAlignment = HorzAlignment.Center
                        item.Controls.Add(sb1)
                    Next i
                    item.Height = height + item.Controls(1).Height * buttonsNumber + 3 * buttonsNumber + 10
                End If
            Next item
        End Sub
        Protected Overrides ReadOnly Property DefaultMaxPageRows() As Integer
            Get
                Return 10
            End Get
        End Property
        Protected Overrides ReadOnly Property DefaultMaxPageColumns() As Integer
            Get
                Return 10
            End Get
        End Property
        Protected Overrides ReadOnly Property DefaultPageColumns() As Integer
            Get
                Return 10
            End Get
        End Property
        Protected Overrides ReadOnly Property DefaultPageRows() As Integer
            Get
                Return 10
            End Get
        End Property
        Protected Overrides ReadOnly Property InnerMargin() As Integer
            Get
                Return 3
            End Get
        End Property
    End Class
End Namespace
