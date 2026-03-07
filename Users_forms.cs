using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourProject;

namespace Walkin_Report
{
    public partial class Users_forms : Form
    {
        public Users_forms()
        {
            InitializeComponent();
        }

        private async void Users_forms_LoadAsync(object sender, EventArgs e)
        {
            users_table.Columns.Add("id", "ID");
            users_table.Columns.Add("name", "Name");
            users_table.Columns.Add("type", "Type");
            users_table.Columns.Add("roles", "Roles");
            await LoadUsers();
        }

        private async Task LoadUsers()
        {
            try
            {
                List<Userz> users = await HttpService.GetUsers();

                users_table.Rows.Clear();

                foreach (var u in users)
                {
                    int index = users_table.Rows.Add(
                u.id,
                u.name,
                u.type,
                u.roles
            );

                    // store full object in row
                    users_table.Rows[index].Tag = u;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void users_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = users_table.Rows[e.RowIndex];

            Userz selectedUser = row.Tag as Userz;

            if (selectedUser == null) return;

            edit_user_actions form = new edit_user_actions(selectedUser);
            form.ShowDialog();
        }
    }
}
