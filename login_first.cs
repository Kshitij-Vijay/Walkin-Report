using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Walkin_Report.login;
using YourProject;

namespace Walkin_Report
{
    public partial class login_first : Form
    {

        login.excel_xml xm = new login.excel_xml();
        public login_first()
        {
            InitializeComponent();
        }

        private void login_first_Load(object sender, EventArgs e)
        {
            name_text.Text = xm.get_xml_tag("netusername");
            password_text.Text = xm.get_xml_tag("netpassword");
        }

        private async void OK_btn_Click(object sender, EventArgs e)
        {
            string name = name_text.Text;
            string password = password_text.Text;

            bool success = await HttpService.Login(name, password);

            if (!success)
            {
                MessageBox.Show("Invalid credentials");
                return;
            }

            MessageBox.Show("Login successful");
            xm.set_xml_tag("netusername", name);
            xm.set_xml_tag("netpassword", name);

            Token response = await HttpService.token_validity(xm.get_xml_tag("netjwt"));
            if (response.valid == true)
            {
                xm.set_xml_tag("expiry", response.expires_at);
            }
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
