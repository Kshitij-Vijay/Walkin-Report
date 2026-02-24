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
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(36, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 0;
            label1.Text = "Server : ";
            // 
            // server_text
            // 
            server_text.Font = new Font("Segoe UI", 10.8F);
            server_text.Location = new Point(171, 96);
            server_text.Margin = new Padding(4, 4, 4, 4);
            server_text.Name = "server_text";
            server_text.Size = new Size(269, 36);
            server_text.TabIndex = 1;
            // 
            // user_text
            // 
            user_text.Font = new Font("Segoe UI", 10.8F);
            user_text.Location = new Point(171, 165);
            user_text.Margin = new Padding(4, 4, 4, 4);
            user_text.Name = "user_text";
            user_text.Size = new Size(269, 36);
            user_text.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(36, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 2;
            label2.Text = "User : ";
            // 
            // password_text
            // 
            password_text.Font = new Font("Segoe UI", 10.8F);
            password_text.Location = new Point(171, 241);
            password_text.Margin = new Padding(4, 4, 4, 4);
            password_text.Name = "password_text";
            password_text.Size = new Size(269, 36);
            password_text.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(36, 245);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 4;
            label3.Text = "Password : ";
            // 
            // database_text
            // 
            database_text.Font = new Font("Segoe UI", 10.8F);
            database_text.Location = new Point(171, 318);
            database_text.Margin = new Padding(4, 4, 4, 4);
            database_text.Name = "database_text";
            database_text.Size = new Size(269, 36);
            database_text.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(36, 321);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 30);
            label4.TabIndex = 6;
            label4.Text = "Database : ";
            // 
            // OK_btn
            // 
            OK_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OK_btn.Location = new Point(265, 478);
            OK_btn.Margin = new Padding(4, 5, 4, 5);
            OK_btn.Name = "OK_btn";
            OK_btn.Size = new Size(201, 69);
            OK_btn.TabIndex = 8;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = true;
            OK_btn.Click += OK_btn_Click;
            // 
            // Test_btn
            // 
            Test_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Test_btn.Location = new Point(15, 478);
            Test_btn.Margin = new Padding(4, 5, 4, 5);
            Test_btn.Name = "Test_btn";
            Test_btn.Size = new Size(242, 69);
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
            conn_label.Location = new Point(171, 410);
            conn_label.Margin = new Padding(4, 0, 4, 0);
            conn_label.Name = "conn_label";
            conn_label.Size = new Size(123, 30);
            conn_label.TabIndex = 10;
            conn_label.Text = "Connection";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(130, 23);
            label5.Name = "label5";
            label5.Size = new Size(181, 46);
            label5.TabIndex = 11;
            label5.Text = "Version 1";
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 562);
            Controls.Add(label5);
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
            Margin = new Padding(4, 4, 4, 4);
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
        private Label label5;
    }
}