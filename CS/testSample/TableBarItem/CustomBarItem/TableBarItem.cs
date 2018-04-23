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
using testSample.CustomBarItem;

namespace testSample
{
    public class TableBarItem : BarButtonItem
    {
        public TableBarItem()
        { 
            MenuChanged += new InitMenuChangedEventHander(TableBarItem_MenuChanged);
            InitContainer();  
        }
        public virtual void TableBarItem_MenuChanged()
        {           
            InitContainer();            
        }
        public TableBarItem(BarManager manager, string caption)
            : base(manager, caption)
        {

        }
        public TableBarItem(BarManager manager, string caption, int imageIndex)
            : base(manager, caption, imageIndex)
        {

        }
        public TableBarItem(BarManager manager, string caption, int imageIndex, BarShortcut shortcut)
            : base(manager, caption, imageIndex, shortcut)
        {

        }
        public delegate void InitMenuChangedEventHander();
        public event InitMenuChangedEventHander MenuChanged;
        public XtraUserControl InnerPopupControl
        {
            get { return _InnerPopupControl; }
            set {
                var OldValue = _InnerPopupControl;              
                if (OldValue != value)
                {
                    if (!DesignMode)
                        value.Visible = false;
                    _InnerPopupControl = value;                    
                    OnMenuChanged();
                }
            }
        }
        private XtraUserControl _InnerPopupControl;
        public delegate void OnTableClickEventHandler(object sender, TableEventArgs e);
        public event OnTableClickEventHandler TableClick;
        public TableSizePopupControlContainer container;
        public override BarButtonStyle ButtonStyle { get { return BarButtonStyle.DropDown; } set { } }
        public override PopupControl DropDownControl { get { return container; } set { } }
        public virtual void InitContainer()
        {
            if (_InnerPopupControl != null)
            {
                container = new TableSizePopupControlContainer(_InnerPopupControl);
            }
            else
            {
                container = new TableSizePopupControlContainer();
            }
            container.Click -= new EventHandler(container_Click);
            container.Click += new EventHandler(container_Click);  
        }
        void container_Click(object sender, EventArgs e)
        {
            TableSizePopupControlContainer cntr = sender as TableSizePopupControlContainer;
            if (cntr != null)
                OnTableClick(sender, new TableEventArgs(cntr.Panel.Controls[0].Text));

        }
        public virtual void OnMenuChanged()
        {
            InitMenuChangedEventHander handler = MenuChanged;
            if (handler != null)
                handler();
        }
        protected virtual void OnTableClick(object sender, TableEventArgs e)
        {
            OnTableClickEventHandler handler = TableClick;
            if (handler != null)
                handler(sender, e);
        }
     
    }
}
