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
Imports testSample.CustomBarItem

Namespace testSample
    Public Class TableBarItem
        Inherits BarButtonItem

        Public Sub New()
            AddHandler Me.MenuChanged, AddressOf TableBarItem_MenuChanged
            InitContainer()
        End Sub
        Public Overridable Sub TableBarItem_MenuChanged()
            InitContainer()
        End Sub
        Public Sub New(ByVal manager As BarManager, ByVal caption As String)
            MyBase.New(manager, caption)

        End Sub
        Public Sub New(ByVal manager As BarManager, ByVal caption As String, ByVal imageIndex As Integer)
            MyBase.New(manager, caption, imageIndex)

        End Sub
        Public Sub New(ByVal manager As BarManager, ByVal caption As String, ByVal imageIndex As Integer, ByVal shortcut As BarShortcut)
            MyBase.New(manager, caption, imageIndex, shortcut)

        End Sub
        Public Delegate Sub InitMenuChangedEventHander()
        Public Event MenuChanged As InitMenuChangedEventHander
        Public Property InnerPopupControl() As XtraUserControl
            Get
                Return _InnerPopupControl
            End Get
            Set(ByVal value As XtraUserControl)
                Dim OldValue = _InnerPopupControl
                If OldValue IsNot value Then
                    If Not DesignMode Then
                        value.Visible = False
                    End If
                    _InnerPopupControl = value
                    OnMenuChanged()
                End If
            End Set
        End Property
        Private _InnerPopupControl As XtraUserControl
        Public Delegate Sub OnTableClickEventHandler(ByVal sender As Object, ByVal e As TableEventArgs)
        Public Event TableClick As OnTableClickEventHandler
        Public container As TableSizePopupControlContainer
        Public Overrides Property ButtonStyle() As BarButtonStyle
            Get
                Return BarButtonStyle.DropDown
            End Get
            Set(ByVal value As BarButtonStyle)
            End Set
        End Property
        Public Overrides Property DropDownControl() As PopupControl
            Get
                Return container
            End Get
            Set(ByVal value As PopupControl)
            End Set
        End Property
        Public Overridable Sub InitContainer()
            If _InnerPopupControl IsNot Nothing Then
                container = New TableSizePopupControlContainer(_InnerPopupControl)
            Else
                container = New TableSizePopupControlContainer()
            End If
            RemoveHandler container.Click, AddressOf container_Click
            AddHandler container.Click, AddressOf container_Click
        End Sub
        Private Sub container_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim cntr As TableSizePopupControlContainer = TryCast(sender, TableSizePopupControlContainer)
            If cntr IsNot Nothing Then
                OnTableClick(sender, New TableEventArgs(cntr.Panel.Controls(0).Text))
            End If

        End Sub
        Public Overridable Sub OnMenuChanged()
            Dim handler As InitMenuChangedEventHander = MenuChangedEvent
            If handler IsNot Nothing Then
                handler()
            End If
        End Sub
        Protected Overridable Sub OnTableClick(ByVal sender As Object, ByVal e As TableEventArgs)
            Dim handler As OnTableClickEventHandler = TableClickEvent
            If handler IsNot Nothing Then
                handler(sender, e)
            End If
        End Sub

    End Class
End Namespace
