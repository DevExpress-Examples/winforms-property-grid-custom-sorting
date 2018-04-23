using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid.Events;
using System.Collections;
using System.Globalization;

namespace PropertySorting {
    public partial class Form1 : Form {
        bool allowCustomSorting;

        public Form1() {
            InitializeComponent();
            this.propertyGridControl1.SelectedObject = new CustomClass() { Property1 = "one", Property2 = "two", Property3 = "three", Property4 = "four", Property5 = "five" };
        }

        void propertyGridControl1_CustomPropertyDescriptors(object sender, CustomPropertyDescriptorsEventArgs e) {
            if(allowCustomSorting && e.Context.PropertyDescriptor == null) {
                e.Properties = e.Properties.Sort(new string[] { "Property5", "Property4", "Property3", "Property2", "Property1" });
            }
        }
        void button1_Click(object sender, EventArgs e) {
            allowCustomSorting = !allowCustomSorting;
            propertyGridControl1.Refresh();
            propertyGridControl1.RetrieveFields();
        }
    }
    class CustomClass {
        [DisplayName("C")]
        public string Property1 { get; set; }
        [DisplayName("B")]
        public string Property2 { get; set; }
        [DisplayName("A")]
        public string Property3 { get; set; }
        [DisplayName("D")]
        public string Property4 { get; set; }
        [DisplayName("E")]
        public string Property5 { get; set; }
    }
}