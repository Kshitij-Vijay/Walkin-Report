namespace Walkin_Report.login
{
    partial class first_men
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
            register_btn = new Button();
            login_btn = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(103, 29);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(272, 46);
            label5.TabIndex = 21;
            label5.Text = "Walkin Report";
            // 
            // register_btn
            // 
            register_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_btn.Location = new Point(36, 109);
            register_btn.Margin = new Padding(4, 5, 4, 5);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(201, 79);
            register_btn.TabIndex = 25;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // login_btn
            // 
            login_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(246, 109);
            login_btn.Margin = new Padding(4, 5, 4, 5);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(215, 78);
            login_btn.TabIndex = 24;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // first_men
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 215);
            Controls.Add(register_btn);
            Controls.Add(login_btn);
            Controls.Add(label5);
            Margin = new Padding(4);
            Name = "first_men";
            Text = "Walkin Report";
            Load += first_men_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button register_btn;
        private Button login_btn;
    }
}