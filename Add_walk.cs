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
    public partial class Add_walk : Form
    {
        DBManager db = new DBManager();
        List<Category> categories = new List<Category>();
        public Add_walk()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDateTime = dateTimePicker1.Value;
                string_safety sf = new string_safety();
                Walkin walkin = new Walkin(
                    sf.SafeText(name_text, 100, true),       // required
                    sf.SafeText(area_text, 45),
                    sf.SafeNumber(pin_text, 6),
                    sf.SafeText(phone_text, 15),
                    sf.SafeText(Source_text, 45),
                    sf.SafeCombo(team_box),
                    sf.SafeCombo(status_combo, true),
                    sf.Safestring(Category_list_lbl.Text),
                    sf.SafeText(Products_text, 100),
                    sf.SafeCombo(store_combo, true),         // required
                    sf.SafeText(remarks_text, 100),
                    selectedDateTime
                );
                walkin.amount = (float)sf.SafeDecimal(amount_box, 50, 2, true);



                DBManager db = new DBManager();
                db.InsertWalkin(walkin);

                MessageBox.Show("Walk-in saved successfully!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Add_walk_Load(object sender, EventArgs e)
        {
            add_category.Enabled = false; // Disable until categories are loaded
            categories = db.GetAllCategories();
            LoadStores();
            LoadStatuses();
            LoadStaffs();
            LoadCategories();

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

        private void pin_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // block input
            }
        }

        private void add_category_Click(object sender, EventArgs e)
        {
            string cc = category_text.Text.Trim();
            if (Category_list_lbl.Text.Length == 0)
            {
                Category_list_lbl.Text = cc;
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

        private void amount_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            // Allow control keys (Backspace, Delete, Ctrl+C, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow ONE decimal point
            if (e.KeyChar == '.' && !tb.Text.Contains('.'))
                return;

            // Block everything else
            e.Handled = true;
        }
    }
}
