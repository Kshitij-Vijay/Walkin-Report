namespace Walkin_Report
{
    partial class quer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            para_label = new Label();
            key_label = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // para_label
            // 
            para_label.AutoSize = true;
            para_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            para_label.Location = new Point(12, 7);
            para_label.Name = "para_label";
            para_label.Size = new Size(46, 23);
            para_label.TabIndex = 0;
            para_label.Text = "para";
            // 
            // key_label
            // 
            key_label.AutoSize = true;
            key_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            key_label.Location = new Point(133, 7);
            key_label.Name = "key_label";
            key_label.Size = new Size(38, 23);
            key_label.TabIndex = 1;
            key_label.Text = "key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(90, 7);
            label3.Name = "label3";
            label3.Size = new Size(15, 23);
            label3.TabIndex = 2;
            label3.Text = ":";
            // 
            // quer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(key_label);
            Controls.Add(para_label);
            Name = "quer";
            Size = new Size(208, 39);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label para_label;
        private Label key_label;
        private Label label3;
    }
}
