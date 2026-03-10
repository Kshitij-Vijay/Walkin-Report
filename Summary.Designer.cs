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
            backup_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)data_table).BeginInit();
            SuspendLayout();
            // 
            // status_group_box
            // 
            status_group_box.Location = new Point(18, 20);
            status_group_box.Margin = new Padding(4, 5, 4, 5);
            status_group_box.Name = "status_group_box";
            status_group_box.Padding = new Padding(4, 5, 4, 5);
            status_group_box.Size = new Size(385, 130);
            status_group_box.TabIndex = 0;
            status_group_box.TabStop = false;
            status_group_box.Text = "Status";
            // 
            // store_group_box
            // 
            store_group_box.Location = new Point(411, 20);
            store_group_box.Margin = new Padding(4, 5, 4, 5);
            store_group_box.Name = "store_group_box";
            store_group_box.Padding = new Padding(4, 5, 4, 5);
            store_group_box.Size = new Size(351, 130);
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
            data_table.Margin = new Padding(30, 30, 30, 30);
            data_table.Name = "data_table";
            data_table.RowHeadersWidth = 51;
            data_table.Size = new Size(1924, 506);
            data_table.TabIndex = 2;
            data_table.CellClick += data_table_CellClick;
            // 
            // Add_Walkin
            // 
            Add_Walkin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Add_Walkin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Walkin.Location = new Point(1799, 81);
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
            search_btn.Location = new Point(1688, 81);
            search_btn.Margin = new Padding(4, 5, 4, 5);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(104, 69);
            search_btn.TabIndex = 5;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // from_date
            // 
            from_date.Location = new Point(778, 32);
            from_date.Margin = new Padding(2);
            from_date.Name = "from_date";
            from_date.Size = new Size(199, 31);
            from_date.TabIndex = 6;
            from_date.ValueChanged += from_date_ValueChanged;
            // 
            // to_date
            // 
            to_date.Location = new Point(778, 119);
            to_date.Margin = new Padding(2);
            to_date.Name = "to_date";
            to_date.Size = new Size(199, 31);
            to_date.TabIndex = 7;
            to_date.ValueChanged += to_date_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(839, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 45);
            label1.TabIndex = 8;
            label1.Text = "TO";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.Location = new Point(992, 32);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(101, 118);
            button1.TabIndex = 9;
            button1.Text = "Full List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // group_follow_up_btns
            // 
            group_follow_up_btns.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            group_follow_up_btns.Location = new Point(1097, 32);
            group_follow_up_btns.Margin = new Padding(2);
            group_follow_up_btns.Name = "group_follow_up_btns";
            group_follow_up_btns.Size = new Size(129, 118);
            group_follow_up_btns.TabIndex = 10;
            group_follow_up_btns.Text = "Group By Followups";
            group_follow_up_btns.UseVisualStyleBackColor = true;
            group_follow_up_btns.Click += group_follow_up_btns_Click;
            // 
            // backup_btn
            // 
            backup_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            backup_btn.Location = new Point(1230, 32);
            backup_btn.Margin = new Padding(2);
            backup_btn.Name = "backup_btn";
            backup_btn.Size = new Size(118, 118);
            backup_btn.TabIndex = 11;
            backup_btn.Text = "Security Backup";
            backup_btn.UseVisualStyleBackColor = true;
            backup_btn.Click += backup_btn_Click;
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 689);
            Controls.Add(backup_btn);
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
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1776, 732);
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
        private Button backup_btn;
    }
}