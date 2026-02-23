namespace Walkin_Report
{
    partial class Search
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
            parameter_combo_box = new ComboBox();
            result_label = new Label();
            search_text_box = new TextBox();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            show_btn = new Button();
            cancel_btn = new Button();
            SuspendLayout();
            // 
            // parameter_combo_box
            // 
            parameter_combo_box.FormattingEnabled = true;
            parameter_combo_box.Location = new Point(12, 46);
            parameter_combo_box.Name = "parameter_combo_box";
            parameter_combo_box.Size = new Size(151, 28);
            parameter_combo_box.TabIndex = 0;
            parameter_combo_box.SelectedIndexChanged += parameter_combo_box_SelectedIndexChanged;
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.Location = new Point(27, 109);
            result_label.Name = "result_label";
            result_label.Size = new Size(77, 20);
            result_label.TabIndex = 1;
            result_label.Text = "# Matches";
            // 
            // search_text_box
            // 
            search_text_box.Location = new Point(169, 47);
            search_text_box.Name = "search_text_box";
            search_text_box.Size = new Size(123, 27);
            search_text_box.TabIndex = 2;
            search_text_box.TextChanged += search_text_box_TextChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(298, 46);
            button1.Name = "button1";
            button1.Size = new Size(66, 29);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 151);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(352, 310);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // show_btn
            // 
            show_btn.Location = new Point(247, 479);
            show_btn.Name = "show_btn";
            show_btn.Size = new Size(117, 50);
            show_btn.TabIndex = 5;
            show_btn.Text = "Show";
            show_btn.UseVisualStyleBackColor = true;
            show_btn.Click += show_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(12, 479);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(117, 50);
            cancel_btn.TabIndex = 6;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 541);
            Controls.Add(cancel_btn);
            Controls.Add(show_btn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(search_text_box);
            Controls.Add(result_label);
            Controls.Add(parameter_combo_box);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Search";
            Text = "Search";
            Load += Search_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox parameter_combo_box;
        private Label result_label;
        private TextBox search_text_box;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button show_btn;
        private Button cancel_btn;
    }
}