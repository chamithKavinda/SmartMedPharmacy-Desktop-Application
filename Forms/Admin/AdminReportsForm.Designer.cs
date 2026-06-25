namespace SmartMedPharmacy.Forms
{
    partial class AdminReportsForm
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelToDate = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.labelTotalsales = new System.Windows.Forms.Label();
            this.txtTotalOrders = new System.Windows.Forms.TextBox();
            this.labelTotalOrders = new System.Windows.Forms.Label();
            this.txtTotalStockCount = new System.Windows.Forms.TextBox();
            this.labelStockCount = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnCustomerOrderHistory = new System.Windows.Forms.Button();
            this.btnStockReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManageMedicineTitle
            // 
            this.labelManageMedicineTitle.AutoSize = true;
            this.labelManageMedicineTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelManageMedicineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageMedicineTitle.Location = new System.Drawing.Point(25, 23);
            this.labelManageMedicineTitle.Name = "labelManageMedicineTitle";
            this.labelManageMedicineTitle.Size = new System.Drawing.Size(178, 18);
            this.labelManageMedicineTitle.TabIndex = 3;
            this.labelManageMedicineTitle.Text = "Report Generate Form";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(76, 83);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(278, 20);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(73, 67);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(40, 13);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Title :";
            this.labelTitle.Click += new System.EventHandler(this.labelOrderID_Click);
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromDate.Location = new System.Drawing.Point(73, 112);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(73, 13);
            this.labelFromDate.TabIndex = 9;
            this.labelFromDate.Text = "From Date :";
            this.labelFromDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToDate.Location = new System.Drawing.Point(73, 156);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(61, 13);
            this.labelToDate.TabIndex = 11;
            this.labelToDate.Text = "To Date :";
            this.labelToDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(416, 83);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(278, 20);
            this.txtTotalSales.TabIndex = 14;
            // 
            // labelTotalsales
            // 
            this.labelTotalsales.AutoSize = true;
            this.labelTotalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalsales.Location = new System.Drawing.Point(413, 67);
            this.labelTotalsales.Name = "labelTotalsales";
            this.labelTotalsales.Size = new System.Drawing.Size(79, 13);
            this.labelTotalsales.TabIndex = 13;
            this.labelTotalsales.Text = "Total Sales :";
            // 
            // txtTotalOrders
            // 
            this.txtTotalOrders.Location = new System.Drawing.Point(416, 128);
            this.txtTotalOrders.Name = "txtTotalOrders";
            this.txtTotalOrders.Size = new System.Drawing.Size(278, 20);
            this.txtTotalOrders.TabIndex = 16;
            // 
            // labelTotalOrders
            // 
            this.labelTotalOrders.AutoSize = true;
            this.labelTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOrders.Location = new System.Drawing.Point(413, 112);
            this.labelTotalOrders.Name = "labelTotalOrders";
            this.labelTotalOrders.Size = new System.Drawing.Size(85, 13);
            this.labelTotalOrders.TabIndex = 15;
            this.labelTotalOrders.Text = "Total Orders :";
            // 
            // txtTotalStockCount
            // 
            this.txtTotalStockCount.Location = new System.Drawing.Point(416, 172);
            this.txtTotalStockCount.Name = "txtTotalStockCount";
            this.txtTotalStockCount.Size = new System.Drawing.Size(278, 20);
            this.txtTotalStockCount.TabIndex = 18;
            // 
            // labelStockCount
            // 
            this.labelStockCount.AutoSize = true;
            this.labelStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockCount.Location = new System.Drawing.Point(413, 156);
            this.labelStockCount.Name = "labelStockCount";
            this.labelStockCount.Size = new System.Drawing.Size(118, 13);
            this.labelStockCount.TabIndex = 17;
            this.labelStockCount.Text = "Total Stock Count :";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(76, 128);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(278, 20);
            this.dtpFromDate.TabIndex = 19;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(76, 172);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(278, 20);
            this.dtpToDate.TabIndex = 20;
            // 
            // btnCustomerOrderHistory
            // 
            this.btnCustomerOrderHistory.BackColor = System.Drawing.Color.Sienna;
            this.btnCustomerOrderHistory.FlatAppearance.BorderSize = 0;
            this.btnCustomerOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerOrderHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomerOrderHistory.Location = new System.Drawing.Point(461, 216);
            this.btnCustomerOrderHistory.Name = "btnCustomerOrderHistory";
            this.btnCustomerOrderHistory.Size = new System.Drawing.Size(109, 33);
            this.btnCustomerOrderHistory.TabIndex = 32;
            this.btnCustomerOrderHistory.Text = "Order History";
            this.btnCustomerOrderHistory.UseVisualStyleBackColor = false;
            // 
            // btnStockReport
            // 
            this.btnStockReport.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStockReport.FlatAppearance.BorderSize = 0;
            this.btnStockReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStockReport.Location = new System.Drawing.Point(335, 216);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(109, 33);
            this.btnStockReport.TabIndex = 31;
            this.btnStockReport.Text = "Stock Report";
            this.btnStockReport.UseVisualStyleBackColor = false;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesReport.Location = new System.Drawing.Point(202, 216);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(109, 33);
            this.btnSalesReport.TabIndex = 30;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportCSV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportCSV.Location = new System.Drawing.Point(585, 216);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(109, 33);
            this.btnExportCSV.TabIndex = 33;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = false;
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(76, 276);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(618, 176);
            this.dgvReports.TabIndex = 34;
            // 
            // AdminReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnCustomerOrderHistory);
            this.Controls.Add(this.btnStockReport);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtTotalStockCount);
            this.Controls.Add(this.labelStockCount);
            this.Controls.Add(this.txtTotalOrders);
            this.Controls.Add(this.labelTotalOrders);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.labelTotalsales);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.labelFromDate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelManageMedicineTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminReportsForm";
            this.Text = "AdminReportsForm";
            this.Load += new System.EventHandler(this.AdminReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageMedicineTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.Label labelTotalsales;
        private System.Windows.Forms.TextBox txtTotalOrders;
        private System.Windows.Forms.Label labelTotalOrders;
        private System.Windows.Forms.TextBox txtTotalStockCount;
        private System.Windows.Forms.Label labelStockCount;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnCustomerOrderHistory;
        private System.Windows.Forms.Button btnStockReport;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.DataGridView dgvReports;
    }
}