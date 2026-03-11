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

        private void LoadConfig()
        {
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "dbconfig.xml"
            );

            if (!File.Exists(path))
            {
                MessageBox.Show($"Config file not found:\n{path}");
                return;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            string server = xm.get_xml_tag("server");
            string db = xm.get_xml_tag("name");
            string user = xm.get_xml_tag("user");
            string pass = xm.get_xml_tag("password");

            if (string.IsNullOrWhiteSpace(server) ||
                string.IsNullOrWhiteSpace(db) ||
                string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Invalid database configuration");
                return;
            }

            server_text.Text = server;
            password_text.Text = pass;
            user_text.Text = user;
            database_text.Text = db;


            st = $"Server={server};Database={db};Uid={user};Pwd={pass};";
        }

        private void settings_Load(object sender, EventArgs e)
        {
            LoadConfig();
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
            test();
        }

        private void test()
        {
            string server = server_text.Text;
            string pass = password_text.Text;
            string user = user_text.Text;
            string database = database_text.Text;
            string ccc = $"Server={server};Database={database};Uid={user};Pwd={pass};";
            bool b = false;
            try
            {
                b = db.test_connection_trial(ccc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (b == false)
                {
                    MessageBox.Show("Connection failed");
                    conn_label.ForeColor = Color.Red;
                    conn_label.Text = "Failed to connect";
                }
                else
                {
                    MessageBox.Show("Connected Successfully");
                    conn_label.ForeColor = Color.Green;
                    conn_label.Text = "Connected Successfully";
                }
            }
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            string server = server_text.Text;
            string pass = password_text.Text;
            string user = user_text.Text;
            string database = database_text.Text;
            string ccc = $"Server={server};Database={database};Uid={user};Pwd={pass};";
            bool b = false;
            try
            {
                b = db.test_connection_trial(ccc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (b == false)
                {
                    conn_label.ForeColor = Color.Red;
                    conn_label.Text = "Failed to connect";
                    MessageBox.Show("Connection failed");
                }
                else
                {
                    conn_label.ForeColor = Color.Green;
                    conn_label.Text = "Connected Successfully";
                    MessageBox.Show("Connected Successfully");
                    bool u = UpdateDbConfig(server, database, user, pass);
                    if (u == false)
                    {
                        MessageBox.Show("Couldn't save changes");
                    }
                    else
                    {
                        MessageBox.Show("Saved Changes");
                        this.Close();
                    }
                }
            }
        }

        public bool UpdateDbConfig(string server, string db, string user, string password)
        {
            bool b = false;
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "dbconfig.xml"
            );

            XmlDocument doc = new XmlDocument();

            // If file does not exist → create it
            if (!File.Exists(path))
            {
                XmlDeclaration xmlDecl = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                XmlElement root = doc.CreateElement("database");

                doc.AppendChild(xmlDecl);
                doc.AppendChild(root);

                root.AppendChild(CreateNode(doc, "server", server));
                root.AppendChild(CreateNode(doc, "name", db));
                root.AppendChild(CreateNode(doc, "user", user));
                root.AppendChild(CreateNode(doc, "password", password));
            }
            else
            {
                doc.Load(path);

                doc.SelectSingleNode("/database/server").InnerText = server;
                doc.SelectSingleNode("/database/name").InnerText = db;
                doc.SelectSingleNode("/database/user").InnerText = user;
                doc.SelectSingleNode("/database/password").InnerText = password;
            }

            doc.Save(path);
            b = true;
            return b;
        }

        private XmlNode CreateNode(XmlDocument doc, string name, string value)
        {
            XmlElement el = doc.CreateElement(name);
            el.InnerText = value;
            return el;
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
