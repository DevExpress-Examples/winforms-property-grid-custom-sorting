Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid.Events
Imports System.Collections
Imports System.Globalization

Namespace PropertySorting
	Partial Public Class Form1
		Inherits Form

		Private allowCustomSorting As Boolean = False

		Public Sub New()
			InitializeComponent()
			Me.propertyGridControl1.SelectedObject = New CustomClass() With {
				.Property1 = "one",
				.Property2 = "two",
				.Property3 = "three",
				.Property4 = "four",
				.Property5 = "five"
			}
		End Sub

		Private Sub propertyGridControl1_CustomPropertyDescriptors(ByVal sender As Object, ByVal e As CustomPropertyDescriptorsEventArgs) Handles propertyGridControl1.CustomPropertyDescriptors
			If allowCustomSorting AndAlso e.Context.PropertyDescriptor Is Nothing Then
				e.Properties = e.Properties.Sort(New String() { "Property5", "Property4", "Property3", "Property2", "Property1" })
			End If
		End Sub
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If Not Me.button1.IsHandleCreated Then Return

			allowCustomSorting = Not allowCustomSorting
			propertyGridControl1.OptionsBehavior.PropertySort = If(allowCustomSorting, DevExpress.XtraVerticalGrid.PropertySort.NoSort, DevExpress.XtraVerticalGrid.PropertySort.Alphabetical)
			propertyGridControl1.Refresh()
		End Sub
	End Class
	Friend Class CustomClass
		<DisplayName("C")>
		Public Property Property1() As String
		<DisplayName("B")>
		Public Property Property2() As String
		<DisplayName("A")>
		Public Property Property3() As String
		<DisplayName("D")>
		Public Property Property4() As String
		<DisplayName("E")>
		Public Property Property5() As String
	End Class
End Namespace