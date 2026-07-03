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
                DataGridViewRow row =
                    dgvManageOrders.Rows[e.RowIndex];

                txtOrderID.Text =
                    row.Cells["OrderId"].Value.ToString();

                txtCustomerMobileNumber.Text =
                    row.Cells["CustomerMobile"].Value.ToString();

                txtCustomerAddress.Text =
                    row.Cells["DeliveryAddress"].Value.ToString();

                cmbOrderStatus.Text =
                    row.Cells["Status"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOrderID.Text);

            string status = cmbOrderStatus.Text;

            bool success =
                controller.UpdateStatus(id, status);

            if (success)
            {
                MessageBox.Show("Order Updated");

                LoadOrders();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOrderID.Text);

            bool success =
                controller.DeleteOrder(id);

            if (success)
            {
                MessageBox.Show("Deleted");

                LoadOrders();
            }
        }

        private void LoadOrders()
        {
            dgvManageOrders.DataSource = null;
            dgvManageOrders.AutoGenerateColumns = true;
            dgvManageOrders.DataSource = controller.GetOrders();

            dgvManageOrders.ClearSelection();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvManageOrders.DataSource = controller.SearchOrders(txtSearch.Text);
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
