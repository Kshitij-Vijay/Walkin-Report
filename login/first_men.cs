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
                if(v == 0) // form called not from register page
                {
                    Token response = await HttpService.token_validity(xm.get_xml_tag("netjwt"));// check if exsisting token is valid
                    if (response.valid == true)// if valid set credentials and log in 
                    {
                        try
                        {
                            string roles = await HttpService.GetRoles(xm.get_xml_tag("netusername"));
                            int[] rolesarr = xm.string_to_arr(roles);
                            if (rolesarr[0] > 0)
                            {
                                xm.set_xml_tag("netroles", roles);
                                xm.set_xml_tag("expiry", response.expires_at);
                                this.Hide();
                                Form1 form1 = new Form1();
                                form1.Show();
                            }
                            else
                            {
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else // if not valid... auto login using exsisting password and username
                    {
                        try
                        {
                            bool b = await HttpService.Login(xm.get_xml_tag("netusername"), xm.get_xml_tag("netpassword"));// get login token
                            if (b == true)
                            {
                                response = await HttpService.token_validity(xm.get_xml_tag("netjwt"));
                                if(response.valid == true)// recheck token to get response parameters
                                {
                                    try
                                    {
                                        string roles = await HttpService.GetRoles(xm.get_xml_tag("netusername"));
                                        int[] rolesarr = xm.string_to_arr(roles);
                                        if (rolesarr[0] > 0)
                                        {
                                            xm.set_xml_tag("netroles", roles);
                                            xm.set_xml_tag("expiry", response.expires_at);
                                            this.Hide();
                                            Form1 form1 = new Form1();
                                            form1.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Contact admin to fully register");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("fist men catch" + ex.Message);
                                    }
                                }
                                else
                                {
                                    login_btn.Enabled = true;
                                    login_btn.Visible = true;
                                    register_btn.Enabled = true;
                                    register_btn.Visible = true;
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("False token");
                                login_btn.Enabled = true;
                                login_btn.Visible = true;
                                register_btn.Enabled = true;
                                register_btn.Visible = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    login_btn.Enabled = true;
                    login_btn.Visible = true;
                    register_btn.Enabled = true;
                    register_btn.Visible = true;
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
