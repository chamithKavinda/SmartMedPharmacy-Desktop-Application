using SmartMedPharmacy.Forms.Admin;
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

namespace SmartMedPharmacy.Forms
{
    public partial class AdminDashboard : Form
    {
        private Timer clockTimer = new Timer();

        public AdminDashboard()
        {
            InitializeComponent();
            LoadUserDetails();
            InitializeClock();
            LoadForm(new AdminDashboardStatsForm());
        }

        private void LoadForm(Form childForm)
        {
            AdminMainPanel.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            AdminMainPanel.Controls.Add(childForm);
            AdminMainPanel.Tag = childForm;
            childForm.Show();
        }

        private void AdminPannelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManageMedicines_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminMedicinesManageForm());
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminDashboardStatsForm());
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminCustomerManageForm());
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminManageOrdersForm());
        }

        private void LoadUserDetails()
        {
            if (Session.CurrentUser != null)
            {
                lblWelcomeTitle.Text = $"Welcome {Session.CurrentUser.Email} !";
            }
            else
            {
                lblWelcomeTitle.Text = "Welcome";
            }
        }

        private void InitializeClock()
        {
            clockTimer.Interval = 1000;

            clockTimer.Tick += (s, e) =>
            {
                lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            };

            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            clockTimer.Start();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AdminMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminReportsForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.CurrentUser = null;
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void lblWelcomeTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalSales_Click(object sender, EventArgs e)
        {

        }

        private void labelMedicineCount_Click(object sender, EventArgs e)
        {

        }

        private void labelActiveOrders_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
