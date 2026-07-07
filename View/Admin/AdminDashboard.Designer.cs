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
            this.AdminPannelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AdminPanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminPannelSidebar
            // 
            this.AdminPannelSidebar.BackColor = System.Drawing.Color.Lavender;
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
            this.AdminPanelHeader.BackColor = System.Drawing.Color.Lavender;
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
            this.AdminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminMainPanel.Location = new System.Drawing.Point(169, 39);
            this.AdminMainPanel.Name = "AdminMainPanel";
            this.AdminMainPanel.Size = new System.Drawing.Size(792, 460);
            this.AdminMainPanel.TabIndex = 3;
            this.AdminMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminMainPanel_Paint);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AdminPannelSidebar;
        private System.Windows.Forms.Panel AdminPanelHeader;
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
        private System.Windows.Forms.Panel AdminMainPanel;
    }
}