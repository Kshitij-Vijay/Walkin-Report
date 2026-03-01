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
            Delete_btn = new Button();
            SuspendLayout();
            // 
            // team_box
            // 
            team_box.Font = new Font("Segoe UI", 10F);
            team_box.FormattingEnabled = true;
            team_box.Location = new Point(379, 355);
            team_box.Margin = new Padding(3, 4, 3, 4);
            team_box.Name = "team_box";
            team_box.Size = new Size(76, 31);
            team_box.TabIndex = 45;
            // 
            // status_combo
            // 
            status_combo.Font = new Font("Segoe UI", 10F);
            status_combo.FormattingEnabled = true;
            status_combo.Location = new Point(288, 355);
            status_combo.Margin = new Padding(3, 4, 3, 4);
            status_combo.Name = "status_combo";
            status_combo.Size = new Size(82, 31);
            status_combo.TabIndex = 44;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(298, 423);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 52);
            button1.TabIndex = 43;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // OK_btn
            // 
            OK_btn.DialogResult = DialogResult.OK;
            OK_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OK_btn.Location = new Point(425, 423);
            OK_btn.Margin = new Padding(3, 4, 3, 4);
            OK_btn.Name = "OK_btn";
            OK_btn.Size = new Size(120, 52);
            OK_btn.TabIndex = 42;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = true;
            OK_btn.Click += OK_btn_Click;
            // 
            // store_combo
            // 
            store_combo.Font = new Font("Segoe UI", 10F);
            store_combo.FormattingEnabled = true;
            store_combo.Location = new Point(463, 355);
            store_combo.Margin = new Padding(3, 4, 3, 4);
            store_combo.Name = "store_combo";
            store_combo.Size = new Size(82, 31);
            store_combo.TabIndex = 41;
            // 
            // remarks_text
            // 
            remarks_text.Font = new Font("Segoe UI", 10F);
            remarks_text.Location = new Point(90, 355);
            remarks_text.Margin = new Padding(3, 4, 3, 4);
            remarks_text.Name = "remarks_text";
            remarks_text.Size = new Size(165, 30);
            remarks_text.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 359);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 39;
            label9.Text = "Remarks : ";
            // 
            // Products_text
            // 
            Products_text.Font = new Font("Segoe UI", 10F);
            Products_text.Location = new Point(379, 283);
            Products_text.Margin = new Padding(3, 4, 3, 4);
            Products_text.Name = "Products_text";
            Products_text.Size = new Size(165, 30);
            Products_text.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 287);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 37;
            label8.Text = "Products : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 287);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 35;
            label7.Text = "Category : ";
            // 
            // Source_text
            // 
            Source_text.Font = new Font("Segoe UI", 10F);
            Source_text.Location = new Point(379, 220);
            Source_text.Margin = new Padding(3, 4, 3, 4);
            Source_text.Name = "Source_text";
            Source_text.Size = new Size(165, 30);
            Source_text.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 224);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 33;
            label6.Text = "Source : ";
            // 
            // phone_text
            // 
            phone_text.Font = new Font("Segoe UI", 10F);
            phone_text.Location = new Point(90, 220);
            phone_text.Margin = new Padding(3, 4, 3, 4);
            phone_text.MaxLength = 55;
            phone_text.Name = "phone_text";
            phone_text.Size = new Size(165, 30);
            phone_text.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 224);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 31;
            label5.Text = "Phone : ";
            // 
            // pin_text
            // 
            pin_text.Font = new Font("Segoe UI", 10F);
            pin_text.Location = new Point(379, 160);
            pin_text.Margin = new Padding(3, 4, 3, 4);
            pin_text.MaxLength = 6;
            pin_text.Name = "pin_text";
            pin_text.Size = new Size(165, 30);
            pin_text.TabIndex = 30;
            pin_text.KeyPress += pin_text_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 164);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 29;
            label4.Text = "Pin : ";
            // 
            // area_text
            // 
            area_text.Font = new Font("Segoe UI", 10F);
            area_text.Location = new Point(90, 160);
            area_text.Margin = new Padding(3, 4, 3, 4);
            area_text.Name = "area_text";
            area_text.Size = new Size(165, 30);
            area_text.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 164);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 27;
            label3.Text = "Area";
            // 
            // name_text
            // 
            name_text.Font = new Font("Segoe UI", 10F);
            name_text.Location = new Point(90, 104);
            name_text.Margin = new Padding(3, 4, 3, 4);
            name_text.Name = "name_text";
            name_text.Size = new Size(165, 30);
            name_text.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 108);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 25;
            label2.Text = "Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(221, 50);
            label1.TabIndex = 24;
            label1.Text = "Edit Walkin";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(294, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 30);
            dateTimePicker1.TabIndex = 46;
            // 
            // category_text
            // 
            category_text.Font = new Font("Segoe UI", 10F);
            category_text.FormattingEnabled = true;
            category_text.Location = new Point(98, 283);
            category_text.Margin = new Padding(2, 2, 2, 2);
            category_text.Name = "category_text";
            category_text.Size = new Size(106, 31);
            category_text.TabIndex = 47;
            category_text.SelectedIndexChanged += category_text_SelectedIndexChanged;
            // 
            // add_category
            // 
            add_category.Font = new Font("Impact", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_category.Location = new Point(208, 283);
            add_category.Margin = new Padding(2, 2, 2, 2);
            add_category.Name = "add_category";
            add_category.Size = new Size(46, 29);
            add_category.TabIndex = 50;
            add_category.Text = "+";
            add_category.UseVisualStyleBackColor = true;
            add_category.Click += add_category_Click;
            // 
            // Category_list_lbl
            // 
            Category_list_lbl.AutoSize = true;
            Category_list_lbl.Location = new Point(38, 320);
            Category_list_lbl.Margin = new Padding(2, 0, 2, 0);
            Category_list_lbl.Name = "Category_list_lbl";
            Category_list_lbl.Size = new Size(0, 20);
            Category_list_lbl.TabIndex = 51;
            // 
            // Delete_btn
            // 
            Delete_btn.DialogResult = DialogResult.Cancel;
            Delete_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_btn.Location = new Point(12, 423);
            Delete_btn.Margin = new Padding(3, 4, 3, 4);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(120, 52);
            Delete_btn.TabIndex = 52;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // edit_walkin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 503);
            Controls.Add(Delete_btn);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button Delete_btn;
    }
}