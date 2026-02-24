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
    public partial class Summary : Form
    {
        DBManager db = new DBManager();
        List<Store> stores = new List<Store>();
        List<Status> statuses = new List<Status>();
        List<Walkin> walkins = new List<Walkin>();
        List<Walkin> all_walkins = new List<Walkin>();
        Walkin selectedWalkin;
        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            stores.Clear();
            stores = db.GetAllStores();
            statuses.Clear();
            statuses = db.GetAllStatuses();
            store_group_box.Controls.Clear();
            SetupDataGridView();

            int x = 10;
            int y = 20;
            int btnWidth = 80;
            int btnHeight = 35;
            int margin = 10;
            if (x + btnWidth > store_group_box.Width)
            {
                x = 10;
                y += btnHeight + margin;
            }


            foreach (Store store in stores)
            {
                Button btn = new Button();
                btn.Text = store.Sym;
                btn.Width = btnWidth;
                btn.Height = btnHeight;
                btn.Left = x;
                btn.Top = y;
                btn.Tag = store.Sym;


                btn.Click += StoreButton_Click;   // ✅ ADD THIS

                store_group_box.Controls.Add(btn);

                x += btnWidth + margin;

                if (x + btnWidth > store_group_box.Width)
                {
                    x = 10;
                    y += btnHeight + margin;
                }

            }

            status_group_box.Controls.Clear();

            x = 10;
            y = 20;
            btnWidth = 100;
            btnHeight = 35;
            margin = 10;

            foreach (Status status in statuses)
            {
                Button btn = new Button();
                btn.Text = status.Name;
                btn.Width = btnWidth;
                btn.Height = btnHeight;
                btn.Left = x;
                btn.Top = y;

                btn.Tag = status.Name;

                btn.Click += StatusButton_Click;

                status_group_box.Controls.Add(btn);

                x += btnWidth + margin;

                // auto-wrap
                if (x + btnWidth > status_group_box.Width)
                {
                    x = 10;
                    y += btnHeight + margin;
                }
            }

            walkins = db.GetAllWalkins();
            all_walkins = walkins;
            add_data();

        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string selectedStore = btn.Tag.ToString().Trim();
            Console.WriteLine(selectedStore);
            List<Walkin> filtered = all_walkins
                .Where(w =>
                    !string.IsNullOrWhiteSpace(w.Store) &&
                    w.Store.Trim().Equals(selectedStore, StringComparison.OrdinalIgnoreCase)
                )
                .ToList();


            walkins = filtered;
            add_data();
        }



        private void StatusButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string selectedStatus = btn.Tag.ToString();

            List<Walkin> filtered = all_walkins
                .Where(w => !string.IsNullOrEmpty(w.Status) &&
                            w.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase))
                .ToList();

            walkins = filtered;
            add_data();
        }



        private void SetupDataGridView()
        {
            data_table.Columns.Clear();
            data_table.AutoGenerateColumns = false;

            data_table.Columns.Add("id", "ID");
            data_table.Columns.Add("store", "STORE");
            data_table.Columns.Add("name", "NAME");
            data_table.Columns.Add("date", "DATE");
            data_table.Columns.Add("area", "AREA");
            data_table.Columns.Add("pin", "PIN");
            data_table.Columns.Add("phone", "PHONE");
            data_table.Columns.Add("source", "SOURCE");
            data_table.Columns.Add("team", "TEAM");
            data_table.Columns.Add("status", "STATUS");
            data_table.Columns.Add("category", "CATEGORY");
            data_table.Columns.Add("products", "PRODUCTS");
            data_table.Columns.Add("remarks", "REMARKS");


            data_table.AllowUserToAddRows = false;
            data_table.ReadOnly = true;
            data_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void add_data()
        {
            data_table.Rows.Clear();
            int i = 0;
            foreach (Walkin w in walkins)
            {
                i++;
                data_table.Rows.Add(
                    i,
                    w.Store,
                    w.Name,
                    w.CreatedAt.ToString(),
                    w.Area,
                    w.Pin,
                    w.Phone,
                    w.Source,
                    w.Team,
                    w.Status,
                    w.Category,
                    w.Products,
                    w.Remarks
                );
            }

        }

        private void Add_Walkin_Click(object sender, EventArgs e)
        {
            Add_walk adw = new Add_walk();
            adw.ShowDialog();
            walkins = db.GetAllWalkins();
            all_walkins = walkins;
            add_data();
        }

        private void data_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            Walkin w = walkins[e.RowIndex];

            edit_walkin edw = new edit_walkin(w);
            edw.ShowDialog();
            walkins = db.GetAllWalkins();
            all_walkins = walkins;
            add_data();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (selectedWalkin != null)
            {
                edit_walkin edw = new edit_walkin(selectedWalkin);
            }
            else
            {
                MessageBox.Show("Select a Walkin");
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Search s = new Search(walkins);
            s.ShowDialog();
        }
    }
}
