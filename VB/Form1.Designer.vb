Imports Microsoft.VisualBasic
Imports System
Namespace PropertySorting
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
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.Size = New System.Drawing.Size(627, 490)
			Me.propertyGridControl1.TabIndex = 0
'			Me.propertyGridControl1.CustomPropertyDescriptors += New DevExpress.XtraVerticalGrid.Events.CustomPropertyDescriptorsEventHandler(Me.propertyGridControl1_CustomPropertyDescriptors);
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(13, 446)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(113, 32)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Toggle Sorting"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(627, 490)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.propertyGridControl1)
			Me.Name = "Form1"
			Me.Text = "Properties' Sorting"
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace

