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
    Public Class MyBarAndDockingController
        Inherits BarAndDockingController

        Public Sub New(ByVal container As IContainer)
            MyBase.New(container)

        End Sub
        Public Sub New()

        End Sub
        Protected Overrides Sub RegisterPaintStyles()
            MyBase.RegisterPaintStyles()
            For i As Integer = 0 To PaintStyles.Count - 1
                PaintStyles(i).ItemInfoCollection.Add(New BarItemInfo("TableBarItem", "Table", 0, GetType(TableBarItem), GetType(BarButtonItemLink), GetType(BarButtonLinkViewInfo), PaintStyles(i).CreateButtonItemLinkPainter(), True, True))
            Next i
        End Sub
    End Class
End Namespace
