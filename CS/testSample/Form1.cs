using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Styles;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraBars.ViewInfo;

namespace testSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableBarItem1.TableClick += new TableBarItem.OnTableClickEventHandler(tableBarItem1_TableClick);
        }
        void tableBarItem1_TableClick(object sender, CustomBarItem.TableEventArgs e)
        {
            MessageBox.Show("Size: " + e.SelectedSize);           
        }

   
    }
}
