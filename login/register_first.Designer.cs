namespace Walkin_Report.login
{
    partial class register_first
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
            Cancel_btn = new Button();
            OK_btn = new Button();
            label5 = new Label();
            password_text = new TextBox();
            label3 = new Label();
            name_text = new TextBox();
            label1 = new Label();
            label2 = new Label();
            email_box = new TextBox();
            label4 = new Label();
            admin_btn = new RadioButton();
            user_btn = new RadioButton();
            SuspendLayout();
            // 
            // Cancel_btn
            // 
            Cancel_btn.DialogResult = DialogResult.Cancel;
            Cancel_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel_btn.Location = new Point(17, 287);
            Cancel_btn.Margin = new Padding(3, 4, 3, 4);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(161, 63);
            Cancel_btn.TabIndex = 30;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // OK_btn
            // 
            OK_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OK_btn.Location = new Point(185, 287);
            OK_btn.Margin = new Padding(3, 4, 3, 4);
            OK_btn.Name = "OK_btn";
            OK_btn.Size = new Size(172, 62);
            OK_btn.TabIndex = 29;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = true;
            OK_btn.Click += OK_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 9);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(233, 40);
            label5.TabIndex = 28;
            label5.Text = "Walkin Report";
            // 
            // password_text
            // 
            password_text.Font = new Font("Segoe UI", 10.8F);
            password_text.Location = new Point(125, 123);
            password_text.Name = "password_text";
            password_text.PasswordChar = '#';
            password_text.Size = new Size(216, 31);
            password_text.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(17, 126);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 26;
            label3.Text = "Password : ";
            // 
            // name_text
            // 
            name_text.Font = new Font("Segoe UI", 10.8F);
            name_text.Location = new Point(125, 71);
            name_text.Name = "name_text";
            name_text.Size = new Size(216, 31);
            name_text.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(17, 74);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 24;
            label1.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(17, 234);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 33;
            label2.Text = "Role : ";
            // 
            // email_box
            // 
            email_box.Font = new Font("Segoe UI", 10.8F);
            email_box.Location = new Point(125, 179);
            email_box.Name = "email_box";
            email_box.Size = new Size(216, 31);
            email_box.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(17, 182);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 31;
            label4.Text = "Email : ";
            // 
            // admin_btn
            // 
            admin_btn.AutoSize = true;
            admin_btn.Location = new Point(125, 234);
            admin_btn.Name = "admin_btn";
            admin_btn.Size = new Size(74, 24);
            admin_btn.TabIndex = 34;
            admin_btn.TabStop = true;
            admin_btn.Text = "Admin";
            admin_btn.UseVisualStyleBackColor = true;
            admin_btn.CheckedChanged += admin_btn_CheckedChanged;
            // 
            // user_btn
            // 
            user_btn.AutoSize = true;
            user_btn.Location = new Point(224, 234);
            user_btn.Name = "user_btn";
            user_btn.Size = new Size(59, 24);
            user_btn.TabIndex = 35;
            user_btn.TabStop = true;
            user_btn.Text = "User";
            user_btn.UseVisualStyleBackColor = true;
            user_btn.CheckedChanged += user_btn_CheckedChanged;
            // 
            // register_first
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 377);
            Controls.Add(user_btn);
            Controls.Add(admin_btn);
            Controls.Add(label2);
            Controls.Add(email_box);
            Controls.Add(label4);
            Controls.Add(Cancel_btn);
            Controls.Add(OK_btn);
            Controls.Add(label5);
            Controls.Add(password_text);
            Controls.Add(label3);
            Controls.Add(name_text);
            Controls.Add(label1);
            Name = "register_first";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel_btn;
        private Button OK_btn;
        private Label label5;
        private TextBox password_text;
        private Label label3;
        private TextBox name_text;
        private Label label1;
        private Label label2;
        private TextBox email_box;
        private Label label4;
        private RadioButton admin_btn;
        private RadioButton user_btn;
    }
}