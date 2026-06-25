namespace SmartMedPharmacy
{
    partial class CustomerTrackOrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderIDTitle = new System.Windows.Forms.Label();
            this.lblOrderDateTitle = new System.Windows.Forms.Label();
            this.lblOrderStatusTitle = new System.Windows.Forms.Label();
            this.lblOrderTotalAmountTitle = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblOrderHistoryTitle = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnFindMedicine = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Controls.Add(this.lblOrderStatus);
            this.groupBox1.Controls.Add(this.lblOrderDate);
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Controls.Add(this.lblOrderTotalAmountTitle);
            this.groupBox1.Controls.Add(this.lblOrderStatusTitle);
            this.groupBox1.Controls.Add(this.lblOrderDateTitle);
            this.groupBox1.Controls.Add(this.lblOrderIDTitle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Track Your\'s Latest Order";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblOrderIDTitle
            // 
            this.lblOrderIDTitle.AutoSize = true;
            this.lblOrderIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIDTitle.Location = new System.Drawing.Point(48, 44);
            this.lblOrderIDTitle.Name = "lblOrderIDTitle";
            this.lblOrderIDTitle.Size = new System.Drawing.Size(62, 17);
            this.lblOrderIDTitle.TabIndex = 0;
            this.lblOrderIDTitle.Text = "Order ID";
            // 
            // lblOrderDateTitle
            // 
            this.lblOrderDateTitle.AutoSize = true;
            this.lblOrderDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDateTitle.Location = new System.Drawing.Point(226, 44);
            this.lblOrderDateTitle.Name = "lblOrderDateTitle";
            this.lblOrderDateTitle.Size = new System.Drawing.Size(79, 17);
            this.lblOrderDateTitle.TabIndex = 1;
            this.lblOrderDateTitle.Text = "Order Date";
            // 
            // lblOrderStatusTitle
            // 
            this.lblOrderStatusTitle.AutoSize = true;
            this.lblOrderStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatusTitle.Location = new System.Drawing.Point(424, 44);
            this.lblOrderStatusTitle.Name = "lblOrderStatusTitle";
            this.lblOrderStatusTitle.Size = new System.Drawing.Size(48, 17);
            this.lblOrderStatusTitle.TabIndex = 2;
            this.lblOrderStatusTitle.Text = "Status";
            this.lblOrderStatusTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOrderTotalAmountTitle
            // 
            this.lblOrderTotalAmountTitle.AutoSize = true;
            this.lblOrderTotalAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotalAmountTitle.Location = new System.Drawing.Point(584, 44);
            this.lblOrderTotalAmountTitle.Name = "lblOrderTotalAmountTitle";
            this.lblOrderTotalAmountTitle.Size = new System.Drawing.Size(92, 17);
            this.lblOrderTotalAmountTitle.TabIndex = 3;
            this.lblOrderTotalAmountTitle.Text = "Total Amount";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(36, 74);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(91, 20);
            this.lblOrderID.TabIndex = 4;
            this.lblOrderID.Text = "lblOrderID";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(211, 74);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(111, 20);
            this.lblOrderDate.TabIndex = 5;
            this.lblOrderDate.Text = "lblOrderDate";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(393, 74);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(125, 20);
            this.lblOrderStatus.TabIndex = 6;
            this.lblOrderStatus.Text = "lblOrderStatus";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(573, 74);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(129, 20);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "lblTotalAmount";
            // 
            // lblOrderHistoryTitle
            // 
            this.lblOrderHistoryTitle.AutoSize = true;
            this.lblOrderHistoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderHistoryTitle.Location = new System.Drawing.Point(35, 204);
            this.lblOrderHistoryTitle.Name = "lblOrderHistoryTitle";
            this.lblOrderHistoryTitle.Size = new System.Drawing.Size(109, 17);
            this.lblOrderHistoryTitle.TabIndex = 8;
            this.lblOrderHistoryTitle.Text = "Your\'s Orders";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(38, 234);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(729, 196);
            this.dgvOrders.TabIndex = 9;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnFindMedicine
            // 
            this.btnFindMedicine.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFindMedicine.FlatAppearance.BorderSize = 0;
            this.btnFindMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindMedicine.Location = new System.Drawing.Point(667, 179);
            this.btnFindMedicine.Name = "btnFindMedicine";
            this.btnFindMedicine.Size = new System.Drawing.Size(100, 31);
            this.btnFindMedicine.TabIndex = 13;
            this.btnFindMedicine.Text = "Refresh";
            this.btnFindMedicine.UseVisualStyleBackColor = false;
            // 
            // CustomerTrackOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFindMedicine);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.lblOrderHistoryTitle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerTrackOrderForm";
            this.Text = "CustomerTrackOrderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrderStatusTitle;
        private System.Windows.Forms.Label lblOrderDateTitle;
        private System.Windows.Forms.Label lblOrderIDTitle;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblOrderTotalAmountTitle;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderHistoryTitle;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnFindMedicine;
    }
}