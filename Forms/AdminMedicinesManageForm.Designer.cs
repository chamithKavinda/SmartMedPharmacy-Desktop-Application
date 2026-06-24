namespace SmartMedPharmacy.Forms
{
    partial class AdminMedicinesManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelManageMedicineTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.labeDosage = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelExpireDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboMedicineCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManageMedicineTitle
            // 
            this.labelManageMedicineTitle.AutoSize = true;
            this.labelManageMedicineTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelManageMedicineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageMedicineTitle.Location = new System.Drawing.Point(22, 19);
            this.labelManageMedicineTitle.Name = "labelManageMedicineTitle";
            this.labelManageMedicineTitle.Size = new System.Drawing.Size(139, 18);
            this.labelManageMedicineTitle.TabIndex = 0;
            this.labelManageMedicineTitle.Text = "Manage Medicine";
            this.labelManageMedicineTitle.Click += new System.EventHandler(this.labelManageMedicineTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 20);
            this.txtName.TabIndex = 2;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(60, 103);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(69, 13);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category : ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(63, 165);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(278, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(60, 149);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 13);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price :";
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(63, 213);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(278, 20);
            this.txtDosage.TabIndex = 8;
            // 
            // labeDosage
            // 
            this.labeDosage.AutoSize = true;
            this.labeDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeDosage.Location = new System.Drawing.Point(60, 196);
            this.labeDosage.Name = "labeDosage";
            this.labeDosage.Size = new System.Drawing.Size(62, 13);
            this.labeDosage.TabIndex = 7;
            this.labeDosage.Text = "Dosage : ";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(416, 73);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(278, 20);
            this.txtStock.TabIndex = 10;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(413, 57);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(48, 13);
            this.labelStock.TabIndex = 9;
            this.labelStock.Text = "Stock :";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(416, 120);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(278, 20);
            this.txtSupplier.TabIndex = 12;
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplier.Location = new System.Drawing.Point(413, 104);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(61, 13);
            this.labelSupplier.TabIndex = 11;
            this.labelSupplier.Text = "Supplier :";
            // 
            // labelExpireDate
            // 
            this.labelExpireDate.AutoSize = true;
            this.labelExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpireDate.Location = new System.Drawing.Point(413, 149);
            this.labelExpireDate.Name = "labelExpireDate";
            this.labelExpireDate.Size = new System.Drawing.Size(81, 13);
            this.labelExpireDate.TabIndex = 13;
            this.labelExpireDate.Text = "Expire Date :";
            this.labelExpireDate.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(416, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboMedicineCategory
            // 
            this.comboMedicineCategory.FormattingEnabled = true;
            this.comboMedicineCategory.Location = new System.Drawing.Point(63, 120);
            this.comboMedicineCategory.Name = "comboMedicineCategory";
            this.comboMedicineCategory.Size = new System.Drawing.Size(278, 21);
            this.comboMedicineCategory.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(453, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(537, 208);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(620, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(416, 260);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 20);
            this.txtSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(627, 260);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 20);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Location = new System.Drawing.Point(63, 295);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.Size = new System.Drawing.Size(632, 154);
            this.dgvMedicines.TabIndex = 22;
            this.dgvMedicines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicines_CellContentClick);
            // 
            // AdminMedicinesManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboMedicineCategory);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelExpireDate);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.labeDosage);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelManageMedicineTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMedicinesManageForm";
            this.Text = "AdminMedicinesManageForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageMedicineTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label labeDosage;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelExpireDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboMedicineCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMedicines;
    }
}