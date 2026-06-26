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
            {
                ClearForm();
                LoadMedicineData();
            }
                
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
            {
                ClearForm();
                LoadMedicineData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string result = _medicineController.DeleteMedicine(txtName.Text);

            MessageBox.Show(result ?? "Medicine Deleted Successfully");

            if (result == null)
            {
                ClearForm();
                LoadMedicineData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Medicine not found");
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
    }
}
