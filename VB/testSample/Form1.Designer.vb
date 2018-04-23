Imports Microsoft.VisualBasic
Imports System
Namespace testSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.myBarAndDockingController1 = New testSample.MyBarAndDockingController(Me.components)
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.tableBarItem1 = New testSample.TableBarItem()
			Me.myUserControl5 = New testSample.MyUserControl()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.myUserControl4 = New testSample.MyUserControl()
			Me.myUserControl2 = New testSample.MyUserControl()
			Me.myUserControl1 = New testSample.MyUserControl()
			Me.myUserControl3 = New testSample.MyUserControl()
			CType(Me.myBarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.Controller = Me.myBarAndDockingController1
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.tableBarItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 3
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.Size = New System.Drawing.Size(545, 142)
			' 
			' tableBarItem1
			' 
			Me.tableBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.tableBarItem1.Caption = "Table"
			Me.tableBarItem1.Id = 1
			Me.tableBarItem1.InnerPopupControl = Me.myUserControl2
			Me.tableBarItem1.LargeGlyph = (CType(resources.GetObject("tableBarItem1.LargeGlyph"), System.Drawing.Image))
			Me.tableBarItem1.Name = "tableBarItem1"
			Me.tableBarItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
			' 
			' myUserControl5
			' 
			Me.myUserControl5.Location = New System.Drawing.Point(33, 26)
			Me.myUserControl5.Name = "myUserControl5"
			Me.myUserControl5.Size = New System.Drawing.Size(146, 97)
			Me.myUserControl5.TabIndex = 1
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "InsertTable"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.tableBarItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "TableGroup"
			' 
			' myUserControl4
			' 
			Me.myUserControl4.Location = New System.Drawing.Point(33, 26)
			Me.myUserControl4.Name = "myUserControl4"
			Me.myUserControl4.Size = New System.Drawing.Size(146, 97)
			Me.myUserControl4.TabIndex = 1
			' 
			' myUserControl2
			' 
			Me.myUserControl2.Location = New System.Drawing.Point(33, 26)
			Me.myUserControl2.Name = "myUserControl2"
			Me.myUserControl2.Size = New System.Drawing.Size(146, 97)
			Me.myUserControl2.TabIndex = 1
			' 
			' myUserControl1
			' 
			Me.myUserControl1.Location = New System.Drawing.Point(33, 26)
			Me.myUserControl1.Name = "myUserControl1"
			Me.myUserControl1.Size = New System.Drawing.Size(146, 97)
			Me.myUserControl1.TabIndex = 1
			' 
			' myUserControl3
			' 
			Me.myUserControl3.Location = New System.Drawing.Point(33, 26)
			Me.myUserControl3.Name = "myUserControl3"
			Me.myUserControl3.Size = New System.Drawing.Size(146, 97)
			Me.myUserControl3.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(545, 446)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myBarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myBarAndDockingController1 As MyBarAndDockingController
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private tableBarItem1 As TableBarItem
		Private myUserControl1 As MyUserControl
		Private myUserControl2 As MyUserControl
		Private myUserControl3 As MyUserControl
		Private myUserControl4 As MyUserControl
		Private myUserControl5 As MyUserControl








	End Class
End Namespace

