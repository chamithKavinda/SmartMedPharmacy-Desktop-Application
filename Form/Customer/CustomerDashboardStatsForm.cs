using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartMedPharmacy.Repository;
using SmartMedPharmacy.Utill;
using SmartMedPharmacy.Models;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartMedPharmacy.Forms.Customer
{
    public partial class CustomerDashboardStatsForm : Form
    {
        private TrackOrderRepository orderRepo = new TrackOrderRepository();

        public CustomerDashboardStatsForm()
        {
            InitializeComponent();
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            if (Session.CurrentUser == null)
                return;

            TrackOrderRepository repo = new TrackOrderRepository();

            string mobile = Session.CurrentUser.MobileNumber;

            label1.Text = repo.GetActiveOrdersCount(mobile).ToString();

            List<Order> orders = repo.GetCustomerOrders(mobile);

            dataGridView1.DataSource = orders.Select(o => new
            {
                o.OrderId,
                Date = o.OrderDate.ToString("yyyy-MM-dd"),
                o.DeliveryType,
                o.TotalAmount,
                o.Status
            }).ToList();

            // Chart
            chart1.Series["Series1"].Points.Clear();

            foreach (Order order in orders.OrderBy(o => o.OrderDate))
            {
                chart1.Series["Series1"].Points.AddXY(
                    order.OrderDate.ToString("dd/MM"),
                    order.TotalAmount
                );
            }
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
