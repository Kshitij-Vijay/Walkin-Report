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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dateTimePicker1.Value;
            Walkin walkin = new Walkin(
                name_text.Text,
                area_text.Text,
                pin_text.Text,
                phone_text.Text,
                Source_text.Text,
                team_box.Text,
                status_combo.Text,
                category_text.Text,
                Products_text.Text,
                store_combo.Text,
                remarks_text.Text,
                selectedDateTime
            );

            DBManager db = new DBManager();
            db.InsertWalkin(walkin);

            MessageBox.Show("Walk-in saved successfully!");

            this.Close();
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


    }
}
