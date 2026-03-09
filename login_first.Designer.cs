namespace Walkin_Report
{
    partial class login_first
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
            label4 = new Label();
            password_text = new TextBox();
            label3 = new Label();
            email_text = new TextBox();
            label2 = new Label();
            name_text = new TextBox();
            label1 = new Label();
            Role_text = new ComboBox();
            Test_btn = new Button();
            OK_btn = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 22);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(272, 46);
            label5.TabIndex = 20;
            label5.Text = "Walkin Report";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(14, 325);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 18;
            label4.Text = "Role : ";
            // 
            // password_text
            // 
            password_text.Font = new Font("Segoe UI", 10.8F);
            password_text.Location = new Point(149, 245);
            password_text.Margin = new Padding(4);
            password_text.Name = "password_text";
            password_text.PasswordChar = '#';
            password_text.Size = new Size(269, 36);
            password_text.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(14, 249);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 16;
            label3.Text = "Password : ";
            // 
            // email_text
            // 
            email_text.Font = new Font("Segoe UI", 10.8F);
            email_text.Location = new Point(149, 169);
            email_text.Margin = new Padding(4);
            email_text.Name = "email_text";
            email_text.Size = new Size(269, 36);
            email_text.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(14, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 14;
            label2.Text = "Email : ";
            // 
            // name_text
            // 
            name_text.Font = new Font("Segoe UI", 10.8F);
            name_text.Location = new Point(149, 100);
            name_text.Margin = new Padding(4);
            name_text.Name = "name_text";
            name_text.Size = new Size(269, 36);
            name_text.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(14, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 12;
            label1.Text = "Name : ";
            // 
            // Role_text
            // 
            Role_text.FormattingEnabled = true;
            Role_text.Location = new Point(149, 322);
            Role_text.Name = "Role_text";
            Role_text.Size = new Size(269, 33);
            Role_text.TabIndex = 21;
            // 
            // Test_btn
            // 
            Test_btn.DialogResult = DialogResult.Cancel;
            Test_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Test_btn.Location = new Point(13, 450);
            Test_btn.Margin = new Padding(4, 5, 4, 5);
            Test_btn.Name = "Test_btn";
            Test_btn.Size = new Size(201, 79);
            Test_btn.TabIndex = 23;
            Test_btn.Text = "Cancel";
            Test_btn.UseVisualStyleBackColor = true;
            // 
            // OK_btn
            // 
            OK_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OK_btn.Location = new Point(222, 450);
            OK_btn.Margin = new Padding(4, 5, 4, 5);
            OK_btn.Name = "OK_btn";
            OK_btn.Size = new Size(215, 77);
            OK_btn.TabIndex = 22;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = true;
            OK_btn.Click += OK_btn_Click;
            // 
            // login_first
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 541);
            Controls.Add(Test_btn);
            Controls.Add(OK_btn);
            Controls.Add(Role_text);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(password_text);
            Controls.Add(label3);
            Controls.Add(email_text);
            Controls.Add(label2);
            Controls.Add(name_text);
            Controls.Add(label1);
            Name = "login_first";
            Text = "Login";
            Load += login_first_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox password_text;
        private Label label3;
        private TextBox email_text;
        private Label label2;
        private TextBox name_text;
        private Label label1;
        private ComboBox Role_text;
        private Button Test_btn;
        private Button OK_btn;
    }
}