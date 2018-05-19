Imports Microsoft.VisualBasic
Imports System
Namespace q141275
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
			Me.myLayoutControl1 = New DXSample.MyLayoutControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			CType(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myLayoutControl1.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myLayoutControl1
			' 
			Me.myLayoutControl1.Controls.Add(Me.textEdit2)
			Me.myLayoutControl1.Controls.Add(Me.textEdit1)
			Me.myLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myLayoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControl1.LookAndFeel.SkinName = "Money Twins"
			Me.myLayoutControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.myLayoutControl1.Name = "myLayoutControl1"
			Me.myLayoutControl1.Root = Me.layoutControlGroup1
			Me.myLayoutControl1.Size = New System.Drawing.Size(197, 335)
			Me.myLayoutControl1.TabIndex = 0
			Me.myLayoutControl1.Text = "myLayoutControl1"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlGroup2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(197, 335)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(106, 8)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(84, 20)
			Me.textEdit1.StyleController = Me.myLayoutControl1
			Me.textEdit1.TabIndex = 4
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.textEdit1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(193, 31)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(93, 20)
			' 
			' textEdit2
			' 
			Me.textEdit2.Location = New System.Drawing.Point(110, 61)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Size = New System.Drawing.Size(76, 20)
			Me.textEdit2.StyleController = Me.myLayoutControl1
			Me.textEdit2.TabIndex = 5
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.textEdit2
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(185, 272)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(93, 20)
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
			Me.layoutControlGroup2.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutControlGroup2.ExpandButtonVisible = True
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 31)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(193, 299)
			Me.layoutControlGroup2.Text = "layoutControlGroup2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(197, 335)
			Me.Controls.Add(Me.myLayoutControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myLayoutControl1.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myLayoutControl1 As DXSample.MyLayoutControl
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
	End Class
End Namespace

