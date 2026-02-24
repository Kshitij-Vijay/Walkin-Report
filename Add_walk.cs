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
        public Add_walk()
        {
            InitializeComponent(); 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void OK_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDateTime = dateTimePicker1.Value;

                Walkin walkin = new Walkin(
                    SafeText(name_text, 100, true),       // required
                    SafeText(area_text, 45),
                    SafeNumber(pin_text, 10),
                    SafeText(phone_text, 15),
                    SafeText(Source_text, 45),
                    SafeCombo(team_box),
                    SafeCombo(status_combo, true),        // required
                    SafeText(category_text, 45),
                    SafeText(Products_text, 100),
                    SafeCombo(store_combo, true),         // required
                    SafeText(remarks_text, 100),
                    selectedDateTime
                );

                // continue saving walkin...



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
            LoadStores();
            LoadStatuses();
            team_box.Items.Clear();
            List<string> arr = new List<string> { "DIV", "JYO", "KSH", "MDV", "MS", "PLV", "RDK", "RMY", "SHS", "SUD", "VIJ" };
            foreach (string s in arr)
            {
                team_box.Items.Add(s);
            }
        }

        private void LoadStores()
        {
            DBManager db = new DBManager();
            List<Store> stores = db.GetAllStores();

            store_combo.Items.Clear();

            foreach (Store store in stores)
            {
                store_combo.Items.Add(store.Sym);
            }

            if (store_combo.Items.Count > 0)
                store_combo.SelectedIndex = 0; // optional default
        }

        private void LoadStatuses()
        {
            DBManager db = new DBManager();
            List<Status> statuses = db.GetAllStatuses();

            status_combo.Items.Clear();

            foreach (Status status in statuses)
            {
                status_combo.Items.Add(status.Name);
            }

            if (status_combo.Items.Count > 0)
                status_combo.SelectedIndex = 0; // optional default
        }

        private void pin_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // block input
            }
        }
    }
}
