using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMedPharmacy.Forms.Customer
{
    public partial class CustomerDashboard : Form
    {
        //private string loggedUserEmail;
        //private Timer timer = new Timer();
        public CustomerDashboard()
        {
            InitializeComponent();

            //loggedUserEmail = email;

            //lblWelcomeTitle.Text = "Logging as " + loggedUserEmail;

            LoadForm(new CustomerDashboardStatsForm());

            //StartDateTime();
        }

        private void LoadForm(Form childForm)
        {
            panelCustomerFormsLoadForm.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelCustomerFormsLoadForm.Controls.Add(childForm);
            panelCustomerFormsLoadForm.Tag = childForm;

            childForm.Show();
        }

        private void CustomerDashboardSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcomeTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblQuickView_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcomeTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTime_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new CustomerDashboardStatsForm());
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            LoadForm(new CustomerMedicineForm());
        }

        private void btnPlaceOrders_Click(object sender, EventArgs e)
        {
            LoadForm(new CustomerPlaceOrderForm());
        }

        private void btnTrackOrders_Click(object sender, EventArgs e)
        {
            LoadForm(new CustomerTrackOrderForm());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadForm(new CustomerProfileForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void lblDate_Click_1(object sender, EventArgs e)
        {

        }

        private void panelCustomerFormsLoadForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
