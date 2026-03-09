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
            password_text = new TextBox();
            label3 = new Label();
            name_text = new TextBox();
            label1 = new Label();
            Test_btn = new Button();
            OK_btn = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 18);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(233, 40);
            label5.TabIndex = 20;
            label5.Text = "Walkin Report";
            // 
            // password_text
            // 
            password_text.Font = new Font("Segoe UI", 10.8F);
            password_text.Location = new Point(119, 132);
            password_text.Name = "password_text";
            password_text.PasswordChar = '#';
            password_text.Size = new Size(216, 31);
            password_text.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(11, 135);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 16;
            label3.Text = "Password : ";
            // 
            // name_text
            // 
            name_text.Font = new Font("Segoe UI", 10.8F);
            name_text.Location = new Point(119, 80);
            name_text.Name = "name_text";
            name_text.Size = new Size(216, 31);
            name_text.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(11, 83);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 12;
            label1.Text = "Name : ";
            // 
            // Test_btn
            // 
            Test_btn.DialogResult = DialogResult.Cancel;
            Test_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Test_btn.Location = new Point(11, 183);
            Test_btn.Margin = new Padding(3, 4, 3, 4);
            Test_btn.Name = "Test_btn";
            Test_btn.Size = new Size(161, 63);
            Test_btn.TabIndex = 23;
            Test_btn.Text = "Cancel";
            Test_btn.UseVisualStyleBackColor = true;
            // 
            // OK_btn
            // 
            OK_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OK_btn.Location = new Point(179, 183);
            OK_btn.Margin = new Padding(3, 4, 3, 4);
            OK_btn.Name = "OK_btn";
            OK_btn.Size = new Size(172, 62);
            OK_btn.TabIndex = 22;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = true;
            OK_btn.Click += OK_btn_Click;
            // 
            // login_first
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 281);
            Controls.Add(Test_btn);
            Controls.Add(OK_btn);
            Controls.Add(label5);
            Controls.Add(password_text);
            Controls.Add(label3);
            Controls.Add(name_text);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "login_first";
            Text = "Login";
            Load += login_first_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox password_text;
        private Label label3;
        private TextBox name_text;
        private Label label1;
        private Button Test_btn;
        private Button OK_btn;
    }
}