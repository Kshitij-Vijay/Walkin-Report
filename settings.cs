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

namespace Walkin_Report
{
    public partial class settings : Form
    {
        string st;
        DBManager db = new DBManager();
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

            string server = doc.SelectSingleNode("/database/server")?.InnerText;
            string db = doc.SelectSingleNode("/database/name")?.InnerText;
            string user = doc.SelectSingleNode("/database/user")?.InnerText;
            string pass = doc.SelectSingleNode("/database/password")?.InnerText;

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
            colors();
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
                    if(u == false)
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
        private Dictionary<int, Color> statusColors;

        public void PopulateStatusGrid(DataGridView dataGridView1, List<Status> statuses)
        {
            statusColors = db.LoadStatusColors(statuses);

            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns["Status"].ReadOnly = true;
            dataGridView1.Columns["Status"].Width = 150;

            dataGridView1.Columns.Add("Color", "Color");
            dataGridView1.Columns["Color"].Width = 100;

            foreach (Status status in statuses)
            {
                int rowIndex = dataGridView1.Rows.Add(status.Name, "");

                // Use saved color or default
                Color color = statusColors.ContainsKey(status.Id) ?
                             statusColors[status.Id] : Color.LightGray;

                dataGridView1.Rows[rowIndex].Cells[1].Style.BackColor = color;
                dataGridView1.Rows[rowIndex].Tag = status.Id;  // Store ID in row Tag
            }

            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                int statusId = (int)dgv.Rows[e.RowIndex].Tag;

                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        dgv.Rows[e.RowIndex].Cells[1].Style.BackColor = colorDialog.Color;
                        dgv.Rows[e.RowIndex].Cells[1].Value = "";

                        // Save hex to DB immediately
                        db.SaveStatusColor(statusId, colorDialog.Color);
                    }
                }
            }
        }

        private void colors()
        {
            var statuses = db.GetAllStatuses();
            PopulateStatusGrid(dataGridView1, statuses);
        }
    }
}
