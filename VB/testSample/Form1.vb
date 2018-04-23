Imports Microsoft.VisualBasic
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
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			AddHandler tableBarItem1.TableClick, AddressOf tableBarItem1_TableClick
		End Sub
		Private Sub tableBarItem1_TableClick(ByVal sender As Object, ByVal e As CustomBarItem.TableEventArgs)
			MessageBox.Show("Size: " & e.SelectedSize)
		End Sub


	End Class
End Namespace
