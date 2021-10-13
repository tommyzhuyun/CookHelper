using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XmlReader.Data
{
    public class DynamicControl : Form
    {
        public Control ControlOwner;

        public DynamicControl(Control control)
        {
            ControlOwner = control;
        }

    }
}
