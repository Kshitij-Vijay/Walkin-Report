namespace Walkin_Report
{
    partial class Summary
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
            status_group_box = new GroupBox();
            store_group_box = new GroupBox();
            data_table = new DataGridView();
            textBox1 = new TextBox();
            Add_Walkin = new Button();
            edit_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)data_table).BeginInit();
            SuspendLayout();
            // 
            // status_group_box
            // 
            status_group_box.Location = new Point(12, 12);
            status_group_box.Name = "status_group_box";
            status_group_box.Size = new Size(530, 78);
            status_group_box.TabIndex = 0;
            status_group_box.TabStop = false;
            status_group_box.Text = "Status";
            // 
            // store_group_box
            // 
            store_group_box.Location = new Point(548, 12);
            store_group_box.Name = "store_group_box";
            store_group_box.Size = new Size(328, 78);
            store_group_box.TabIndex = 1;
            store_group_box.TabStop = false;
            store_group_box.Text = "Store";
            // 
            // data_table
            // 
            data_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_table.Location = new Point(12, 96);
            data_table.Name = "data_table";
            data_table.Size = new Size(1022, 448);
            data_table.TabIndex = 2;
            data_table.CellClick += data_table_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(882, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 3;
            // 
            // Add_Walkin
            // 
            Add_Walkin.Location = new Point(961, 49);
            Add_Walkin.Name = "Add_Walkin";
            Add_Walkin.Size = new Size(73, 41);
            Add_Walkin.TabIndex = 4;
            Add_Walkin.Text = "Add";
            Add_Walkin.UseVisualStyleBackColor = true;
            Add_Walkin.Click += Add_Walkin_Click;
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(882, 49);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(73, 41);
            edit_btn.TabIndex = 5;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 556);
            Controls.Add(edit_btn);
            Controls.Add(Add_Walkin);
            Controls.Add(textBox1);
            Controls.Add(data_table);
            Controls.Add(store_group_box);
            Controls.Add(status_group_box);
            Name = "Summary";
            Text = "Walkin Report [Summary]";
            Load += Summary_Load;
            ((System.ComponentModel.ISupportInitialize)data_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox status_group_box;
        private GroupBox store_group_box;
        private DataGridView data_table;
        private TextBox textBox1;
        private Button Add_Walkin;
        private Button edit_btn;
    }
}