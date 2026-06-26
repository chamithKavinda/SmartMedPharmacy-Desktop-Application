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

namespace SmartMedPharmacy.Forms
{
    public partial class AdminCustomerManageForm : Form
    {
        private readonly UserController _userController;
        public AdminCustomerManageForm()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void AdminCustomerManageForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvCustomers.DataSource = _userController.GetAllUsers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string role = radioBtnAdmin.Checked ? "Admin" : "Customer";

            string result = _userController.Register(
                txtMobileNumber.Text,
                txtEmail.Text,
                textAddress.Text,
                txtPassword.Text,
                role
            );

            if (result == null)
            {
                MessageBox.Show("User saved successfully!");
                LoadUsers();
                ClearFields();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string role = radioBtnAdmin.Checked ? "Admin" : "Customer";

            string result = _userController.UpdateUser(
                txtMobileNumber.Text,
                txtEmail.Text,
                textAddress.Text,
                txtPassword.Text,
                role
            );

            if (result == null)
            {
                MessageBox.Show("User updated successfully!");
                LoadUsers();
                ClearFields();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string result = _userController.DeleteUser(txtMobileNumber.Text);

            if (result == null)
            {
                MessageBox.Show("User deleted successfully!");
                LoadUsers();
                ClearFields();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            User user = _userController.GetUserByMobile(txtSearch.Text);

            if (user != null)
            {
                List<User> list = new List<User>();
                list.Add(user);

                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = list;
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
            ClearFields();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                txtMobileNumber.Text = row.Cells["MobileNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                textAddress.Text = row.Cells["Address"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();

                string role = row.Cells["Role"].Value.ToString();

                if (role == "Admin")
                    radioBtnAdmin.Checked = true;
                else
                    radioBtnCustomer.Checked = true;
            }
        }

        private void ClearFields()
        {
            txtMobileNumber.Clear();
            txtEmail.Clear();
            textAddress.Clear();
            txtPassword.Clear();
            txtSearch.Clear();

            radioBtnCustomer.Checked = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnCustomer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
