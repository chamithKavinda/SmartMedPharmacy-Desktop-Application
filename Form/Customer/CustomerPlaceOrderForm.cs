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
using SmartMedPharmacy.Utill;

namespace SmartMedPharmacy.Forms.Customer
{
    public partial class CustomerPlaceOrderForm : Form
    {
        private PlaceOrderController controller = new PlaceOrderController();

        public CustomerPlaceOrderForm()
        {
            InitializeComponent();
        }

        private void CustomerPlaceOrderForm_Load(object sender, EventArgs e)
        {
            LoadCart();

            comboBox1.Items.Add("Pickup");
            comboBox1.Items.Add("Home Delivery");
        }

        private void LoadCart()
        {
            dgvCart.DataSource = null;

            dgvCart.DataSource = CartManager.Cart
                .Select(c => new
                {
                    c.MedicineId,
                    c.Name,
                    c.Price,
                    c.Quantity,
                    SubTotal = c.Price * c.Quantity
                })
                .ToList();

            decimal total = CartManager.Cart
                .Sum(c => c.Price * c.Quantity);

            textBox1.Text = total.ToString();
        }

        private void btnRemoveItem_Click( object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null)
                return;

            int medicineId =
                Convert.ToInt32(
                dgvCart.CurrentRow.Cells["MedicineId"].Value);

            var item = CartManager.Cart
                .FirstOrDefault(c =>
                    c.MedicineId == medicineId);

            if (item != null)
            {
                CartManager.Cart.Remove(item);

                LoadCart();
            }
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            CartManager.Cart.Clear();

            LoadCart();
        }


        private void comboBox1_SelectedDeliveryTypeIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Pickup")
            {
                txtAddress.Enabled = false;
                txtAddress.Clear();
            }
            else
            {
                txtAddress.Enabled = true;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (CartManager.Cart.Count == 0)
            {
                MessageBox.Show("Cart is empty");
                return;
            }

            Order order = new Order();

            if (Session.CurrentUser != null)
            {
                order.CustomerMobile = Session.CurrentUser.MobileNumber;
            }
            else
            {
                MessageBox.Show("No active user session found.");
                return;
            }

            order.OrderDate = DateTime.Now;

            order.DeliveryType = comboBox1.Text;

            order.DeliveryAddress = txtAddress.Text;

            order.TotalAmount = CartManager.Cart.Sum( x => x.Price * x.Quantity);

            order.Status = "Pending";

            order.Items = CartManager.Cart.Select(c => new OrderItem
            {
                MedicineId = c.MedicineId,
                Quantity = c.Quantity,
                Price = c.Price
             }).ToList();

            bool success =
                controller.PlaceOrder(order);

            if (success)
            {
                MessageBox.Show("Order placed successfully");

                CartManager.Cart.Clear();

                LoadCart();
            }
            else
            {
                MessageBox.Show("Order failed");
            }
        }

        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDiliveryAddress_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
