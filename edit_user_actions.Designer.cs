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
            Name_lbl = new Label();
            OK_btn = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)actions_table).BeginInit();
            SuspendLayout();
            // 
            // actions_table
            // 
            actions_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            actions_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            actions_table.Location = new Point(15, 224);
            actions_table.Margin = new Padding(4);
            actions_table.Name = "actions_table";
            actions_table.RowHeadersWidth = 51;
            actions_table.Size = new Size(970, 323);
            actions_table.TabIndex = 0;
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_lbl.Location = new Point(38, 45);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(95, 38);
            Name_lbl.TabIndex = 1;
            Name_lbl.Text = "Name";
            // 
            // OK_btn
            // 
            OK_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OK_btn.Location = new Point(854, 142);
            OK_btn.Margin = new Padding(4, 5, 4, 5);
            OK_btn.Name = "OK_btn";
            OK_btn.Size = new Size(131, 73);
            OK_btn.TabIndex = 9;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = true;
            OK_btn.Click += OK_btn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(38, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 10;
            // 
            // edit_user_actions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(comboBox1);
            Controls.Add(OK_btn);
            Controls.Add(Name_lbl);
            Controls.Add(actions_table);
            Margin = new Padding(4);
            Name = "edit_user_actions";
            Text = "edit_user_actions";
            Load += edit_user_actions_Load;
            ((System.ComponentModel.ISupportInitialize)actions_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView actions_table;
        private Label Name_lbl;
        private Button OK_btn;
        private ComboBox comboBox1;
    }
}