using SmartMedPharmacy.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartMedPharmacy.Forms
{
    public partial class AdminReportsForm : Form
    {

        ReportRepository repo = new ReportRepository();
        public AdminReportsForm()
        {
            InitializeComponent();
        }

        private void AdminReportsForm_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Today.AddMonths(-1);
            dtpToDate.Value = DateTime.Today;

            txtTotalSales.Text = repo.GetTotalSales(dtpFromDate.Value,dtpToDate.Value).ToString("0.00");

            txtTotalOrders.Text = repo.GetTotalOrders(dtpFromDate.Value,dtpToDate.Value).ToString();

            txtTotalStockCount.Text = repo.GetTotalStock().ToString();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = repo.GetSalesReport(dtpFromDate.Value,dtpToDate.Value);

            txtTotalSales.Text = repo.GetTotalSales(dtpFromDate.Value,dtpToDate.Value).ToString("0.00");

            txtTotalOrders.Text = repo.GetTotalOrders(dtpFromDate.Value,dtpToDate.Value).ToString();
        }

        private void btnStockReport_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = repo.GetStockReport();

            txtTotalStockCount.Text = repo.GetTotalStock().ToString();
        }

        private void btnCustomerOrderHistory_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = repo.GetDeliveredOrders();
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "CSV (*.csv)|*.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    for (int i = 0; i < dgvReports.Columns.Count; i++)
                    {
                        writer.Write(dgvReports.Columns[i].HeaderText);

                        if (i < dgvReports.Columns.Count - 1)
                            writer.Write(",");
                    }

                    writer.WriteLine();

                    foreach (DataGridViewRow row in dgvReports.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dgvReports.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);

                                if (i < dgvReports.Columns.Count - 1)
                                    writer.Write(",");
                            }

                            writer.WriteLine();
                        }
                    }
                }

                MessageBox.Show("CSV Exported Successfully!");
            }
        }

        private void labelOrderID_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalSales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalOrders_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalStockCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
