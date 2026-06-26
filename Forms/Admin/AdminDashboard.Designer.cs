namespace SmartMedPharmacy.Forms
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AdminPannelSidebar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnManageMedicines = new System.Windows.Forms.Button();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.AdminPanelHeader = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.AdminMainPanel = new System.Windows.Forms.Panel();
            this.labelActiveOrders = new System.Windows.Forms.Label();
            this.labelMedicineCount = new System.Windows.Forms.Label();
            this.labelTotalSales = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AdminPannelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AdminPanelHeader.SuspendLayout();
            this.AdminMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPannelSidebar
            // 
            this.AdminPannelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AdminPannelSidebar.Controls.Add(this.pictureBox1);
            this.AdminPannelSidebar.Controls.Add(this.btnLogout);
            this.AdminPannelSidebar.Controls.Add(this.btnManageCustomers);
            this.AdminPannelSidebar.Controls.Add(this.btnReports);
            this.AdminPannelSidebar.Controls.Add(this.btnManageMedicines);
            this.AdminPannelSidebar.Controls.Add(this.btnManageOrders);
            this.AdminPannelSidebar.Controls.Add(this.btnAdminDashboard);
            this.AdminPannelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminPannelSidebar.Location = new System.Drawing.Point(0, 39);
            this.AdminPannelSidebar.Name = "AdminPannelSidebar";
            this.AdminPannelSidebar.Size = new System.Drawing.Size(169, 460);
            this.AdminPannelSidebar.TabIndex = 1;
            this.AdminPannelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminPannelContainer_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(30, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(21, 369);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 33);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.BackColor = System.Drawing.Color.Gray;
            this.btnManageCustomers.FlatAppearance.BorderSize = 0;
            this.btnManageCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomers.ForeColor = System.Drawing.Color.White;
            this.btnManageCustomers.Location = new System.Drawing.Point(21, 244);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(119, 33);
            this.btnManageCustomers.TabIndex = 2;
            this.btnManageCustomers.Text = "Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = false;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Gray;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(21, 327);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(119, 33);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnManageMedicines
            // 
            this.btnManageMedicines.BackColor = System.Drawing.Color.Gray;
            this.btnManageMedicines.FlatAppearance.BorderSize = 0;
            this.btnManageMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMedicines.ForeColor = System.Drawing.Color.White;
            this.btnManageMedicines.Location = new System.Drawing.Point(21, 202);
            this.btnManageMedicines.Name = "btnManageMedicines";
            this.btnManageMedicines.Size = new System.Drawing.Size(119, 33);
            this.btnManageMedicines.TabIndex = 0;
            this.btnManageMedicines.Text = "Medicines";
            this.btnManageMedicines.UseVisualStyleBackColor = false;
            this.btnManageMedicines.Click += new System.EventHandler(this.btnManageMedicines_Click);
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.BackColor = System.Drawing.Color.Gray;
            this.btnManageOrders.FlatAppearance.BorderSize = 0;
            this.btnManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrders.ForeColor = System.Drawing.Color.White;
            this.btnManageOrders.Location = new System.Drawing.Point(21, 285);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(119, 33);
            this.btnManageOrders.TabIndex = 3;
            this.btnManageOrders.Text = "Orders";
            this.btnManageOrders.UseVisualStyleBackColor = false;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.BackColor = System.Drawing.Color.Gray;
            this.btnAdminDashboard.FlatAppearance.BorderSize = 0;
            this.btnAdminDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDashboard.ForeColor = System.Drawing.Color.White;
            this.btnAdminDashboard.Location = new System.Drawing.Point(21, 161);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(119, 33);
            this.btnAdminDashboard.TabIndex = 1;
            this.btnAdminDashboard.Text = "Dashboard";
            this.btnAdminDashboard.UseVisualStyleBackColor = false;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // AdminPanelHeader
            // 
            this.AdminPanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AdminPanelHeader.Controls.Add(this.lblTime);
            this.AdminPanelHeader.Controls.Add(this.lblWelcomeTitle);
            this.AdminPanelHeader.Controls.Add(this.lblDate);
            this.AdminPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.AdminPanelHeader.Name = "AdminPanelHeader";
            this.AdminPanelHeader.Size = new System.Drawing.Size(961, 39);
            this.AdminPanelHeader.TabIndex = 2;
            this.AdminPanelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(611, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeTitle.Location = new System.Drawing.Point(27, 10);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(142, 17);
            this.lblWelcomeTitle.TabIndex = 12;
            this.lblWelcomeTitle.Text = "Welcome Message";
            this.lblWelcomeTitle.Click += new System.EventHandler(this.lblWelcomeTitle_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(732, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // AdminMainPanel
            // 
            this.AdminMainPanel.BackColor = System.Drawing.Color.White;
            this.AdminMainPanel.Controls.Add(this.labelActiveOrders);
            this.AdminMainPanel.Controls.Add(this.labelMedicineCount);
            this.AdminMainPanel.Controls.Add(this.labelTotalSales);
            this.AdminMainPanel.Controls.Add(this.chart2);
            this.AdminMainPanel.Controls.Add(this.chart1);
            this.AdminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminMainPanel.Location = new System.Drawing.Point(169, 39);
            this.AdminMainPanel.Name = "AdminMainPanel";
            this.AdminMainPanel.Size = new System.Drawing.Size(792, 460);
            this.AdminMainPanel.TabIndex = 3;
            this.AdminMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminMainPanel_Paint);
            // 
            // labelActiveOrders
            // 
            this.labelActiveOrders.AutoSize = true;
            this.labelActiveOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveOrders.Location = new System.Drawing.Point(496, 42);
            this.labelActiveOrders.Name = "labelActiveOrders";
            this.labelActiveOrders.Size = new System.Drawing.Size(100, 15);
            this.labelActiveOrders.TabIndex = 9;
            this.labelActiveOrders.Text = "Active Orders -";
            this.labelActiveOrders.Click += new System.EventHandler(this.labelActiveOrders_Click);
            // 
            // labelMedicineCount
            // 
            this.labelMedicineCount.AutoSize = true;
            this.labelMedicineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicineCount.Location = new System.Drawing.Point(247, 42);
            this.labelMedicineCount.Name = "labelMedicineCount";
            this.labelMedicineCount.Size = new System.Drawing.Size(119, 15);
            this.labelMedicineCount.TabIndex = 8;
            this.labelMedicineCount.Text = "Medcines Count -";
            this.labelMedicineCount.Click += new System.EventHandler(this.labelMedicineCount_Click);
            // 
            // labelTotalSales
            // 
            this.labelTotalSales.AutoSize = true;
            this.labelTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSales.Location = new System.Drawing.Point(48, 42);
            this.labelTotalSales.Name = "labelTotalSales";
            this.labelTotalSales.Size = new System.Drawing.Size(88, 15);
            this.labelTotalSales.TabIndex = 7;
            this.labelTotalSales.Text = "Total Sales -";
            this.labelTotalSales.Click += new System.EventHandler(this.labelTotalSales_Click);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(404, 104);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(42, 104);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 499);
            this.Controls.Add(this.AdminMainPanel);
            this.Controls.Add(this.AdminPannelSidebar);
            this.Controls.Add(this.AdminPanelHeader);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.AdminPannelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AdminPanelHeader.ResumeLayout(false);
            this.AdminPanelHeader.PerformLayout();
            this.AdminMainPanel.ResumeLayout(false);
            this.AdminMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AdminPannelSidebar;
        private System.Windows.Forms.Panel AdminPanelHeader;
        private System.Windows.Forms.Panel AdminMainPanel;
        private System.Windows.Forms.Button btnManageMedicines;
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label labelActiveOrders;
        private System.Windows.Forms.Label labelMedicineCount;
        private System.Windows.Forms.Label labelTotalSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}