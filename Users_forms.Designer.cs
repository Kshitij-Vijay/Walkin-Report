namespace Walkin_Report
{
    partial class Users_forms
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
            users_table = new DataGridView();
            f_or_w_lbl = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)users_table).BeginInit();
            SuspendLayout();
            // 
            // users_table
            // 
            users_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            users_table.Dock = DockStyle.Bottom;
            users_table.Location = new Point(0, 143);
            users_table.Name = "users_table";
            users_table.RowHeadersWidth = 51;
            users_table.Size = new Size(561, 409);
            users_table.TabIndex = 0;
            users_table.CellClick += users_table_CellClick;
            // 
            // f_or_w_lbl
            // 
            f_or_w_lbl.AutoSize = true;
            f_or_w_lbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            f_or_w_lbl.Location = new Point(12, 9);
            f_or_w_lbl.Name = "f_or_w_lbl";
            f_or_w_lbl.Size = new Size(126, 50);
            f_or_w_lbl.TabIndex = 55;
            f_or_w_lbl.Text = "Users ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 56;
            label1.Text = "Click to edit";
            // 
            // Users_forms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 552);
            Controls.Add(label1);
            Controls.Add(f_or_w_lbl);
            Controls.Add(users_table);
            Name = "Users_forms";
            Text = "Users_forms";
            Load += Users_forms_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)users_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView users_table;
        private Label f_or_w_lbl;
        private Label label1;
    }
}