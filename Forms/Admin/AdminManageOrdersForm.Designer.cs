namespace SmartMedPharmacy.Forms
{
    partial class AdminManageOrdersForm
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.labelOrderStatus = new System.Windows.Forms.Label();
            this.txtCustomerMobileNumber = new System.Windows.Forms.TextBox();
            this.labelCustomerMobileNumber = new System.Windows.Forms.Label();
            this.txtMedicines = new System.Windows.Forms.TextBox();
            this.labelMedicines = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.labelCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.labelCustomerAddress = new System.Windows.Forms.Label();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvManageOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManageMedicineTitle
            // 
            this.labelManageMedicineTitle.AutoSize = true;
            this.labelManageMedicineTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelManageMedicineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageMedicineTitle.Location = new System.Drawing.Point(23, 22);
            this.labelManageMedicineTitle.Name = "labelManageMedicineTitle";
            this.labelManageMedicineTitle.Size = new System.Drawing.Size(124, 18);
            this.labelManageMedicineTitle.TabIndex = 2;
            this.labelManageMedicineTitle.Text = "Manage Orders";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(73, 78);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(278, 20);
            this.txtOrderID.TabIndex = 6;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderID.Location = new System.Drawing.Point(70, 62);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(63, 13);
            this.labelOrderID.TabIndex = 5;
            this.labelOrderID.Text = "Order ID :";
            // 
            // labelOrderStatus
            // 
            this.labelOrderStatus.AutoSize = true;
            this.labelOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderStatus.Location = new System.Drawing.Point(414, 62);
            this.labelOrderStatus.Name = "labelOrderStatus";
            this.labelOrderStatus.Size = new System.Drawing.Size(86, 13);
            this.labelOrderStatus.TabIndex = 7;
            this.labelOrderStatus.Text = "Order Status :";
            // 
            // txtCustomerMobileNumber
            // 
            this.txtCustomerMobileNumber.Location = new System.Drawing.Point(73, 126);
            this.txtCustomerMobileNumber.Name = "txtCustomerMobileNumber";
            this.txtCustomerMobileNumber.Size = new System.Drawing.Size(278, 20);
            this.txtCustomerMobileNumber.TabIndex = 10;
            // 
            // labelCustomerMobileNumber
            // 
            this.labelCustomerMobileNumber.AutoSize = true;
            this.labelCustomerMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerMobileNumber.Location = new System.Drawing.Point(70, 110);
            this.labelCustomerMobileNumber.Name = "labelCustomerMobileNumber";
            this.labelCustomerMobileNumber.Size = new System.Drawing.Size(164, 13);
            this.labelCustomerMobileNumber.TabIndex = 9;
            this.labelCustomerMobileNumber.Text = "Customer\'s Mobile Number :";
            // 
            // txtMedicines
            // 
            this.txtMedicines.Location = new System.Drawing.Point(417, 126);
            this.txtMedicines.Name = "txtMedicines";
            this.txtMedicines.Size = new System.Drawing.Size(278, 20);
            this.txtMedicines.TabIndex = 12;
            // 
            // labelMedicines
            // 
            this.labelMedicines.AutoSize = true;
            this.labelMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicines.Location = new System.Drawing.Point(414, 110);
            this.labelMedicines.Name = "labelMedicines";
            this.labelMedicines.Size = new System.Drawing.Size(72, 13);
            this.labelMedicines.TabIndex = 11;
            this.labelMedicines.Text = "Medicines :";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(73, 176);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(278, 20);
            this.txtCustomerEmail.TabIndex = 14;
            // 
            // labelCustomerEmail
            // 
            this.labelCustomerEmail.AutoSize = true;
            this.labelCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerEmail.Location = new System.Drawing.Point(70, 160);
            this.labelCustomerEmail.Name = "labelCustomerEmail";
            this.labelCustomerEmail.Size = new System.Drawing.Size(110, 13);
            this.labelCustomerEmail.TabIndex = 13;
            this.labelCustomerEmail.Text = "Customer\'s Email :";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(417, 176);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(278, 20);
            this.txtCustomerAddress.TabIndex = 16;
            // 
            // labelCustomerAddress
            // 
            this.labelCustomerAddress.AutoSize = true;
            this.labelCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerAddress.Location = new System.Drawing.Point(414, 160);
            this.labelCustomerAddress.Name = "labelCustomerAddress";
            this.labelCustomerAddress.Size = new System.Drawing.Size(111, 13);
            this.labelCustomerAddress.TabIndex = 15;
            this.labelCustomerAddress.Text = "Customer\'s Addres";
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.Items.AddRange(new object[] {
            "Pending",
            "Ready for Pickup",
            "Delivered",
            "Cancelled"});
            this.cmbOrderStatus.Location = new System.Drawing.Point(417, 78);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(278, 21);
            this.cmbOrderStatus.TabIndex = 17;
            this.cmbOrderStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(626, 257);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 20);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(415, 257);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 20);
            this.txtSearch.TabIndex = 30;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(620, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(537, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(453, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // dgvManageOrders
            // 
            this.dgvManageOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageOrders.Location = new System.Drawing.Point(73, 291);
            this.dgvManageOrders.Name = "dgvManageOrders";
            this.dgvManageOrders.Size = new System.Drawing.Size(622, 159);
            this.dgvManageOrders.TabIndex = 32;
            // 
            // AdminManageOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvManageOrders);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbOrderStatus);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.labelCustomerAddress);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.labelCustomerEmail);
            this.Controls.Add(this.txtMedicines);
            this.Controls.Add(this.labelMedicines);
            this.Controls.Add(this.txtCustomerMobileNumber);
            this.Controls.Add(this.labelCustomerMobileNumber);
            this.Controls.Add(this.labelOrderStatus);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.labelManageMedicineTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminManageOrdersForm";
            this.Text = "AdminManageOrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageMedicineTitle;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.Label labelOrderStatus;
        private System.Windows.Forms.TextBox txtCustomerMobileNumber;
        private System.Windows.Forms.Label labelCustomerMobileNumber;
        private System.Windows.Forms.TextBox txtMedicines;
        private System.Windows.Forms.Label labelMedicines;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label labelCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label labelCustomerAddress;
        private System.Windows.Forms.ComboBox cmbOrderStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvManageOrders;
    }
}