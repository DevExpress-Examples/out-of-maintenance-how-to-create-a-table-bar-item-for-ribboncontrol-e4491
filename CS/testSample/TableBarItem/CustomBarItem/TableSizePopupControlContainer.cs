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
    public class TableSizePopupControlContainer : SizeChooserPopupControlContainer
    {
        public TableSizePopupControlContainer()
        {
           
        }
        public TableSizePopupControlContainer(XtraUserControl control)
        {
            if (control != null)
                InitMenu(control);           
        }
         
        // Fields...   
        public virtual void InitMenu(XtraUserControl control)
        {
            XtraUserControl c1 = control;
            int height = 0;
            foreach (Control item2 in Panel.Controls)
            {
                if (item2 is LabelControl)
                {
                    item2.Dock = DockStyle.Top;
                    height = item2.Height;
                }
            }
            if (Width > control.Width)
            {
                c1.Location = new Point(InnerMargin * 2 + Width / 2 - c1.Width / 2, height * 2);
                c1.Visible = true;                
            }
            else
            {
                c1.Location = new Point(InnerMargin * 2 , height * 2);
                c1.Size = new Size(Width, control.Height);
                c1.Visible = true;                
            }
            foreach (Control item in c1.Controls)
            {
                item.Visible = true;
            }
            Panel.Controls.Add(c1);
            Panel.Visible = true;
            Visible = true;
            Panel.Height = height * 3 + control.Height;
        }
        public virtual void InitPanelButtons(int buttonsNumber)
        {
            int height = 0;
            foreach (Control item in Controls)
            {
                if (item is PanelControl)
                {
                    foreach (Control item2 in ((PanelControl)item).Controls)
                    {
                        if (item2 is LabelControl)
                        {
                            item2.Dock = DockStyle.Top;
                            height = item2.Height;
                        }
                    }
                    for (int i = 1; i <= buttonsNumber; i++)
                    {
                        SimpleButton sb1 = new SimpleButton() { Text = "Line" + i };
                        sb1.Size = new Size(item.Width, sb1.Height);
                        sb1.Location = new Point(InnerMargin * 2, height + sb1.Height * (i - 1) + 3 * i);
                        sb1.Appearance.TextOptions.VAlignment = VertAlignment.Center;
                        sb1.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
                        item.Controls.Add(sb1);
                    }
                    item.Height = height + item.Controls[1].Height * buttonsNumber + 3 * buttonsNumber + 10;
                }
            }
        }
        protected override int DefaultMaxPageRows { get { return 10; } }
        protected override int DefaultMaxPageColumns { get { return 10; } }
        protected override int DefaultPageColumns { get { return 10; } }
        protected override int DefaultPageRows { get { return 10; } }
        protected override int InnerMargin { get { return 3; } }
    }
}
