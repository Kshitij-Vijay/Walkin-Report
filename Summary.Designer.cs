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
            from_date = new DateTimePicker();
            to_date = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            group_follow_up_btns = new Button();
            ((System.ComponentModel.ISupportInitialize)data_table).BeginInit();
            SuspendLayout();
            // 
            // status_group_box
            // 
            status_group_box.Location = new Point(14, 16);
            status_group_box.Margin = new Padding(3, 4, 3, 4);
            status_group_box.Name = "status_group_box";
            status_group_box.Padding = new Padding(3, 4, 3, 4);
            status_group_box.Size = new Size(426, 104);
            status_group_box.TabIndex = 0;
            status_group_box.TabStop = false;
            status_group_box.Text = "Status";
            // 
            // store_group_box
            // 
            store_group_box.Location = new Point(446, 16);
            store_group_box.Margin = new Padding(3, 4, 3, 4);
            store_group_box.Name = "store_group_box";
            store_group_box.Padding = new Padding(3, 4, 3, 4);
            store_group_box.Size = new Size(345, 104);
            store_group_box.TabIndex = 1;
            store_group_box.TabStop = false;
            store_group_box.Text = "Store";
            // 
            // data_table
            // 
            data_table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            data_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            data_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_table.Location = new Point(0, 139);
            data_table.Margin = new Padding(24);
            data_table.Name = "data_table";
            data_table.RowHeadersWidth = 51;
            data_table.Size = new Size(1408, 405);
            data_table.TabIndex = 2;
            data_table.CellClick += data_table_CellClick;
            // 
            // Add_Walkin
            // 
            Add_Walkin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Add_Walkin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Walkin.Location = new Point(1308, 65);
            Add_Walkin.Margin = new Padding(3, 4, 3, 4);
            Add_Walkin.Name = "Add_Walkin";
            Add_Walkin.Size = new Size(83, 55);
            Add_Walkin.TabIndex = 4;
            Add_Walkin.Text = "Add";
            Add_Walkin.UseVisualStyleBackColor = true;
            Add_Walkin.Click += Add_Walkin_Click;
            // 
            // search_btn
            // 
            search_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            search_btn.Location = new Point(1219, 65);
            search_btn.Margin = new Padding(3, 4, 3, 4);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(83, 55);
            search_btn.TabIndex = 5;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // from_date
            // 
            from_date.Location = new Point(797, 26);
            from_date.Margin = new Padding(2);
            from_date.Name = "from_date";
            from_date.Size = new Size(160, 27);
            from_date.TabIndex = 6;
            from_date.ValueChanged += from_date_ValueChanged;
            // 
            // to_date
            // 
            to_date.Location = new Point(797, 95);
            to_date.Margin = new Padding(2);
            to_date.Name = "to_date";
            to_date.Size = new Size(160, 27);
            to_date.TabIndex = 7;
            to_date.ValueChanged += to_date_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(846, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 37);
            label1.TabIndex = 8;
            label1.Text = "TO";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.Location = new Point(970, 26);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(81, 94);
            button1.TabIndex = 9;
            button1.Text = "Full List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // group_follow_up_btns
            // 
            group_follow_up_btns.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            group_follow_up_btns.Location = new Point(1055, 26);
            group_follow_up_btns.Margin = new Padding(2);
            group_follow_up_btns.Name = "group_follow_up_btns";
            group_follow_up_btns.Size = new Size(103, 94);
            group_follow_up_btns.TabIndex = 10;
            group_follow_up_btns.Text = "Group By Followups";
            group_follow_up_btns.UseVisualStyleBackColor = true;
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 551);
            Controls.Add(group_follow_up_btns);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(to_date);
            Controls.Add(from_date);
            Controls.Add(search_btn);
            Controls.Add(Add_Walkin);
            Controls.Add(data_table);
            Controls.Add(store_group_box);
            Controls.Add(status_group_box);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1426, 598);
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
        private Button Add_Walkin;
        private Button search_btn;
        private DateTimePicker from_date;
        private DateTimePicker to_date;
        private Label label1;
        private Button button1;
        private Button group_follow_up_btns;
    }
}