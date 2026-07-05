using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartMedPharmacy.Controller;

namespace SmartMedPharmacy.Forms
{
    public partial class RegisterForm : Form
    {

        private readonly UserController _userController;

        public RegisterForm()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string mobile = txtMobileNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text;
            string defaultRole = "Customer";      

            string errorMessage = _userController.Register(mobile, email, address, password, defaultRole);

            if (errorMessage == null)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormFields();

                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show(errorMessage, "Validation Error...Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFormFields()
        {
            txtMobileNumber.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
        }

        private void lnkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
