using SmartMedPharmacy.Controller;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartMedPharmacy.Forms
{
    public partial class AdminManageOrdersForm : Form
    {
        AdminOrderController controller = new AdminOrderController();

        public AdminManageOrdersForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void dgvManageOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvManageOrders.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(row.Cells["OrderId"].Value);
                string mobile = row.Cells["CustomerMobile"].Value.ToString();
                txtOrderID.Text = orderId.ToString();
                txtCustomerMobileNumber.Text = mobile;
                cmbOrderStatus.Text = row.Cells["Status"].Value?.ToString() ?? string.Empty;

                var customerDetails = controller.GetCustomerDetails(mobile);
                txtCustomerEmail.Text = customerDetails.Item1;
                txtCustomerAddress.Text = customerDetails.Item2;
                List<string> medicinesList = controller.GetOrderMedicines(orderId);
                txtMedicines.Text = string.Join(", ", medicinesList);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtOrderID.Text))
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            if (!int.TryParse(txtOrderID.Text, out int id))
            {
                MessageBox.Show("Invalid Order ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbOrderStatus.Text))
            {
                MessageBox.Show("Please select order status.");
                cmbOrderStatus.Focus();
                return;
            }

            bool result = controller.UpdateStatus(id, cmbOrderStatus.Text);

            if (result)
            {
                MessageBox.Show("Order updated successfully.");

                LoadOrders();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderID.Text))
            {
                MessageBox.Show("Please select an order.");
                return;
            }

            if (!int.TryParse(txtOrderID.Text, out int id))
            {
                MessageBox.Show("Invalid Order ID.");
                return;
            }

            DialogResult answer = MessageBox.Show("Do you want to delete this order?","Confirm Delete",MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                bool result = controller.DeleteOrder(id);

                if (result)
                {
                    MessageBox.Show("Order deleted successfully.");
                    LoadOrders();
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
        }

        private void LoadOrders()
        {
            dgvManageOrders.DataSource = null;
            dgvManageOrders.AutoGenerateColumns = true;
            var sortedOrders = controller.GetOrders().OrderByDescending(o => o.OrderDate).ToList();

            dgvManageOrders.DataSource = sortedOrders;
            dgvManageOrders.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Enter search value.");
                txtSearch.Focus();
                return;
            }

            var result = controller.SearchOrders(txtSearch.Text);

            if (result.Count > 0)
            {
                dgvManageOrders.DataSource = result;
            }
            else
            {
                MessageBox.Show("No orders found.");

                LoadOrders();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtOrderID.Clear();
            txtCustomerMobileNumber.Clear();
            txtCustomerAddress.Clear();
            txtSearch.Clear();
            txtCustomerEmail.Clear();
            txtMedicines.Clear();

            cmbOrderStatus.SelectedIndex = -1;
            cmbOrderStatus.Text = string.Empty;

            LoadOrders();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedicines_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }


        private void AdminManageOrdersForm_Load(object sender, EventArgs e)
        {

        }

    }
}
