Imports Microsoft.VisualBasic
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
			Me.propertyGridControl1.SelectedObject = New CustomClass() With {.Property1 = "one", .Property2 = "two", .Property3 = "three", .Property4 = "four", .Property5 = "five"}
		End Sub

		Private Sub propertyGridControl1_CustomPropertyDescriptors(ByVal sender As Object, ByVal e As CustomPropertyDescriptorsEventArgs) Handles propertyGridControl1.CustomPropertyDescriptors
			If allowCustomSorting AndAlso e.Context.PropertyDescriptor Is Nothing Then
				e.Properties = e.Properties.Sort(New String() { "Property5", "Property4", "Property3", "Property2", "Property1" })
			End If
		End Sub
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			allowCustomSorting = Not allowCustomSorting
			propertyGridControl1.OptionsBehavior.PropertySort = If(allowCustomSorting, DevExpress.XtraVerticalGrid.PropertySort.NoSort, DevExpress.XtraVerticalGrid.PropertySort.Alphabetical)
			propertyGridControl1.Refresh()
			propertyGridControl1.RetrieveFields()
		End Sub
	End Class
	Friend Class CustomClass
		Private privateProperty1 As String
		<DisplayName("C")> _
		Public Property Property1() As String
			Get
				Return privateProperty1
			End Get
			Set(ByVal value As String)
				privateProperty1 = value
			End Set
		End Property
		Private privateProperty2 As String
		<DisplayName("B")> _
		Public Property Property2() As String
			Get
				Return privateProperty2
			End Get
			Set(ByVal value As String)
				privateProperty2 = value
			End Set
		End Property
		Private privateProperty3 As String
		<DisplayName("A")> _
		Public Property Property3() As String
			Get
				Return privateProperty3
			End Get
			Set(ByVal value As String)
				privateProperty3 = value
			End Set
		End Property
		Private privateProperty4 As String
		<DisplayName("D")> _
		Public Property Property4() As String
			Get
				Return privateProperty4
			End Get
			Set(ByVal value As String)
				privateProperty4 = value
			End Set
		End Property
		Private privateProperty5 As String
		<DisplayName("E")> _
		Public Property Property5() As String
			Get
				Return privateProperty5
			End Get
			Set(ByVal value As String)
				privateProperty5 = value
			End Set
		End Property
	End Class
End Namespace