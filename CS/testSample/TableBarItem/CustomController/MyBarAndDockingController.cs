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
    public class MyBarAndDockingController : BarAndDockingController
    {
        public MyBarAndDockingController(IContainer container)
            : base(container)
        {
            
        }
        public MyBarAndDockingController()
        {
         
        }
        protected override void RegisterPaintStyles()
        {
            base.RegisterPaintStyles();
            for (int i = 0; i < PaintStyles.Count; i++)
            {
                PaintStyles[i].ItemInfoCollection.Add(new BarItemInfo("TableBarItem", "Table", 0, typeof(TableBarItem), typeof(BarButtonItemLink), typeof(BarButtonLinkViewInfo), PaintStyles[i].CreateButtonItemLinkPainter(), true, true));
            }
        }
    }
}
