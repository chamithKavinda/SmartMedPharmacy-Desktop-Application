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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(90, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(93, 95);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(136, 20);
            this.txtMedicineName.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(506, 29);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 15);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Cateogory";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(510, 49);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(136, 24);
            this.cmbCategory.TabIndex = 7;
            // 
            // lblMinimumPrice
            // 
            this.lblMinimumPrice.AutoSize = true;
            this.lblMinimumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumPrice.Location = new System.Drawing.Point(191, 30);
            this.lblMinimumPrice.Name = "lblMinimumPrice";
            this.lblMinimumPrice.Size = new System.Drawing.Size(72, 15);
            this.lblMinimumPrice.TabIndex = 8;
            this.lblMinimumPrice.Text = "Mini Price";
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPrice.Location = new System.Drawing.Point(351, 30);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(71, 15);
            this.lblMaxPrice.TabIndex = 9;
            this.lblMaxPrice.Text = "Max Price";
            // 
            // numericUpMin
            // 
            this.numericUpMin.Location = new System.Drawing.Point(192, 51);
            this.numericUpMin.Name = "numericUpMin";
            this.numericUpMin.Size = new System.Drawing.Size(136, 23);
            this.numericUpMin.TabIndex = 10;
            // 
            // numericUpMax
            // 
            this.numericUpMax.Location = new System.Drawing.Point(353, 51);
            this.numericUpMax.Name = "numericUpMax";
            this.numericUpMax.Size = new System.Drawing.Size(136, 23);
            this.numericUpMax.TabIndex = 11;
            // 
            // btnFindMedicine
            // 
            this.btnFindMedicine.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFindMedicine.FlatAppearance.BorderSize = 0;
            this.btnFindMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindMedicine.Location = new System.Drawing.Point(546, 89);
            this.btnFindMedicine.Name = "btnFindMedicine";
            this.btnFindMedicine.Size = new System.Drawing.Size(100, 31);
            this.btnFindMedicine.TabIndex = 12;
            this.btnFindMedicine.Text = "Find";
            this.btnFindMedicine.UseVisualStyleBackColor = false;
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Location = new System.Drawing.Point(61, 207);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.Size = new System.Drawing.Size(678, 243);
            this.dgvMedicines.TabIndex = 13;
            this.dgvMedicines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicines_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.btnFindMedicine);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.numericUpMax);
            this.groupBox1.Controls.Add(this.lblMaxPrice);
            this.groupBox1.Controls.Add(this.numericUpMin);
            this.groupBox1.Controls.Add(this.lblMinimumPrice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 132);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Your\'s Medicine";
            // 
            // CustomerMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMedicineForm";
            this.Text = "CustomerMedicineForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}