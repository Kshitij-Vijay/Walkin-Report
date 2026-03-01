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
        bool followup;
        public string edit_result { get; set; }
        public Walkin updated_walkin { get; private set; }
        public edit_walkin(Walkin selectedWalkin, bool v)
        {
            InitializeComponent();
            this.selectedWalkin = selectedWalkin;
            this.id = selectedWalkin.Id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.followup = v;
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
            amount_box.Text = w.amount.ToString() ?? "0";

            if (followup == false)
            {
                f_or_w_lbl.Text = "Edit Walkin";
                edit_result = "editing";
                followUP_btn.Enabled = true;
                Delete_btn.Enabled = true;
                Delete_btn.Visible = true;
            }
            else
            {
                f_or_w_lbl.Text = "Edit Followup";
                edit_result = "followup";
                followUP_btn.Enabled = false;
                Delete_btn.Enabled = false;
                Delete_btn.Visible = false;
                dateTimePicker1.Value = DateTime.Today;
            }
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
                string_safety sf = new string_safety();
                DateTime selectedDateTime = dateTimePicker1.Value;

                Walkin updated = new Walkin(
                    sf.SafeText(name_text, 100, true),
                    sf.SafeText(area_text, 45),
                    sf.SafeNumber(pin_text, 10),
                    sf.SafeText(phone_text, 40),
                    sf.SafeText(Source_text, 45),
                    sf.SafeCombo(team_box),
                    sf.SafeCombo(status_combo, true),
                    sf.Safestring(Category_list_lbl.Text),
                    sf.SafeText(Products_text, 100),
                    sf.SafeCombo(store_combo, true),
                    sf.SafeText(remarks_text, 100),
                    selectedDateTime
                );
                updated.amount = (float)sf.SafeDecimal(amount_box, 50, 2, true);

                if (followup == true)
                {
                    updated.followup = this.id;
                    db.InsertWalkin(updated);
                    MessageBox.Show("Followup Added");
                    updated_walkin = null;
                    edit_result = "followup";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    updated.Id = this.id;
                    db.UpdateWalkin(updated);
                    MessageBox.Show("Walk-in updated successfully");
                    edit_result = "editing";
                    updated_walkin = updated;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void add_category_Click(object sender, EventArgs e)
        {
            string cc = category_text.Text.Trim();
            if (category_lable_list_set == false)
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

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this walk-in?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                db.delete_walkin_by_id(id);
                updated_walkin = null;
                edit_result = "deleted";
                List<Walkin> all = db.GetAllWalkins();
                int idm = selectedWalkin.Id;
                int fidm = selectedWalkin.followup; // parent
                Walkin parent = null;
                Walkin child = null;
                foreach (Walkin walkin in all)
                {
                    if (walkin.Id == fidm)
                    {
                        parent = walkin;
                    }
                    if (walkin.followup == idm)
                    {
                        child = walkin;
                    }
                }
                if (child != null && parent != null)
                {
                    child.followup = parent.Id;
                    db.UpdateWalkin(child);
                    MessageBox.Show("Deleted");
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void followUP_btn_Click(object sender, EventArgs e)
        {
            edit_walkin fup = new edit_walkin(selectedWalkin, true);
            fup.ShowDialog();
            edit_result = "followup";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pin_text_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Allow control keys (Backspace, Delete, Ctrl+C, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow only digits
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
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
