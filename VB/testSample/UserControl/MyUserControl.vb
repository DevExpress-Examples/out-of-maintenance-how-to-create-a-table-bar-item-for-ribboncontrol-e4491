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
    Public Class MyUserControl
        Inherits XtraUserControl

        Private simpleButton1 As SimpleButton
        Private simpleButton2 As SimpleButton
        Private simpleButton3 As SimpleButton

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.simpleButton1.Location = New System.Drawing.Point(3, 3)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(140, 20)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Line1"
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.simpleButton2.Location = New System.Drawing.Point(3, 32)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(140, 20)
            Me.simpleButton2.TabIndex = 1
            Me.simpleButton2.Text = "Line2"
            ' 
            ' simpleButton3
            ' 
            Me.simpleButton3.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.simpleButton3.Location = New System.Drawing.Point(3, 61)
            Me.simpleButton3.Name = "simpleButton3"
            Me.simpleButton3.Size = New System.Drawing.Size(140, 20)
            Me.simpleButton3.TabIndex = 2
            Me.simpleButton3.Text = "Line3"
            ' 
            ' MyUserControl
            ' 
            Me.Controls.Add(Me.simpleButton3)
            Me.Controls.Add(Me.simpleButton2)
            Me.Controls.Add(Me.simpleButton1)
            Me.Name = "MyUserControl"
            Me.Size = New System.Drawing.Size(146, 97)
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace
