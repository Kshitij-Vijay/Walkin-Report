using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourProject;

namespace Walkin_Report
{
    public partial class login_first : Form
    {
        string name, email, password, role;
        public login_first()
        {
            InitializeComponent();
        }

        private void login_first_Load(object sender, EventArgs e)
        {
            name = name_text.Text;
            email = email_text.Text;
            password = password_text.Text;
            role = Role_text.Text;
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
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
