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
        public List<Walkin> output_walks { get; private set; }
        private List<Walkin> selection_walk = new List<Walkin>();
        private List<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>();
        public List<KeyValuePair<string, string>> output_queries { get; private set; }
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
            parameter_add();
            search_text_box.Enabled = false;
            button1.Enabled = false;
            if(output_walks == null)
            {
                show_btn.Enabled = false;
            }else if(output_walks.Count <=0)
            {
                show_btn.Enabled = false;
            }else if(queries == null)
            {
                show_btn.Enabled = false;
            }else if(queries.Count <= 0)
            {
                show_btn.Enabled = false;
            }
            else
            {
                show_btn.Enabled = true;
            }
        }
        private void parameter_add() // to add data to the combo box
        {
            parameter_combo_box.Items.Clear();
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

            parameter_combo_box.Items.Remove("Created At");
            parameter_combo_box.Items.Remove("Categor");
            parameter_combo_box.Items.Add("Category");


            if (parameter_combo_box.Items.Count > 0)
                parameter_combo_box.SelectedIndex = 0;
        }

        private void search_text_box_TextChanged_1(object sender, EventArgs e) // triggered when something is entered inside the text search
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
            if (parameter == "Category")
            {
                parameter = "Categor";
            }
            para = parameter;
            key = keyword;
            selection_walk = the_search(parameter, keyword);
            update_result_lbl();
        }

        private void update_result_lbl()
        {
            int cccc = 0;
            if (output_walks != null)
            {
                cccc += output_walks.Count;
            }
            if (selection_walk != null)
            {
                cccc += selection_walk.Count;
            }
            result_label.Text = cccc.ToString() + " Matches";
        }

        private List<Walkin> the_search(string parameter, string keyword) // algorithm that searches the walkins
        {
            List<Walkin> selection_walk2 = new List<Walkin>();

            foreach (Walkin w in walkins)
            {
                string value = GetWalkinValue(w, parameter);

                if (!string.IsNullOrEmpty(value) && value.ToLower().Contains(keyword))
                {
                    selection_walk2.Add(w);
                }
            }
            return selection_walk2;
        }

        private string GetWalkinValue(Walkin w, string parameter) // algorithm to search the walkins
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
                case "Categor": return w.Category;
                case "Products": return w.Products;
                case "Store": return w.Store;
                case "Remarks": return w.Remarks;
                default: return "";
            }
        }

        private void button1_Click(object sender, EventArgs e) // add combo box parameters
        {
            queries.Add(new KeyValuePair<string, string>(para,key));
            update_flow_panel();
            button1.Enabled = false;
            search_text_box.Text = "";
            search_text_box.Enabled = false;
            parameter_combo_box.Text = "";

            output_walks = MergeWalkinsNoDuplicates(output_walks, selection_walk);
            selection_walk = new List<Walkin>();
            update_result_lbl();


            if (output_walks == null)
            {
                show_btn.Enabled = false;
            }
            else if (output_walks.Count <= 0)
            {
                show_btn.Enabled = false;
            }
            else if (queries == null)
            {
                show_btn.Enabled = false;
            }
            else if (queries.Count <= 0)
            {
                show_btn.Enabled = false;
            }
            else
            {
                show_btn.Enabled = true;
            }
        }

        private void update_flow_panel() // to manipulate the selected combo ui elements
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

        private void parameter_combo_box_SelectedIndexChanged(object sender, EventArgs e) // enable and disable the add button according to selection
        {
            search_text_box.Enabled = true;
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            output_queries = queries;
            DialogResult = DialogResult.OK;
            Close();
        }

        public static List<Walkin> MergeWalkinsNoDuplicates(List<Walkin> outputWalkins,List<Walkin> selectionWalkins)
        {
            if (selectionWalkins == null)
            {
               
            }
            else if (outputWalkins == null)
            {
                outputWalkins = selectionWalkins;
            }
            else
            {
                HashSet<int> existingIds = new HashSet<int>(
                    outputWalkins
                        .Where(w => w != null)
                        .Select(w => w.Id)
                );

                foreach (var w in selectionWalkins)
                {
                    if (w == null) continue;

                    if (!existingIds.Contains(w.Id))
                    {
                        outputWalkins.Add(w);
                        existingIds.Add(w.Id);
                    }
                }

            }

            return outputWalkins;
        }
    }
}
