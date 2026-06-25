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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string result = _medicineController.SaveMedicine(
                txtName.Text,
                int.Parse(txtStock.Text),
                comboMedicineCategory.Text,
                txtSupplier.Text,
                decimal.Parse(txtPrice.Text),
                txtDosage.Text,
                dateTimePicker1.Value
            );

            MessageBox.Show(result ?? "Medicine Saved Successfully");

            if (result == null)
                ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string result = _medicineController.UpdateMedicine(
                txtName.Text,
                int.Parse(txtStock.Text),
                comboMedicineCategory.Text,
                txtSupplier.Text,
                decimal.Parse(txtPrice.Text),
                txtDosage.Text,
                dateTimePicker1.Value
            );

            MessageBox.Show(result ?? "Medicine Updated Successfully");

            if (result == null)
                ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string result = _medicineController.DeleteMedicine(txtName.Text);

            MessageBox.Show(result ?? "Medicine Deleted Successfully");

            if (result == null)
                ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Medicine medicine = _medicineController.SearchMedicine(txtSearch.Text);

            if (medicine != null)
            {
                txtName.Text = medicine.Name;
                txtStock.Text = medicine.Stock.ToString();
                comboMedicineCategory.Text = medicine.Category;
                txtSupplier.Text = medicine.Supplier;
                txtPrice.Text = medicine.Price.ToString();
                txtDosage.Text = medicine.Dosage;
                dateTimePicker1.Value = medicine.ExpiryDate;
            }
            else
            {
                MessageBox.Show("Medicine Out Of Stock");
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

        private void dgvMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


    }
}
