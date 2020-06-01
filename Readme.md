<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to sort properties using the CustomPropertyDescriptors event


<p>This example shows how to display an object's properties in <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraVerticalGrid.PropertyGridControl">PropertyGridControl</a> in a custom order. Properties are sorted via the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraVerticalGrid.PropertyGridControl.CustomPropertyDescriptors">CustomPropertyDescriptors</a> event.</p><p>By default, properties are sorted according to their display names. To display properties in a custom order, the properties are sorted, and then the sorted collection is assigned to the event's Properties parameter.</p>

<br/>


