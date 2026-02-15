namespace Walkin_Report
{
    partial class Add_walk
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
            label2 = new Label();
            name_text = new TextBox();
            area_text = new TextBox();
            label3 = new Label();
            pin_text = new TextBox();
            label4 = new Label();
            phone_text = new TextBox();
            label5 = new Label();
            Source_text = new TextBox();
            label6 = new Label();
            category_text = new TextBox();
            label7 = new Label();
            Products_text = new TextBox();
            label8 = new Label();
            remarks_text = new TextBox();
            label9 = new Label();
            store_combo = new ComboBox();
            OK_btn = new Button();
            button1 = new Button();
            status_combo = new ComboBox();
            team_box = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 40);
            label1.TabIndex = 0;
            label1.Text = "Add Walkin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Name : ";
            // 
            // name_text
            // 
            name_text.Location = new Point(79, 78);
            name_text.Name = "name_text";
            name_text.Size = new Size(145, 23);
            name_text.TabIndex = 2;
            // 
            // area_text
            // 
            area_text.Location = new Point(79, 120);
            area_text.Name = "area_text";
            area_text.Size = new Size(145, 23);
            area_text.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Area";
            label3.Click += label3_Click;
            // 
            // pin_text
            // 
            pin_text.Location = new Point(332, 120);
            pin_text.Name = "pin_text";
            pin_text.Size = new Size(145, 23);
            pin_text.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 123);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 5;
            label4.Text = "Pin : ";
            // 
            // phone_text
            // 
            phone_text.Location = new Point(79, 165);
            phone_text.Name = "phone_text";
            phone_text.Size = new Size(145, 23);
            phone_text.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 168);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 7;
            label5.Text = "Phone : ";
            // 
            // Source_text
            // 
            Source_text.Location = new Point(332, 165);
            Source_text.Name = "Source_text";
            Source_text.Size = new Size(145, 23);
            Source_text.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 168);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 9;
            label6.Text = "Source : ";
            // 
            // category_text
            // 
            category_text.Location = new Point(79, 212);
            category_text.Name = "category_text";
            category_text.Size = new Size(145, 23);
            category_text.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 215);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 11;
            label7.Text = "Category : ";
            // 
            // Products_text
            // 
            Products_text.Location = new Point(332, 212);
            Products_text.Name = "Products_text";
            Products_text.Size = new Size(145, 23);
            Products_text.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(265, 215);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 13;
            label8.Text = "Products : ";
            // 
            // remarks_text
            // 
            remarks_text.Location = new Point(79, 266);
            remarks_text.Name = "remarks_text";
            remarks_text.Size = new Size(145, 23);
            remarks_text.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 269);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 15;
            label9.Text = "Remarks : ";
            // 
            // store_combo
            // 
            store_combo.FormattingEnabled = true;
            store_combo.Location = new Point(405, 266);
            store_combo.Name = "store_combo";
            store_combo.Size = new Size(72, 23);
            store_combo.TabIndex = 19;
            // 
            // OK_btn
            // 
            OK_btn.DialogResult = DialogResult.OK;
            OK_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OK_btn.Location = new Point(372, 317);
            OK_btn.Name = "OK_btn";
            OK_btn.Size = new Size(105, 39);
            OK_btn.TabIndex = 20;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = true;
            OK_btn.Click += OK_btn_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(261, 317);
            button1.Name = "button1";
            button1.Size = new Size(105, 39);
            button1.TabIndex = 21;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // status_combo
            // 
            status_combo.FormattingEnabled = true;
            status_combo.Location = new Point(252, 266);
            status_combo.Name = "status_combo";
            status_combo.Size = new Size(72, 23);
            status_combo.TabIndex = 22;
            // 
            // team_box
            // 
            team_box.FormattingEnabled = true;
            team_box.Location = new Point(332, 266);
            team_box.Name = "team_box";
            team_box.Size = new Size(67, 23);
            team_box.TabIndex = 23;
            // 
            // Add_walk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 380);
            Controls.Add(team_box);
            Controls.Add(status_combo);
            Controls.Add(button1);
            Controls.Add(OK_btn);
            Controls.Add(store_combo);
            Controls.Add(remarks_text);
            Controls.Add(label9);
            Controls.Add(Products_text);
            Controls.Add(label8);
            Controls.Add(category_text);
            Controls.Add(label7);
            Controls.Add(Source_text);
            Controls.Add(label6);
            Controls.Add(phone_text);
            Controls.Add(label5);
            Controls.Add(pin_text);
            Controls.Add(label4);
            Controls.Add(area_text);
            Controls.Add(label3);
            Controls.Add(name_text);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Add_walk";
            Text = "Add_walk";
            Load += Add_walk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name_text;
        private TextBox area_text;
        private Label label3;
        private TextBox pin_text;
        private Label label4;
        private TextBox phone_text;
        private Label label5;
        private TextBox Source_text;
        private Label label6;
        private TextBox category_text;
        private Label label7;
        private TextBox Products_text;
        private Label label8;
        private TextBox remarks_text;
        private Label label9;
        private TextBox Team_text;
        private Label label10;
        private ComboBox store_combo;
        private Button OK_btn;
        private Button button1;
        private ComboBox status_combo;
        private ComboBox team_box;
    }
}