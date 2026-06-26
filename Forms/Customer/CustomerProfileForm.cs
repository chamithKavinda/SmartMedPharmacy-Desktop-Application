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

namespace SmartMedPharmacy.Forms.Customer
{
    public partial class CustomerProfileForm : Form
    {
        private UserController _userController = new UserController();
        public CustomerProfileForm()
        {
            InitializeComponent();
        }

        private void CustomerProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("No logged in user.");
                return;
            }

            txtMobileNumber.Text = Session.CurrentUser.MobileNumber;
            txtEmail.Text = Session.CurrentUser.Email;
            txtAddress.Text = Session.CurrentUser.Address;

            txtPassword.Text = "";
            txtReEnterPassword.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete your account?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                string result = _userController.DeleteUser(
                    Session.CurrentUser.MobileNumber
                );

                if (result == null)
                {
                    MessageBox.Show("Account deleted.");

                    Session.CurrentUser = null;

                    Form dashboard = Application.OpenForms["CustomerDashboard"];
                    if (dashboard != null)
                    {
                        dashboard.Close();
                    }

                    RegisterForm registerForm = new RegisterForm();
                    registerForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string passwordToUse;
            bool passwordChanged;

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                passwordToUse = Session.CurrentUser.Password;
                passwordChanged = false;
            }
            else
            {
                if (txtPassword.Text != txtReEnterPassword.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                    return;
                }

                passwordToUse = txtPassword.Text;
                passwordChanged = true;
            }

            string result = _userController.UpdateUser(
                txtMobileNumber.Text,
                txtEmail.Text,
                txtAddress.Text,
                passwordToUse,
                "Customer",
                passwordChanged
            );

            if (result == null)
            {
                Session.CurrentUser.Email = txtEmail.Text;
                Session.CurrentUser.Address = txtAddress.Text;

                if (passwordChanged)
                {
                    Session.CurrentUser.Password = passwordToUse;
                }

                MessageBox.Show("Profile updated successfully!");
                LoadUserData();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReEnterPassword_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
