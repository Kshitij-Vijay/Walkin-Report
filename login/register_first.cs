using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walkin_Report.login
{
    public partial class register_first : Form
    {
        string name,password,email,role = null;
        public register_first()
        {
            InitializeComponent();
        }

        private void admin_btn_CheckedChanged(object sender, EventArgs e)
        {
            role = "admin";
        }

        private void user_btn_CheckedChanged(object sender, EventArgs e)
        {
            role = "user";
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            name = name_text.Text;
            password = password_text.Text;
            email = email_box.Text;
            if(role == null)
            {
                MessageBox.Show("Select a Role");
            }
            else
            {

            }
        }
    }
}
