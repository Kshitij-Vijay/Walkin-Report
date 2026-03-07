namespace Walkin_Report
{
    partial class edit_user_actions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            actions_table = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)actions_table).BeginInit();
            SuspendLayout();
            // 
            // actions_table
            // 
            actions_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            actions_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            actions_table.Location = new Point(12, 117);
            actions_table.Name = "actions_table";
            actions_table.RowHeadersWidth = 51;
            actions_table.Size = new Size(776, 321);
            actions_table.TabIndex = 0;
            // 
            // edit_user_actions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(actions_table);
            Name = "edit_user_actions";
            Text = "edit_user_actions";
            Load += edit_user_actions_Load;
            ((System.ComponentModel.ISupportInitialize)actions_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView actions_table;
    }
}