using SmartMedPharmacy.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartMedPharmacy.Utill;
using SmartMedPharmacy.Models;

namespace SmartMedPharmacy
{
    public partial class CustomerTrackOrderForm : Form
    {
        private TrackOrderController controller = new TrackOrderController();

        private List<Order> orders = new List<Order>();

        private int selectedOrderId = -1;
        public CustomerTrackOrderForm()
        {
            InitializeComponent();
        }

        private void CustomerTrackOrderForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            if (Session.CurrentUser != null)
            {
                string mobile = Session.CurrentUser.MobileNumber;
                orders = controller.GetOrders(mobile);
            }
            else
            {
                MessageBox.Show("No active user session found.");
                return;
            }

            dgvOrders.DataSource = null;

            dgvOrders.DataSource = orders.Select(o => new
            {
                o.OrderId,
                o.OrderDate,
                o.TotalAmount,
                o.Status
             }).ToList();
        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int orderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["OrderId"].Value);

            Order order = orders.FirstOrDefault(x => x.OrderId == orderId);

            if (order == null)
                return;

            selectedOrderId = order.OrderId;

            lblOrderID.Text = order.OrderId.ToString();

            lblOrderDate.Text = order.OrderDate.ToString();

            lblOrderStatus.Text = order.Status;

            lblTotalAmount.Text = "Rs " + order.TotalAmount;
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == -1)
            {
                MessageBox.Show("Please select an order");
                return;
            }

            Order selected = orders.FirstOrDefault( x => x.OrderId == selectedOrderId);

            if (selected.Status != "Pending")
            {
                MessageBox.Show("Only pending orders can be cancelled");
                return;
            }

            DialogResult result = MessageBox.Show("Cancel this order?","Confirm",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                bool success =
                    controller.CancelOrder(selectedOrderId);

                if (success)
                {
                    MessageBox.Show("Order cancelled");
                    LoadOrders();
                    ClearLabels();
                }
            }
        }

        private void ClearLabels()
        {
            lblOrderID.Text = "";
            lblOrderDate.Text = "";
            lblOrderStatus.Text = "";
            lblTotalAmount.Text = "";
            selectedOrderId = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblOrderID_Click(object sender, EventArgs e)
        {

        }

        private void lblOrderDate_Click(object sender, EventArgs e)
        {

        }

        private void lblOrderStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }

        
    }
}
