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

namespace Walkin_Report.login
{
    public partial class first_men : Form
    {
        excel_xml xm = new excel_xml();
        int v;
        public first_men(int v)
        {
            InitializeComponent();
            this.v = v;
        }

        private async void first_men_Load(object sender, EventArgs e)
        {
            try
            {
                if(v == 0)
                {
                    Token response = await HttpService.token_validity(xm.get_xml_tag("netjwt"));
                    if (response.valid == true)
                    {
                        xm.set_xml_tag("expiry", response.expires_at);
                        try
                        {
                            string roles = await HttpService.GetRoles(xm.get_xml_tag("netusername"));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Form1 ff = new Form1();
                        this.Hide();
                        ff.Show();
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            register_first rf = new register_first();
            rf.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            login_first lf = new login_first();
            this.Hide();
            lf.Show();
        }
    }
}
