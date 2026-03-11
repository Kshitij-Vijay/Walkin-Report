namespace Walkin_Report
{
    partial class settings
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
            label5 = new Label();
            manage_users_btn = new Button();
            username_lbl = new Label();
            new_account_btn = new Button();
            token_exp_lbl = new Label();
            excel_data_btn = new Button();
            excel_full_btn = new Button();
            excel_group_box = new GroupBox();
            test_btn = new Button();
            connect_lbl = new Label();
            excel_group_box.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(130, 22);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(191, 46);
            label5.TabIndex = 11;
            label5.Text = "Version 4";
            // 
            // manage_users_btn
            // 
            manage_users_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manage_users_btn.Location = new Point(14, 494);
            manage_users_btn.Margin = new Padding(4, 5, 4, 5);
            manage_users_btn.Name = "manage_users_btn";
            manage_users_btn.Size = new Size(232, 72);
            manage_users_btn.TabIndex = 12;
            manage_users_btn.Text = "Manage Users";
            manage_users_btn.UseVisualStyleBackColor = true;
            manage_users_btn.Click += manage_users_btn_Click;
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("MV Boli", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            username_lbl.Location = new Point(13, 94);
            username_lbl.Margin = new Padding(2, 0, 2, 0);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(187, 46);
            username_lbl.TabIndex = 13;
            username_lbl.Text = "Username";
            // 
            // new_account_btn
            // 
            new_account_btn.DialogResult = DialogResult.Abort;
            new_account_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_account_btn.Location = new Point(13, 408);
            new_account_btn.Margin = new Padding(4, 5, 4, 5);
            new_account_btn.Name = "new_account_btn";
            new_account_btn.Size = new Size(232, 72);
            new_account_btn.TabIndex = 14;
            new_account_btn.Text = "New Account";
            new_account_btn.UseVisualStyleBackColor = true;
            new_account_btn.Click += new_account_btn_Click;
            // 
            // token_exp_lbl
            // 
            token_exp_lbl.AutoSize = true;
            token_exp_lbl.Font = new Font("Bahnschrift Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            token_exp_lbl.Location = new Point(28, 155);
            token_exp_lbl.Margin = new Padding(2, 0, 2, 0);
            token_exp_lbl.Name = "token_exp_lbl";
            token_exp_lbl.Size = new Size(74, 34);
            token_exp_lbl.TabIndex = 15;
            token_exp_lbl.Text = "expiry";
            // 
            // excel_data_btn
            // 
            excel_data_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            excel_data_btn.Location = new Point(121, 42);
            excel_data_btn.Margin = new Padding(4, 5, 4, 5);
            excel_data_btn.Name = "excel_data_btn";
            excel_data_btn.Size = new Size(80, 49);
            excel_data_btn.TabIndex = 17;
            excel_data_btn.Text = "Data";
            excel_data_btn.UseVisualStyleBackColor = true;
            excel_data_btn.Click += excel_data_btn_Click;
            // 
            // excel_full_btn
            // 
            excel_full_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            excel_full_btn.Location = new Point(20, 42);
            excel_full_btn.Margin = new Padding(4, 5, 4, 5);
            excel_full_btn.Name = "excel_full_btn";
            excel_full_btn.Size = new Size(80, 49);
            excel_full_btn.TabIndex = 18;
            excel_full_btn.Text = "Full";
            excel_full_btn.UseVisualStyleBackColor = true;
            excel_full_btn.Click += excel_full_btn_Click;
            // 
            // excel_group_box
            // 
            excel_group_box.Controls.Add(excel_full_btn);
            excel_group_box.Controls.Add(excel_data_btn);
            excel_group_box.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            excel_group_box.Location = new Point(289, 380);
            excel_group_box.Margin = new Padding(2);
            excel_group_box.Name = "excel_group_box";
            excel_group_box.Padding = new Padding(2);
            excel_group_box.Size = new Size(218, 112);
            excel_group_box.TabIndex = 19;
            excel_group_box.TabStop = false;
            excel_group_box.Text = "Export to Excel";
            // 
            // test_btn
            // 
            test_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            test_btn.Location = new Point(28, 252);
            test_btn.Margin = new Padding(4, 5, 4, 5);
            test_btn.Name = "test_btn";
            test_btn.Size = new Size(250, 69);
            test_btn.TabIndex = 20;
            test_btn.Text = "Test connection";
            test_btn.UseVisualStyleBackColor = true;
            test_btn.Click += test_btn_Click_1;
            // 
            // connect_lbl
            // 
            connect_lbl.AutoSize = true;
            connect_lbl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            connect_lbl.Location = new Point(303, 274);
            connect_lbl.Name = "connect_lbl";
            connect_lbl.Size = new Size(166, 30);
            connect_lbl.TabIndex = 21;
            connect_lbl.Text = "Server Stopped";
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 591);
            Controls.Add(connect_lbl);
            Controls.Add(test_btn);
            Controls.Add(excel_group_box);
            Controls.Add(token_exp_lbl);
            Controls.Add(new_account_btn);
            Controls.Add(username_lbl);
            Controls.Add(manage_users_btn);
            Controls.Add(label5);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "settings";
            Text = "Settings";
            Load += settings_Load;
            excel_group_box.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button manage_users_btn;
        private Label username_lbl;
        private Button new_account_btn;
        private Label token_exp_lbl;
        private Button excel_data_btn;
        private Button excel_full_btn;
        private GroupBox excel_group_box;
        private Button test_btn;
        private Label connect_lbl;
    }
}