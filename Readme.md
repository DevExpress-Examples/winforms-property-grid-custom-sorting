<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128639072/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2263)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Property Grid - Sort properties in a custom order

The WinForms Property Grid control sorts properties by display name. This example handles the [CustomPropertyDescriptors](https://docs.devexpress.com/WindowsForms/DevExpress.XtraVerticalGrid.PropertyGridControl.CustomPropertyDescriptors) event to sort object properties in a custom order:

```csharp
void propertyGridControl1_CustomPropertyDescriptors(object sender, CustomPropertyDescriptorsEventArgs e) {
    if(allowCustomSorting && e.Context.PropertyDescriptor == null) {
        e.Properties = e.Properties.Sort(new string[] { "Property5", "Property4", "Property3", "Property2", "Property1" });
    }
}
```


## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
