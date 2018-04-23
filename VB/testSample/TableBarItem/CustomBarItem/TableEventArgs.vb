Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace testSample.CustomBarItem
	Public Class TableEventArgs
		Inherits EventArgs
		Public Sub New(ByVal selectedString As String)
			_SelectedSize = selectedString
		End Sub
		'// Fields...
		Private _SelectedSize As String
		Public Property SelectedSize() As String
			Get
				Return _SelectedSize
			End Get
			Set(ByVal value As String)
				_SelectedSize = value
			End Set
		End Property
	End Class
End Namespace
