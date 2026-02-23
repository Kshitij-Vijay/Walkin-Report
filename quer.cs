using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walkin_Report
{
    public partial class quer : UserControl
    {
        public quer(string parameter, string keyword)
        {
            InitializeComponent();
            para_label.Text = parameter;
            key_label.Text = keyword;
        }
    }
}
