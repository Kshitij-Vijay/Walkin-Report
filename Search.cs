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
    public partial class Search : Form
    {
        private List<Walkin> walkins;
        private List<Walkin> all_walkins;
        private List<Walkin> output_walks;
        private List<Walkin> selection_walk = new List<Walkin>();
        Dictionary<string, string> queries = new Dictionary<string, string>();
        string para = "";
        string key = "";
        DBManager db = new DBManager();

        public Search(List<Walkin> walkins)
        {
            InitializeComponent();
            this.walkins = walkins;
        }
        private void Search_Load_1(object sender, EventArgs e)
        {
            all_walkins = db.GetAllWalkins();
            parameter_add();
            search_text_box.Enabled = false;
            button1.Enabled = false;
        }
        private void parameter_add()
        {
            parameter_combo_box.Items.Clear();

            DBManager db = new DBManager();
            List<string> columns = db.GetWalkinColumns();

            foreach (string col in columns)
            {
                // Optional: skip technical columns
                if (col == "id") continue;

                // Optional: make it user-friendly
                parameter_combo_box.Items.Add(
                    System.Globalization.CultureInfo
                        .CurrentCulture.TextInfo
                        .ToTitleCase(col.Replace("_", " "))
                );
            }

            if (parameter_combo_box.Items.Count > 0)
                parameter_combo_box.SelectedIndex = 0;
        }

        private void search_text_box_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = search_text_box.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                result_label.Text = "0 matches";
                button1.Enabled = false;
                return;
            }
            button1.Enabled = true;
            string parameter = parameter_combo_box.SelectedItem.ToString();
            para = parameter;
            key = keyword;
            the_search(parameter, keyword);
        }

        private void the_search(string parameter, string keyword)
        {
            selection_walk = new List<Walkin>();

            foreach (Walkin w in walkins)
            {
                string value = GetWalkinValue(w, parameter);

                if (!string.IsNullOrEmpty(value) && value.ToLower().Contains(keyword))
                {
                    selection_walk.Add(w);
                }
            }
            result_label.Text = $"{selection_walk.Count} matches";
        }

        private string GetWalkinValue(Walkin w, string parameter)
        {
            switch (parameter)
            {
                case "Name": return w.Name;
                case "Area": return w.Area;
                case "Pin": return w.Pin;
                case "Phone": return w.Phone;
                case "Source": return w.Source;
                case "Team": return w.Team;
                case "Status": return w.Status;
                case "Category": return w.Category;
                case "Products": return w.Products;
                case "Store": return w.Store;
                case "Remarks": return w.Remarks;
                default: return "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queries[para] = key;
            update_flow_panel();
            button1.Enabled = false;
            search_text_box.Text = "";
            search_text_box.Enabled = false;
            parameter_combo_box.Text = "";
        }

        private void update_flow_panel()
        {
            // Clear old UI
            flowLayoutPanel1.Controls.Clear();


            // Rebuild UI from dictionary
            foreach (var pair in queries)
            {
                quer q = new quer(pair.Key, pair.Value);
                q.Margin = new Padding(5);
                flowLayoutPanel1.Controls.Add(q);
            }
        }

        private void parameter_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_text_box.Enabled = true;
        }

        private void show_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
