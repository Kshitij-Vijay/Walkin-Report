namespace Walkin_Report
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            connect_lbl = new Label();
            report_grid = new DataGridView();
            staff_report_grid = new DataGridView();
            statusChart = new FastReport.DataVisualization.Charting.Chart();
            dealBarChart = new FastReport.DataVisualization.Charting.Chart();
            warm_grid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)report_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staff_report_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealBarChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)warm_grid).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(761, 60);
            button1.Name = "button1";
            button1.Size = new Size(146, 41);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(761, 117);
            button2.Name = "button2";
            button2.Size = new Size(146, 41);
            button2.TabIndex = 1;
            button2.Text = "Test connection";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // connect_lbl
            // 
            connect_lbl.AutoSize = true;
            connect_lbl.Location = new Point(819, 172);
            connect_lbl.Name = "connect_lbl";
            connect_lbl.Size = new Size(38, 15);
            connect_lbl.TabIndex = 2;
            connect_lbl.Text = "label1";
            // 
            // report_grid
            // 
            report_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            report_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            report_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            report_grid.Location = new Point(12, 12);
            report_grid.Name = "report_grid";
            report_grid.Size = new Size(303, 128);
            report_grid.TabIndex = 3;
            // 
            // staff_report_grid
            // 
            staff_report_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            staff_report_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            staff_report_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staff_report_grid.Location = new Point(12, 146);
            staff_report_grid.Name = "staff_report_grid";
            staff_report_grid.Size = new Size(178, 249);
            staff_report_grid.TabIndex = 4;
            // 
            // statusChart
            // 
            statusChart.Location = new Point(196, 146);
            statusChart.Name = "statusChart";
            statusChart.Size = new Size(424, 249);
            statusChart.TabIndex = 5;
            statusChart.Text = "chart1";
            // 
            // dealBarChart
            // 
            dealBarChart.Location = new Point(12, 401);
            dealBarChart.Name = "dealBarChart";
            dealBarChart.Size = new Size(608, 124);
            dealBarChart.TabIndex = 6;
            dealBarChart.Text = "chart1";
            // 
            // warm_grid
            // 
            warm_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            warm_grid.Location = new Point(321, 12);
            warm_grid.Name = "warm_grid";
            warm_grid.Size = new Size(299, 128);
            warm_grid.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 541);
            Controls.Add(warm_grid);
            Controls.Add(dealBarChart);
            Controls.Add(statusChart);
            Controls.Add(staff_report_grid);
            Controls.Add(report_grid);
            Controls.Add(connect_lbl);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Walk In Report";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)report_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)staff_report_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealBarChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)warm_grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label connect_lbl;
        private DataGridView report_grid;
        private DataGridView staff_report_grid;
        private FastReport.DataVisualization.Charting.Chart statusChart;
        private FastReport.DataVisualization.Charting.Chart dealBarChart;
        private DataGridView warm_grid;
    }
}
