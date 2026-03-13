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
            from_date = new DateTimePicker();
            to_date = new DateTimePicker();
            fromdate_lbl = new Label();
            todate_lbl = new Label();
            settings_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)report_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staff_report_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealBarChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)warm_grid).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(853, 348);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(200, 55);
            button1.TabIndex = 0;
            button1.Text = "Table";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(853, 494);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(200, 55);
            button2.TabIndex = 1;
            button2.Text = "Test connection";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // connect_lbl
            // 
            connect_lbl.AutoSize = true;
            connect_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            connect_lbl.Location = new Point(895, 570);
            connect_lbl.Name = "connect_lbl";
            connect_lbl.Size = new Size(119, 28);
            connect_lbl.TabIndex = 2;
            connect_lbl.Text = "Connection";
            // 
            // report_grid
            // 
            report_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            report_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            report_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            report_grid.Location = new Point(14, 16);
            report_grid.Margin = new Padding(3, 4, 3, 4);
            report_grid.Name = "report_grid";
            report_grid.RowHeadersWidth = 51;
            report_grid.Size = new Size(346, 171);
            report_grid.TabIndex = 3;
            // 
            // staff_report_grid
            // 
            staff_report_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            staff_report_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            staff_report_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staff_report_grid.Location = new Point(14, 195);
            staff_report_grid.Margin = new Padding(3, 4, 3, 4);
            staff_report_grid.Name = "staff_report_grid";
            staff_report_grid.RowHeadersWidth = 51;
            staff_report_grid.Size = new Size(203, 332);
            staff_report_grid.TabIndex = 4;
            // 
            // statusChart
            // 
            statusChart.Location = new Point(224, 195);
            statusChart.Margin = new Padding(3, 4, 3, 4);
            statusChart.Name = "statusChart";
            statusChart.Size = new Size(485, 332);
            statusChart.TabIndex = 5;
            statusChart.Text = "chart1";
            // 
            // dealBarChart
            // 
            dealBarChart.Location = new Point(14, 535);
            dealBarChart.Margin = new Padding(3, 4, 3, 4);
            dealBarChart.Name = "dealBarChart";
            dealBarChart.Size = new Size(695, 165);
            dealBarChart.TabIndex = 6;
            dealBarChart.Text = "chart1";
            // 
            // warm_grid
            // 
            warm_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            warm_grid.Location = new Point(367, 16);
            warm_grid.Margin = new Padding(3, 4, 3, 4);
            warm_grid.Name = "warm_grid";
            warm_grid.RowHeadersWidth = 51;
            warm_grid.Size = new Size(342, 171);
            warm_grid.TabIndex = 7;
            // 
            // from_date
            // 
            from_date.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            from_date.Location = new Point(819, 122);
            from_date.Name = "from_date";
            from_date.Size = new Size(250, 32);
            from_date.TabIndex = 8;
            from_date.ValueChanged += from_date_ValueChanged;
            // 
            // to_date
            // 
            to_date.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            to_date.Location = new Point(819, 234);
            to_date.Name = "to_date";
            to_date.Size = new Size(250, 32);
            to_date.TabIndex = 9;
            to_date.ValueChanged += to_date_ValueChanged;
            // 
            // fromdate_lbl
            // 
            fromdate_lbl.AutoSize = true;
            fromdate_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fromdate_lbl.Location = new Point(906, 79);
            fromdate_lbl.Name = "fromdate_lbl";
            fromdate_lbl.Size = new Size(80, 31);
            fromdate_lbl.TabIndex = 10;
            fromdate_lbl.Text = "FROM";
            // 
            // todate_lbl
            // 
            todate_lbl.AutoSize = true;
            todate_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todate_lbl.Location = new Point(919, 195);
            todate_lbl.Name = "todate_lbl";
            todate_lbl.Size = new Size(43, 31);
            todate_lbl.TabIndex = 11;
            todate_lbl.Text = "TO";
            // 
            // settings_btn
            // 
            settings_btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settings_btn.Location = new Point(853, 420);
            settings_btn.Margin = new Padding(3, 4, 3, 4);
            settings_btn.Name = "settings_btn";
            settings_btn.Size = new Size(200, 55);
            settings_btn.TabIndex = 12;
            settings_btn.Text = "Settings";
            settings_btn.UseVisualStyleBackColor = true;
            settings_btn.Click += settings_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 721);
            Controls.Add(settings_btn);
            Controls.Add(todate_lbl);
            Controls.Add(fromdate_lbl);
            Controls.Add(to_date);
            Controls.Add(from_date);
            Controls.Add(warm_grid);
            Controls.Add(dealBarChart);
            Controls.Add(statusChart);
            Controls.Add(staff_report_grid);
            Controls.Add(report_grid);
            Controls.Add(connect_lbl);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Walk In Report";
            Load += Form1_Load;
            Shown += Form1_Shown;
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
        private DateTimePicker from_date;
        private DateTimePicker to_date;
        private Label fromdate_lbl;
        private Label todate_lbl;
        private Button settings_btn;
    }
}
