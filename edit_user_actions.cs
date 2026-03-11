using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Walkin_Report.login;
using YourProject;

namespace Walkin_Report
{
    public partial class edit_user_actions : Form
    {
        Userz selecteduser;
        excel_xml xm = new excel_xml();
        public edit_user_actions(Userz selectedUser)
        {
            InitializeComponent();
            this.selecteduser = selectedUser;
        }

        private async void edit_user_actions_Load(object sender, EventArgs e)
        {
            Name_lbl.Text = $"Edit Actions for {selecteduser.name}";
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("user");
            comboBox1.SelectedItem = selecteduser.type;
            DataGridViewCheckBoxColumn selectedCol = new DataGridViewCheckBoxColumn();

            selectedCol.Name = "selected";
            selectedCol.HeaderText = "Selected";
            selectedCol.Width = 70;

            actions_table.Columns.Add(selectedCol);
            actions_table.Columns.Add("id", "ID");
            actions_table.Columns.Add("name", "Name");
            actions_table.Columns.Add("description", "Description");
            actions_table.Columns.Add("level", "Level");
            await LoadActions();
        }

        private async Task LoadActions()
        {
            try
            {
                List<Action> actions = await HttpService.GetActions();

                actions_table.Rows.Clear();

                HashSet<string> userRoles = new HashSet<string>();

                if (!string.IsNullOrEmpty(selecteduser.roles))
                {
                    userRoles = new HashSet<string>(selecteduser.roles.Split(','));
                }

                foreach (var a in actions)
                {
                    bool isSelected = userRoles.Contains(a.id.ToString());

                    int index = actions_table.Rows.Add(
                        isSelected,
                        a.id,
                        a.name,
                        a.description,
                        a.level
                    );

                    actions_table.Rows[index].Tag = a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void OK_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = selecteduser.name;
                string type = comboBox1.Text;

                List<string> selectedIds = new List<string>();

                foreach (DataGridViewRow row in actions_table.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["selected"].Value);

                    if (isChecked)
                    {
                        string id = row.Cells["id"].Value.ToString();
                        selectedIds.Add(id);
                    }
                }

                string roles = string.Join(",", selectedIds);

                HttpResponseMessage response = await HttpService.UpdateUser(
                    selecteduser.id,
                    name,
                    type,
                    roles
                );

                bool success = response.IsSuccessStatusCode;

                if (!success)
                {
                    MessageBox.Show("Failed to update user");
                    return;
                }

                MessageBox.Show("User updated successfully");
                string json = await response.Content.ReadAsStringAsync();

                using JsonDocument doc = JsonDocument.Parse(json);

                string query = doc.RootElement.GetProperty("query").GetString();

                roles = await HttpService.GetRoles(xm.get_xml_tag("netusername"));
                int[] rolesarr = xm.string_to_arr(roles);
                if (rolesarr[0] > 0)
                {
                    xm.set_xml_tag("netroles", roles);
                    this.Hide();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
