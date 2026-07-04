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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(86, 69);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(278, 20);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(83, 53);
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
            this.labelFromDate.Location = new System.Drawing.Point(83, 98);
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
            this.labelToDate.Location = new System.Drawing.Point(83, 142);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(61, 13);
            this.labelToDate.TabIndex = 11;
            this.labelToDate.Text = "To Date :";
            this.labelToDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(426, 69);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(278, 20);
            this.txtTotalSales.TabIndex = 14;
            this.txtTotalSales.TextChanged += new System.EventHandler(this.txtTotalSales_TextChanged);
            // 
            // labelTotalsales
            // 
            this.labelTotalsales.AutoSize = true;
            this.labelTotalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalsales.Location = new System.Drawing.Point(423, 53);
            this.labelTotalsales.Name = "labelTotalsales";
            this.labelTotalsales.Size = new System.Drawing.Size(79, 13);
            this.labelTotalsales.TabIndex = 13;
            this.labelTotalsales.Text = "Total Sales :";
            // 
            // txtTotalOrders
            // 
            this.txtTotalOrders.Location = new System.Drawing.Point(426, 114);
            this.txtTotalOrders.Name = "txtTotalOrders";
            this.txtTotalOrders.Size = new System.Drawing.Size(278, 20);
            this.txtTotalOrders.TabIndex = 16;
            this.txtTotalOrders.TextChanged += new System.EventHandler(this.txtTotalOrders_TextChanged);
            // 
            // labelTotalOrders
            // 
            this.labelTotalOrders.AutoSize = true;
            this.labelTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOrders.Location = new System.Drawing.Point(423, 98);
            this.labelTotalOrders.Name = "labelTotalOrders";
            this.labelTotalOrders.Size = new System.Drawing.Size(85, 13);
            this.labelTotalOrders.TabIndex = 15;
            this.labelTotalOrders.Text = "Total Orders :";
            // 
            // txtTotalStockCount
            // 
            this.txtTotalStockCount.Location = new System.Drawing.Point(426, 158);
            this.txtTotalStockCount.Name = "txtTotalStockCount";
            this.txtTotalStockCount.Size = new System.Drawing.Size(278, 20);
            this.txtTotalStockCount.TabIndex = 18;
            this.txtTotalStockCount.TextChanged += new System.EventHandler(this.txtTotalStockCount_TextChanged);
            // 
            // labelStockCount
            // 
            this.labelStockCount.AutoSize = true;
            this.labelStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockCount.Location = new System.Drawing.Point(423, 142);
            this.labelStockCount.Name = "labelStockCount";
            this.labelStockCount.Size = new System.Drawing.Size(118, 13);
            this.labelStockCount.TabIndex = 17;
            this.labelStockCount.Text = "Total Stock Count :";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(86, 114);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(278, 20);
            this.dtpFromDate.TabIndex = 19;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(86, 158);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(278, 20);
            this.dtpToDate.TabIndex = 20;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // btnCustomerOrderHistory
            // 
            this.btnCustomerOrderHistory.BackColor = System.Drawing.Color.Sienna;
            this.btnCustomerOrderHistory.FlatAppearance.BorderSize = 0;
            this.btnCustomerOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerOrderHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomerOrderHistory.Location = new System.Drawing.Point(471, 202);
            this.btnCustomerOrderHistory.Name = "btnCustomerOrderHistory";
            this.btnCustomerOrderHistory.Size = new System.Drawing.Size(109, 33);
            this.btnCustomerOrderHistory.TabIndex = 32;
            this.btnCustomerOrderHistory.Text = "Order History";
            this.btnCustomerOrderHistory.UseVisualStyleBackColor = false;
            this.btnCustomerOrderHistory.Click += new System.EventHandler(this.btnCustomerOrderHistory_Click);
            // 
            // btnStockReport
            // 
            this.btnStockReport.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStockReport.FlatAppearance.BorderSize = 0;
            this.btnStockReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStockReport.Location = new System.Drawing.Point(345, 202);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(109, 33);
            this.btnStockReport.TabIndex = 31;
            this.btnStockReport.Text = "Stock Report";
            this.btnStockReport.UseVisualStyleBackColor = false;
            this.btnStockReport.Click += new System.EventHandler(this.btnStockReport_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesReport.Location = new System.Drawing.Point(212, 202);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(109, 33);
            this.btnSalesReport.TabIndex = 30;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportCSV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportCSV.Location = new System.Drawing.Point(595, 202);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(109, 33);
            this.btnExportCSV.TabIndex = 33;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(42, 274);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(714, 178);
            this.dgvReports.TabIndex = 34;
            this.dgvReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 227);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Generate Form";
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
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminReportsForm";
            this.Text = "AdminReportsForm";
            this.Load += new System.EventHandler(this.AdminReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}