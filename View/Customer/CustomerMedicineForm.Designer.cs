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
            this.btnFindMedicine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewCart = new System.Windows.Forms.Button();
            this.flowMedicines = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(77, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(80, 86);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(206, 20);
            this.txtMedicineName.TabIndex = 5;
            this.txtMedicineName.TextChanged += new System.EventHandler(this.txtMedicineName_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(254, 31);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 15);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Cateogory";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(257, 53);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(206, 24);
            this.cmbCategory.TabIndex = 7;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // btnFindMedicine
            // 
            this.btnFindMedicine.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFindMedicine.FlatAppearance.BorderSize = 0;
            this.btnFindMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindMedicine.Location = new System.Drawing.Point(498, 50);
            this.btnFindMedicine.Name = "btnFindMedicine";
            this.btnFindMedicine.Size = new System.Drawing.Size(75, 29);
            this.btnFindMedicine.TabIndex = 12;
            this.btnFindMedicine.Text = "Find";
            this.btnFindMedicine.UseVisualStyleBackColor = false;
            this.btnFindMedicine.Click += new System.EventHandler(this.btnFindMedicine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.btnFindMedicine);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 105);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Your\'s Medicine";
            // 
            // viewCart
            // 
            this.viewCart.BackColor = System.Drawing.Color.ForestGreen;
            this.viewCart.FlatAppearance.BorderSize = 0;
            this.viewCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCart.ForeColor = System.Drawing.Color.Transparent;
            this.viewCart.Location = new System.Drawing.Point(623, 406);
            this.viewCart.Name = "viewCart";
            this.viewCart.Size = new System.Drawing.Size(116, 32);
            this.viewCart.TabIndex = 13;
            this.viewCart.Text = "View Cart";
            this.viewCart.UseVisualStyleBackColor = false;
            this.viewCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowMedicines
            // 
            this.flowMedicines.AutoScroll = true;
            this.flowMedicines.Location = new System.Drawing.Point(55, 159);
            this.flowMedicines.Name = "flowMedicines";
            this.flowMedicines.Size = new System.Drawing.Size(684, 231);
            this.flowMedicines.TabIndex = 15;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Peru;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(588, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 28);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Clear";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // CustomerMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewCart);
            this.Controls.Add(this.flowMedicines);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMedicineForm";
            this.Text = "CustomerMedicineForm";
            this.Load += new System.EventHandler(this.CustomerMedicineForm_Load);
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
        private System.Windows.Forms.Button btnFindMedicine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button viewCart;
        private System.Windows.Forms.FlowLayoutPanel flowMedicines;
        private System.Windows.Forms.Button btnRefresh;
    }
}