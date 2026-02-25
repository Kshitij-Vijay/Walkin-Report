using Mysqlx.Crud;
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
    public partial class edit_walkin : Form
    {
        Walkin selectedWalkin;
        int id;
        DBManager db = new DBManager();
        List<Category> categories = new List<Category>();
        bool category_lable_list_set = false;
        public edit_walkin(Walkin selectedWalkin)
        {
            InitializeComponent();
            this.selectedWalkin = selectedWalkin;
            this.id = selectedWalkin.Id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void edit_walkin_Load(object sender, EventArgs e)
        {
            add_category.Enabled = false; // Disable until categories are loaded
            categories = db.GetAllCategories();
            LoadStores();
            LoadStatuses();
            LoadStaffs();
            LoadCategories();
            Walkin w = selectedWalkin;
            name_text.Text = w.Name ?? "";
            area_text.Text = w.Area ?? "";
            pin_text.Text = w.Pin ?? "";
            phone_text.Text = w.Phone ?? "";
            Source_text.Text = w.Source ?? "";
            team_box.Text = w.Team ?? "";
            status_combo.Text = w.Status ?? "";
            category_text.Text = w.Category ?? "";
            Products_text.Text = w.Products ?? "";
            store_combo.Text = w.Store ?? "";
            remarks_text.Text = w.Remarks ?? "";
            dateTimePicker1.Text = w.CreatedAt.ToString() ?? "";
            Category_list_lbl.Text = w.Category ?? "";
        }

        private void LoadCategories()
        {
            category_text.Items.Clear();
            foreach (Category s in categories)
            {
                category_text.Items.Add(s.Sym);
            }

            if (category_text.Items.Count > 0)
                category_text.SelectedIndex = 0;

            category_text.SelectedItem = null;
            category_text.SelectedIndex = -1;
            category_text.Text = ""; // Clear text to show placeholder
        }

        private void LoadStaffs()
        {
            team_box.Items.Clear();
            List<Staff> arr = db.GetAllStaff();
            foreach (Staff s in arr)
            {
                team_box.Items.Add(s.Sym);
            }

            if (team_box.Items.Count > 0)
                team_box.SelectedIndex = 0;

            team_box.SelectedItem = null;
            team_box.SelectedIndex = -1;

        }

        private void LoadStores()
        {
            List<Store> stores = db.GetAllStores();

            store_combo.Items.Clear();

            foreach (Store store in stores)
            {
                store_combo.Items.Add(store.Sym);
            }

            if (store_combo.Items.Count > 0)
                store_combo.SelectedIndex = 0; // optional default

            store_combo.SelectedItem = null;
            store_combo.SelectedIndex = -1;
        }

        private void LoadStatuses()
        {
            List<Status> statuses = db.GetAllStatuses();

            status_combo.Items.Clear();

            foreach (Status status in statuses)
            {
                status_combo.Items.Add(status.Name);
            }

            if (status_combo.Items.Count > 0)
                status_combo.SelectedIndex = 0; // optional default

            status_combo.SelectedItem = null;
            status_combo.SelectedIndex = -1;
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDateTime = dateTimePicker1.Value;

                Walkin updated = new Walkin(
                    SafeText(name_text, 100, true),       
                    SafeText(area_text, 45),
                    SafeNumber(pin_text, 10),
                    SafeText(phone_text, 40),
                    SafeText(Source_text, 45),
                    SafeCombo(team_box),
                    SafeCombo(status_combo, true),                            
                    Safestring(Category_list_lbl.Text),            
                    SafeText(Products_text, 100),
                    SafeCombo(store_combo, true),         
                    SafeText(remarks_text, 100),
                    selectedDateTime
                );

                // continue saving walkin...


                // VERY IMPORTANT
                updated.Id = this.id;

                db.UpdateWalkin(updated);

                MessageBox.Show("Walk-in updated successfully");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string Safestring(string tb)
        {
            string val = tb.Trim();

            if (string.IsNullOrWhiteSpace(val))
            {
                MessageBox.Show("Category is required", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            return val;
        }

        private void pin_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // block input
            }
        }


        private string SafeText(TextBox tb, int maxLen, bool required = false)
        {
            string val = tb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(val))
            {
                if (required)
                    throw new Exception($"{tb.Name.Replace("_text", "")} is required");
                return null;
            }

            if (val.Length > maxLen)
                throw new Exception($"{tb.Name.Replace("_text", "")} exceeds {maxLen} characters");

            return val;
        }

        private string SafeCombo(ComboBox cb, bool required = false)
        {
            string val = cb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(val))
            {
                if (required)
                    throw new Exception($"{cb.Name} must be selected");
                return null;
            }

            return val;
        }

        private string SafeNumber(TextBox tb, int maxLen, bool required = false)
        {
            string val = tb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(val))
            {
                if (required)
                    throw new Exception($"{tb.Name} is required");
                return null;
            }

            if (!val.All(char.IsDigit))
                throw new Exception($"{tb.Name} must contain only numbers");

            if (val.Length > maxLen)
                throw new Exception($"{tb.Name} exceeds {maxLen} digits");

            return val;
        }

        private void add_category_Click(object sender, EventArgs e)
        {
            string cc = category_text.Text.Trim();
            if (category_lable_list_set==false)
            {
                Category_list_lbl.Text = cc;
                category_lable_list_set = true;
            }
            else
            {
                Category_list_lbl.Text += ", " + cc;
            }
            foreach (Category c in categories)
            {
                if (c.Sym.Equals(cc, StringComparison.OrdinalIgnoreCase))
                {
                    categories.Remove(c);
                    break;
                }
            }
            LoadCategories();
            add_category.Enabled = false;

            foreach (Category c in categories)
            {
                if (c.Sym.Equals(cc, StringComparison.OrdinalIgnoreCase))
                {
                    category_text.Items.Remove(cc);
                    break;
                }
            }
            LoadCategories();
            category_text.SelectedItem = null;
            category_text.SelectedIndex = -1;
        }

        private void category_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category_text.SelectedItem != null)
            {
                add_category.Enabled = true;
            }
        }
    }
}
