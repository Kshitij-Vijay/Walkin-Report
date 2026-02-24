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
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            Walkin updated = new Walkin(
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
                dateTimePicker1.Value
            );

            // VERY IMPORTANT
            updated.Id = this.id;

            DBManager db = new DBManager();
            db.UpdateWalkin(updated);

            MessageBox.Show("Walk-in updated successfully");

            this.DialogResult = DialogResult.OK;
            this.Close();
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
