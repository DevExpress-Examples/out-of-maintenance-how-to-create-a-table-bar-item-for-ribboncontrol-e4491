using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testSample.CustomBarItem
{
    public class TableEventArgs : EventArgs
    {
        public TableEventArgs(string  selectedString)
        {
            _SelectedSize = selectedString;
        }
        //// Fields...
        private string _SelectedSize;
        public string SelectedSize
        {
            get { return _SelectedSize; }
            set { _SelectedSize = value; }
        }
    }
}
