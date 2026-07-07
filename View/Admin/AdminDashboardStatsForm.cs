using SmartMedPharmacy.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartMedPharmacy.Forms.Admin
{
    public partial class AdminDashboardStatsForm : Form
    {
        public AdminDashboardStatsForm()
        {
            InitializeComponent();
        }

        private void groupBoxNewOrders_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxLowStockAerts_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboardStatsForm_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            AdminOrderRepository repo = new AdminOrderRepository();

            NewOrderLabel.Text = repo.GetNewOrdersCount().ToString();

            todaysRevenueLabel.Text = " $ " + repo.GetTodaysRevenue().ToString("N2");

            LowStockAlertsLabel.Text = repo.GetLowStockCount().ToString();

            chart1.Series["Series1"].Points.Clear();

            chart1.Series["Series1"].Points.AddXY("Jan", 75);
            chart1.Series["Series1"].Points.AddXY("Feb", 82);
            chart1.Series["Series1"].Points.AddXY("Mar", 70);
            chart1.Series["Series1"].Points.AddXY("Apr", 22);
            chart1.Series["Series1"].Points.AddXY("May", 80);
            chart1.Series["Series1"].Points.AddXY("Jun", 40);

            chart2.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart2.Series["Series1"].Points.Clear();

            chart2.Series["Series1"].Points.AddXY("Antibiotics", 35);
            chart2.Series["Series1"].Points.AddXY("Vitamins", 25);
            chart2.Series["Series1"].Points.AddXY("Pain Relievers", 20);
            chart2.Series["Series1"].Points.AddXY("Syrups", 15);
            chart2.Series["Series1"].Points.AddXY("Others", 5);

            chart2.Series["Series1"].IsValueShownAsLabel = true;
        }

        private void NewOrderLabel_Click(object sender, EventArgs e)
        {

        }

        private void LowStockAlertsLabel_Click(object sender, EventArgs e)
        {

        }

        private void todaysRevenueLabel_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
