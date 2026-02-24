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
            label1 = new Label();
            server_text = new TextBox();
            user_text = new TextBox();
            label2 = new Label();
            password_text = new TextBox();
            label3 = new Label();
            database_text = new TextBox();
            label4 = new Label();
            OK_btn = new Button();
            Test_btn = new Button();
            conn_label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(29, 80);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Server : ";
            // 
            // server_text
            // 
            server_text.Font = new Font("Segoe UI", 10.8F);
            server_text.Location = new Point(137, 77);
            server_text.Name = "server_text";
            server_text.Size = new Size(216, 31);
            server_text.TabIndex = 1;
            // 
            // user_text
            // 
            user_text.Font = new Font("Segoe UI", 10.8F);
            user_text.Location = new Point(137, 132);
            user_text.Name = "user_text";
            user_text.Size = new Size(216, 31);
            user_text.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(29, 135);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 2;
            label2.Text = "User : ";
            // 
            // password_text
            // 
            password_text.Font = new Font("Segoe UI", 10.8F);
            password_text.Location = new Point(137, 193);
            password_text.Name = "password_text";
            password_text.Size = new Size(216, 31);
            password_text.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(29, 196);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 4;
            label3.Text = "Password : ";
            // 
            // database_text
            // 
            database_text.Font = new Font("Segoe UI", 10.8F);
            database_text.Location = new Point(137, 254);
            database_text.Name = "database_text";
            database_text.Size = new Size(216, 31);
            database_text.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(29, 257);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 6;
            label4.Text = "Database : ";
            // 
            // OK_btn
            // 
            OK_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OK_btn.Location = new Point(212, 382);
            OK_btn.Margin = new Padding(3, 4, 3, 4);
            OK_btn.Name = "OK_btn";
            OK_btn.Size = new Size(161, 55);
            OK_btn.TabIndex = 8;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = true;
            OK_btn.Click += OK_btn_Click;
            // 
            // Test_btn
            // 
            Test_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Test_btn.Location = new Point(12, 382);
            Test_btn.Margin = new Padding(3, 4, 3, 4);
            Test_btn.Name = "Test_btn";
            Test_btn.Size = new Size(194, 55);
            Test_btn.TabIndex = 9;
            Test_btn.Text = "Test";
            Test_btn.UseVisualStyleBackColor = true;
            Test_btn.Click += Test_btn_Click;
            // 
            // conn_label
            // 
            conn_label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            conn_label.AutoSize = true;
            conn_label.Font = new Font("Segoe UI", 10.8F);
            conn_label.Location = new Point(137, 328);
            conn_label.Name = "conn_label";
            conn_label.Size = new Size(102, 25);
            conn_label.TabIndex = 10;
            conn_label.Text = "Connection";
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 450);
            Controls.Add(conn_label);
            Controls.Add(Test_btn);
            Controls.Add(OK_btn);
            Controls.Add(database_text);
            Controls.Add(label4);
            Controls.Add(password_text);
            Controls.Add(label3);
            Controls.Add(user_text);
            Controls.Add(label2);
            Controls.Add(server_text);
            Controls.Add(label1);
            Name = "settings";
            Text = "Settings";
            Load += settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox server_text;
        private TextBox user_text;
        private Label label2;
        private TextBox password_text;
        private Label label3;
        private TextBox database_text;
        private Label label4;
        private Button OK_btn;
        private Button Test_btn;
        private Label conn_label;
    }
}