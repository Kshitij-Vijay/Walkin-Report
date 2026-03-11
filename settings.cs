using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Walkin_Report.login;
using YourProject;

namespace Walkin_Report
{
    public partial class settings : Form
    {
        string st;
        DBManager db = new DBManager();
        excel_xml xm = new excel_xml();
        int[] rolesarr;
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            username_lbl.Text = xm.get_xml_tag("netusername");
            token_exp_lbl.Text = xm.get_xml_tag("expiry");
            acitons();
        }

        private void acitons()
        {
            rolesarr = xm.string_to_arr(xm.get_xml_tag("netroles"));
            if (rolesarr.Contains(1)) // able to generate walkin.csv
            {
                excel_data_btn.Enabled = true;
                excel_data_btn.Visible = true;
            }
            else
            {
                excel_data_btn.Enabled = false;
                excel_data_btn.Visible = false;
            }

            if (rolesarr.Contains(2))// able to generate the entire database.csv
            {
                excel_full_btn.Enabled = true;
                excel_full_btn.Visible = true;
            }
            else
            {
                excel_full_btn.Enabled = false;
                excel_full_btn.Visible = false;
            }

            if (rolesarr.Contains(1) == false && rolesarr.Contains(2) == false)
            {
                excel_group_box.Enabled = false;
                excel_group_box.Visible = false;
            }

            if (rolesarr.Contains(18))
            {
                manage_users_btn.Enabled = true;
                manage_users_btn.Visible = true;
            }
            else
            {
                manage_users_btn.Enabled = false;
                manage_users_btn.Visible = false;
            }

            if (rolesarr.Contains(24))
            {
                new_account_btn.Enabled = true;
                new_account_btn.Visible = true;
            }
            else
            {
                new_account_btn.Enabled = false;
                new_account_btn.Visible = false;
            }
        }

        private void Test_btn_Click(object sender, EventArgs e)
        {
        }

        private void manage_users_btn_Click(object sender, EventArgs e)
        {
            Users_forms uf = new Users_forms();
            uf.ShowDialog();
        }

        private void new_account_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void excel_data_btn_Click(object sender, EventArgs e)
        {
            await excel_xml.excel_data();
        }

        private async void excel_full_btn_Click(object sender, EventArgs e)
        {
            await excel_xml.excel_data_full();
        }
    }
}
