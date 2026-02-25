namespace Walkin_Report
{
    partial class edit_walkin
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
            team_box = new ComboBox();
            status_combo = new ComboBox();
            button1 = new Button();
            OK_btn = new Button();
            store_combo = new ComboBox();
            remarks_text = new TextBox();
            label9 = new Label();
            Products_text = new TextBox();
            label8 = new Label();
            label7 = new Label();
            Source_text = new TextBox();
            label6 = new Label();
            phone_text = new TextBox();
            label5 = new Label();
            pin_text = new TextBox();
            label4 = new Label();
            area_text = new TextBox();
            label3 = new Label();
            name_text = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            category_text = new ComboBox();
            add_category = new Button();
            Category_list_lbl = new Label();
            SuspendLayout();
            // 
            // team_box
            // 
            team_box.Font = new Font("Segoe UI", 10F);
            team_box.FormattingEnabled = true;
            team_box.Location = new Point(474, 444);
            team_box.Margin = new Padding(4, 5, 4, 5);
            team_box.Name = "team_box";
            team_box.Size = new Size(94, 36);
            team_box.TabIndex = 45;
            // 
            // status_combo
            // 
            status_combo.Font = new Font("Segoe UI", 10F);
            status_combo.FormattingEnabled = true;
            status_combo.Location = new Point(360, 444);
            status_combo.Margin = new Padding(4, 5, 4, 5);
            status_combo.Name = "status_combo";
            status_combo.Size = new Size(102, 36);
            status_combo.TabIndex = 44;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(372, 529);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(150, 65);
            button1.TabIndex = 43;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // OK_btn
            // 
            OK_btn.DialogResult = DialogResult.OK;
            OK_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OK_btn.Location = new Point(531, 529);
            OK_btn.Margin = new Padding(4, 5, 4, 5);
            OK_btn.Name = "OK_btn";
            OK_btn.Size = new Size(150, 65);
            OK_btn.TabIndex = 42;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = true;
            OK_btn.Click += OK_btn_Click;
            // 
            // store_combo
            // 
            store_combo.Font = new Font("Segoe UI", 10F);
            store_combo.FormattingEnabled = true;
            store_combo.Location = new Point(579, 444);
            store_combo.Margin = new Padding(4, 5, 4, 5);
            store_combo.Name = "store_combo";
            store_combo.Size = new Size(102, 36);
            store_combo.TabIndex = 41;
            // 
            // remarks_text
            // 
            remarks_text.Font = new Font("Segoe UI", 10F);
            remarks_text.Location = new Point(112, 444);
            remarks_text.Margin = new Padding(4, 5, 4, 5);
            remarks_text.Name = "remarks_text";
            remarks_text.Size = new Size(205, 34);
            remarks_text.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 449);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 25);
            label9.TabIndex = 39;
            label9.Text = "Remarks : ";
            // 
            // Products_text
            // 
            Products_text.Font = new Font("Segoe UI", 10F);
            Products_text.Location = new Point(474, 354);
            Products_text.Margin = new Padding(4, 5, 4, 5);
            Products_text.Name = "Products_text";
            Products_text.Size = new Size(205, 34);
            Products_text.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(379, 359);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 25);
            label8.TabIndex = 37;
            label8.Text = "Products : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 359);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 35;
            label7.Text = "Category : ";
            // 
            // Source_text
            // 
            Source_text.Font = new Font("Segoe UI", 10F);
            Source_text.Location = new Point(474, 275);
            Source_text.Margin = new Padding(4, 5, 4, 5);
            Source_text.Name = "Source_text";
            Source_text.Size = new Size(205, 34);
            Source_text.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(379, 280);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 33;
            label6.Text = "Source : ";
            // 
            // phone_text
            // 
            phone_text.Font = new Font("Segoe UI", 10F);
            phone_text.Location = new Point(112, 275);
            phone_text.Margin = new Padding(4, 5, 4, 5);
            phone_text.MaxLength = 55;
            phone_text.Name = "phone_text";
            phone_text.Size = new Size(205, 34);
            phone_text.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 280);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 31;
            label5.Text = "Phone : ";
            // 
            // pin_text
            // 
            pin_text.Font = new Font("Segoe UI", 10F);
            pin_text.Location = new Point(474, 200);
            pin_text.Margin = new Padding(4, 5, 4, 5);
            pin_text.MaxLength = 6;
            pin_text.Name = "pin_text";
            pin_text.Size = new Size(205, 34);
            pin_text.TabIndex = 30;
            pin_text.KeyPress += pin_text_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 205);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 29;
            label4.Text = "Pin : ";
            // 
            // area_text
            // 
            area_text.Font = new Font("Segoe UI", 10F);
            area_text.Location = new Point(112, 200);
            area_text.Margin = new Padding(4, 5, 4, 5);
            area_text.Name = "area_text";
            area_text.Size = new Size(205, 34);
            area_text.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 205);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 27;
            label3.Text = "Area";
            // 
            // name_text
            // 
            name_text.Font = new Font("Segoe UI", 10F);
            name_text.Location = new Point(112, 130);
            name_text.Margin = new Padding(4, 5, 4, 5);
            name_text.Name = "name_text";
            name_text.Size = new Size(205, 34);
            name_text.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 25;
            label2.Text = "Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 60);
            label1.TabIndex = 24;
            label1.Text = "Edit Walkin";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(368, 130);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 34);
            dateTimePicker1.TabIndex = 46;
            // 
            // category_text
            // 
            category_text.Font = new Font("Segoe UI", 10F);
            category_text.FormattingEnabled = true;
            category_text.Location = new Point(123, 354);
            category_text.Name = "category_text";
            category_text.Size = new Size(131, 36);
            category_text.TabIndex = 47;
            category_text.SelectedIndexChanged += category_text_SelectedIndexChanged;
            // 
            // add_category
            // 
            add_category.Font = new Font("Impact", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_category.Location = new Point(260, 354);
            add_category.Name = "add_category";
            add_category.Size = new Size(57, 34);
            add_category.TabIndex = 50;
            add_category.Text = "+";
            add_category.UseVisualStyleBackColor = true;
            add_category.Click += add_category_Click;
            // 
            // Category_list_lbl
            // 
            Category_list_lbl.AutoSize = true;
            Category_list_lbl.Location = new Point(47, 400);
            Category_list_lbl.Name = "Category_list_lbl";
            Category_list_lbl.Size = new Size(0, 25);
            Category_list_lbl.TabIndex = 51;
            // 
            // edit_walkin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 629);
            Controls.Add(Category_list_lbl);
            Controls.Add(add_category);
            Controls.Add(category_text);
            Controls.Add(dateTimePicker1);
            Controls.Add(team_box);
            Controls.Add(status_combo);
            Controls.Add(button1);
            Controls.Add(OK_btn);
            Controls.Add(store_combo);
            Controls.Add(remarks_text);
            Controls.Add(label9);
            Controls.Add(Products_text);
            Controls.Add(label8);
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
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "edit_walkin";
            Text = "Edit";
            Load += edit_walkin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox team_box;
        private ComboBox status_combo;
        private Button button1;
        private Button OK_btn;
        private ComboBox store_combo;
        private TextBox remarks_text;
        private Label label9;
        private TextBox Products_text;
        private Label label8;
        private Label label7;
        private TextBox Source_text;
        private Label label6;
        private TextBox phone_text;
        private Label label5;
        private TextBox pin_text;
        private Label label4;
        private TextBox area_text;
        private Label label3;
        private TextBox name_text;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox category_text;
        private Button add_category;
        private Label Category_list_lbl;
    }
}