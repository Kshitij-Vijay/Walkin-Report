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
    public partial class edit_user_actions : Form
    {
        public edit_user_actions(Userz selectedUser)
        {
            InitializeComponent();
        }

        private async void edit_user_actions_Load(object sender, EventArgs e)
        {
            actions_table.Columns.Add("Checked", "Checked");
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

                foreach (var a in actions)
                {
                    int index = actions_table.Rows.Add(
                        a.selected,
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
    }
}
