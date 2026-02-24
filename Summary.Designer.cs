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
            Add_Walkin = new Button();
            search_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)data_table).BeginInit();
            SuspendLayout();
            // 
            // status_group_box
            // 
            status_group_box.Location = new Point(18, 20);
            status_group_box.Margin = new Padding(4, 5, 4, 5);
            status_group_box.Name = "status_group_box";
            status_group_box.Padding = new Padding(4, 5, 4, 5);
            status_group_box.Size = new Size(532, 130);
            status_group_box.TabIndex = 0;
            status_group_box.TabStop = false;
            status_group_box.Text = "Status";
            // 
            // store_group_box
            // 
            store_group_box.Location = new Point(558, 20);
            store_group_box.Margin = new Padding(4, 5, 4, 5);
            store_group_box.Name = "store_group_box";
            store_group_box.Padding = new Padding(4, 5, 4, 5);
            store_group_box.Size = new Size(431, 130);
            store_group_box.TabIndex = 1;
            store_group_box.TabStop = false;
            store_group_box.Text = "Store";
            // 
            // data_table
            // 
            data_table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            data_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            data_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_table.Location = new Point(0, 174);
            data_table.Margin = new Padding(30);
            data_table.Name = "data_table";
            data_table.RowHeadersWidth = 51;
            data_table.Size = new Size(1268, 506);
            data_table.TabIndex = 2;
            data_table.CellClick += data_table_CellClick;
            // 
            // Add_Walkin
            // 
            Add_Walkin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Add_Walkin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Walkin.Location = new Point(1143, 81);
            Add_Walkin.Margin = new Padding(4, 5, 4, 5);
            Add_Walkin.Name = "Add_Walkin";
            Add_Walkin.Size = new Size(104, 69);
            Add_Walkin.TabIndex = 4;
            Add_Walkin.Text = "Add";
            Add_Walkin.UseVisualStyleBackColor = true;
            Add_Walkin.Click += Add_Walkin_Click;
            // 
            // search_btn
            // 
            search_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            search_btn.Location = new Point(1032, 81);
            search_btn.Margin = new Padding(4, 5, 4, 5);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(104, 69);
            search_btn.TabIndex = 5;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 680);
            Controls.Add(search_btn);
            Controls.Add(Add_Walkin);
            Controls.Add(data_table);
            Controls.Add(store_group_box);
            Controls.Add(status_group_box);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1290, 736);
            Name = "Summary";
            Text = "Walkin Report [Summary]";
            Load += Summary_Load;
            ((System.ComponentModel.ISupportInitialize)data_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox status_group_box;
        private GroupBox store_group_box;
        private DataGridView data_table;
        private Button Add_Walkin;
        private Button search_btn;
    }
}