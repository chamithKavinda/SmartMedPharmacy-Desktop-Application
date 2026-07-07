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
    public partial class AdminMedicinesManageForm : Form
    {
        private MedicineController _medicineController;

        public AdminMedicinesManageForm()
        {
            InitializeComponent();
            _medicineController = new MedicineController();
            LoadMedicineData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateMedicineInput())
                return;

            string result = _medicineController.SaveMedicine(
                txtName.Text,
                Convert.ToInt32(txtStock.Text),
                comboMedicineCategory.Text,
                txtSupplier.Text,
                Convert.ToDecimal(txtPrice.Text),
                txtDosage.Text,
                dateTimePicker1.Value
            );

            if (result == null)
            {
                MessageBox.Show("Medicine saved successfully.");
                ClearForm();
                LoadMedicineData();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateMedicineInput())
                return;

            string result = _medicineController.UpdateMedicine(
                txtName.Text,
                Convert.ToInt32(txtStock.Text),
                comboMedicineCategory.Text,
                txtSupplier.Text,
                Convert.ToDecimal(txtPrice.Text),
                txtDosage.Text,
                dateTimePicker1.Value
            );

            if (result == null)
            {
                MessageBox.Show("Medicine updated successfully.");
                ClearForm();
                LoadMedicineData();
            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Select medicine first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this medicine?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string response = _medicineController.DeleteMedicine(txtName.Text);

                if (response == null)
                {
                    MessageBox.Show("Medicine deleted successfully.");
                    ClearForm();
                    LoadMedicineData();
                }
                else
                {
                    MessageBox.Show(response);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Enter medicine name to search.");
                txtSearch.Focus();
                return;
            }

            Medicine medicine = _medicineController.SearchMedicine(txtSearch.Text);

            if (medicine != null)
            {
                List<Medicine> list = new List<Medicine>();
                list.Add(medicine);
                dgvMedicines.DataSource = null;
                dgvMedicines.DataSource = list;
            }
            else
            {
                MessageBox.Show("Medicine not found.");
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtStock.Clear();
            comboMedicineCategory.SelectedIndex = -1;
            txtSupplier.Clear();
            txtPrice.Clear();
            txtDosage.Clear();
            txtSearch.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void LoadMedicineData()
        {
            dgvMedicines.DataSource = null;
            dgvMedicines.DataSource = _medicineController.GetAllMedicines();
        }

        private void dgvMedicines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicines.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                comboMedicineCategory.Text = row.Cells["Category"].Value.ToString();
                txtSupplier.Text = row.Cells["Supplier"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtDosage.Text = row.Cells["Dosage"].Value.ToString();

                dateTimePicker1.Value =
                    Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();

            dgvMedicines.DataSource = null;
            LoadMedicineData();

            dgvMedicines.ClearSelection();
        }

        private bool ValidateMedicineInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter medicine name.");
                txtName.Focus();
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Enter valid stock quantity.");
                txtStock.Focus();
                return false;
            }

            if (stock < 0)
            {
                MessageBox.Show("Stock cannot be negative.");
                txtStock.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboMedicineCategory.Text))
            {
                MessageBox.Show("Select medicine category.");
                comboMedicineCategory.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("Enter supplier name.");
                txtSupplier.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Enter valid price.");
                txtPrice.Focus();
                return false;
            }

            if (price <= 0)
            {
                MessageBox.Show("Price must be greater than zero.");
                txtPrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDosage.Text))
            {
                MessageBox.Show("Enter dosage.");
                txtDosage.Focus();
                return false;
            }

            if (dateTimePicker1.Value <= DateTime.Today)
            {
                MessageBox.Show("Expiry date must be future date.");
                dateTimePicker1.Focus();
                return false;
            }

            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelManageMedicineTitle_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboMedicineCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDosage_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AdminMedicinesManageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
