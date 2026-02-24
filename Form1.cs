using FastReport.DataVisualization.Charting;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Windows.Forms;


namespace Walkin_Report
{
    public partial class Form1 : Form
    {
        DBManager db = new DBManager();
        List<Store> stores = new List<Store>();
        List<Category> categories = new List<Category>();
        List<Walkin> walkins = new List<Walkin>();
        List<Staff> staffList = new List<Staff>();
        public Form1()
        {
            InitializeComponent();
            connect_lbl.Text = "FALSE";
            connect_lbl.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test_conn();
        }

        private void Test_conn()
        {
            bool connect = db.test_connection();
            if (connect)
            {
                connect_lbl.Text = "TRUE";
                connect_lbl.ForeColor = Color.Green;
            }
            else
            {
                connect_lbl.Text = "FALSE";
                connect_lbl.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Summary sm = new Summary();
            sm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test_conn();
            stores = db.GetAllStores();
            categories = db.GetAllCategories();
            walkins = db.GetAllWalkins();
            DateTime fromDate = from_date.Value.Date;
            DateTime toDate = to_date.Value.Date.AddDays(1).AddTicks(-1);
            walkins = walkins
                        .Where(w => w.CreatedAt >= fromDate && w.CreatedAt <= toDate)
                        .ToList();
            staffList = db.GetAllStaff();
            SetupReportGrid();
            PopulateReportGrid();
            SetupStaffReportGrid();
            PopulateStaffReportGrid();
            LoadStatusPieChart();
            LoadDealBarChart();
            SetupWarmGrid();
            LoadWarmGrid();
        }


        private void LoadWarmGrid()
        {
            SetupWarmGrid();

            var warmWalkins = walkins.Where(w =>
                !string.IsNullOrEmpty(w.Status) &&
                w.Status.ToLower() == "warm"
            );

            foreach (Walkin w in warmWalkins)
            {
                int rowIndex = warm_grid.Rows.Add(
                    w.Name,
                    w.Status,
                    w.Products,
                    w.Remarks
                );

                warm_grid.Rows[rowIndex].Tag = w;
            }
        }



        private void SetupWarmGrid()
        {
            warm_grid.Columns.Clear();
            warm_grid.Rows.Clear();

            warm_grid.AllowUserToAddRows = false;
            warm_grid.ReadOnly = true;
            warm_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            warm_grid.AutoGenerateColumns = false;

            warm_grid.Columns.Add("name", "NAME");
            warm_grid.Columns.Add("status", "STATUS");
            warm_grid.Columns.Add("products", "PRODUCTS");
            warm_grid.Columns.Add("remarks", "REMARKS");

            warm_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        private void LoadDealBarChart()
        {
            dealBarChart.Series.Clear();
            dealBarChart.ChartAreas.Clear();
            dealBarChart.Legends.Clear();

            // Chart area
            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Category";
            area.AxisY.Title = "Number of Deals";
            area.AxisX.Interval = 1; // show all category labels
            dealBarChart.ChartAreas.Add(area);

            // Legend
            Legend legend = new Legend("Stores");
            dealBarChart.Legends.Add(legend);

            // Create one series per store
            foreach (Store store in stores)
            {
                FastReport.DataVisualization.Charting.Series series = new FastReport.DataVisualization.Charting.Series(store.Sym)
                {
                    ChartType = SeriesChartType.Column, // BAR GRAPH
                    IsValueShownAsLabel = true
                };

                // For each category, count DEALS
                foreach (Category category in categories)
                {
                    int count = walkins.Count(w =>
                        w.Status?.ToLower() == "deal" &&
                        w.Store == store.Sym &&
                        w.Category == category.Name
                    );

                    series.Points.AddXY(category.Name, count);
                }

                dealBarChart.Series.Add(series);
            }

            // Optional title
            dealBarChart.Titles.Clear();
            dealBarChart.Titles.Add("Deals by Category and Store");
        }


        private void LoadStatusPieChart()
        {
            statusChart.Series.Clear();
            statusChart.ChartAreas.Clear();
            statusChart.Legends.Clear();

            // Chart area
            ChartArea area = new ChartArea("MainArea");
            statusChart.ChartAreas.Add(area);

            // Legend
            Legend legend = new Legend("Legend");
            statusChart.Legends.Add(legend);

            // Series
            FastReport.DataVisualization.Charting.Series series = new FastReport.DataVisualization.Charting.Series("Statuses");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;

            // Group walkins by status
            var grouped = walkins
                .Where(w => !string.IsNullOrEmpty(w.Status))
                .GroupBy(w => w.Status)
                .Select(g => new
                {
                    Status = g.Key,
                    Count = g.Count()
                });

            foreach (var g in grouped)
            {
                series.Points.AddXY(g.Status, g.Count);
            }

            statusChart.Series.Add(series);

            // Optional title
            statusChart.Titles.Clear();
            statusChart.Titles.Add("Walkins by Status");
        }



        private void PopulateStaffReportGrid()
        {
            foreach (Staff s in staffList)
            {
                int dealCount = walkins.Count(w =>
                    w.Status?.ToLower() == "deal" &&
                    w.Team == s.Sym
                );

                int rowIndex = staff_report_grid.Rows.Add(
                    s.Name,   // or s.Sym
                    dealCount
                );

                staff_report_grid.Rows[rowIndex].Tag = s;
            }
        }


        private void SetupStaffReportGrid()
        {
            staff_report_grid.Columns.Clear();
            staff_report_grid.Rows.Clear();

            staff_report_grid.AllowUserToAddRows = false;
            staff_report_grid.ReadOnly = true;
            staff_report_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            staff_report_grid.Columns.Add("staff", "STAFF");
            staff_report_grid.Columns.Add("deals", "DEALS");
        }


        private void PopulateReportGrid()
        {
            foreach (DataGridViewRow row in report_grid.Rows)
            {
                string categoryName = row.Cells[0].Value.ToString();

                foreach (Store store in stores)
                {
                    int count = walkins.Count(w =>
                        w.Status?.ToLower() == "deal" &&
                        w.Store == store.Sym &&
                        w.Category == categoryName
                    );

                    row.Cells[store.Sym].Value = count;
                }
            }
        }


        private void SetupReportGrid()
        {
            report_grid.Columns.Clear();
            report_grid.Rows.Clear();

            report_grid.AllowUserToAddRows = false;
            report_grid.ReadOnly = true;

            // First column = Category name
            report_grid.Columns.Add("category", "CATEGORY");

            // Store columns (X axis)
            foreach (Store s in stores)
            {
                report_grid.Columns.Add(s.Sym, s.Sym);
            }

            // Add rows (Y axis)
            foreach (Category c in categories)
            {
                int rowIndex = report_grid.Rows.Add();
                report_grid.Rows[rowIndex].Cells[0].Value = c.Sym;
                report_grid.Rows[rowIndex].Tag = c; // store category object
            }
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            set.ShowDialog();
        }

        private void from_date_ValueChanged(object sender, EventArgs e)
        {
            walkins = db.GetAllWalkins();
            DateTime fromDate = from_date.Value.Date;
            DateTime toDate = to_date.Value.Date.AddDays(1).AddTicks(-1);
            walkins = walkins
                        .Where(w => w.CreatedAt >= fromDate && w.CreatedAt <= toDate)
                        .ToList();
        }

        private void to_date_ValueChanged(object sender, EventArgs e)
        {
            walkins = db.GetAllWalkins();
            DateTime fromDate = from_date.Value.Date;
            DateTime toDate = to_date.Value.Date.AddDays(1).AddTicks(-1);
            walkins = walkins
                        .Where(w => w.CreatedAt >= fromDate && w.CreatedAt <= toDate)
                        .ToList();
        }
    }
}
