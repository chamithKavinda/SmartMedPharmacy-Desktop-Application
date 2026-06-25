namespace SmartMedPharmacy.Forms.Customer
{
    partial class CustomerMedicineForm
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
            this.lblMedicineTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblMinimumPrice = new System.Windows.Forms.Label();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.numericUpMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpMax = new System.Windows.Forms.NumericUpDown();
            this.btnFindMedicine = new System.Windows.Forms.Button();
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicineTitle
            // 
            this.lblMedicineTitle.AutoSize = true;
            this.lblMedicineTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineTitle.Location = new System.Drawing.Point(25, 21);
            this.lblMedicineTitle.Name = "lblMedicineTitle";
            this.lblMedicineTitle.Size = new System.Drawing.Size(84, 18);
            this.lblMedicineTitle.TabIndex = 0;
            this.lblMedicineTitle.Text = "Medicines";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(44, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(47, 87);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(136, 20);
            this.txtMedicineName.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(610, 64);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 15);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Cateogory";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(613, 87);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(136, 21);
            this.cmbCategory.TabIndex = 7;
            // 
            // lblMinimumPrice
            // 
            this.lblMinimumPrice.AutoSize = true;
            this.lblMinimumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumPrice.Location = new System.Drawing.Point(227, 66);
            this.lblMinimumPrice.Name = "lblMinimumPrice";
            this.lblMinimumPrice.Size = new System.Drawing.Size(72, 15);
            this.lblMinimumPrice.TabIndex = 8;
            this.lblMinimumPrice.Text = "Mini Price";
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPrice.Location = new System.Drawing.Point(422, 67);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(71, 15);
            this.lblMaxPrice.TabIndex = 9;
            this.lblMaxPrice.Text = "Max Price";
            // 
            // numericUpMin
            // 
            this.numericUpMin.Location = new System.Drawing.Point(229, 87);
            this.numericUpMin.Name = "numericUpMin";
            this.numericUpMin.Size = new System.Drawing.Size(136, 20);
            this.numericUpMin.TabIndex = 10;
            // 
            // numericUpMax
            // 
            this.numericUpMax.Location = new System.Drawing.Point(425, 87);
            this.numericUpMax.Name = "numericUpMax";
            this.numericUpMax.Size = new System.Drawing.Size(136, 20);
            this.numericUpMax.TabIndex = 11;
            // 
            // btnFindMedicine
            // 
            this.btnFindMedicine.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFindMedicine.FlatAppearance.BorderSize = 0;
            this.btnFindMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindMedicine.Location = new System.Drawing.Point(649, 128);
            this.btnFindMedicine.Name = "btnFindMedicine";
            this.btnFindMedicine.Size = new System.Drawing.Size(100, 31);
            this.btnFindMedicine.TabIndex = 12;
            this.btnFindMedicine.Text = "Find";
            this.btnFindMedicine.UseVisualStyleBackColor = false;
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Location = new System.Drawing.Point(47, 187);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.Size = new System.Drawing.Size(660, 263);
            this.dgvMedicines.TabIndex = 13;
            // 
            // CustomerMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.btnFindMedicine);
            this.Controls.Add(this.numericUpMax);
            this.Controls.Add(this.numericUpMin);
            this.Controls.Add(this.lblMaxPrice);
            this.Controls.Add(this.lblMinimumPrice);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMedicineTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMedicineForm";
            this.Text = "CustomerMedicineForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicineTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblMinimumPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.NumericUpDown numericUpMin;
        private System.Windows.Forms.NumericUpDown numericUpMax;
        private System.Windows.Forms.Button btnFindMedicine;
        private System.Windows.Forms.DataGridView dgvMedicines;
    }
}