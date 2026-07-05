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
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblOrderTotalAmountTitle = new System.Windows.Forms.Label();
            this.lblOrderStatusTitle = new System.Windows.Forms.Label();
            this.lblOrderDateTitle = new System.Windows.Forms.Label();
            this.lblOrderIDTitle = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(590, 74);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(129, 20);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "lblTotalAmount";
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalAmount_Click);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(419, 74);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(125, 20);
            this.lblOrderStatus.TabIndex = 6;
            this.lblOrderStatus.Text = "lblOrderStatus";
            this.lblOrderStatus.Click += new System.EventHandler(this.lblOrderStatus_Click);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(197, 74);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(111, 20);
            this.lblOrderDate.TabIndex = 5;
            this.lblOrderDate.Text = "lblOrderDate";
            this.lblOrderDate.Click += new System.EventHandler(this.lblOrderDate_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(62, 74);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(91, 20);
            this.lblOrderID.TabIndex = 4;
            this.lblOrderID.Text = "lblOrderID";
            this.lblOrderID.Click += new System.EventHandler(this.lblOrderID_Click);
            // 
            // lblOrderTotalAmountTitle
            // 
            this.lblOrderTotalAmountTitle.AutoSize = true;
            this.lblOrderTotalAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotalAmountTitle.Location = new System.Drawing.Point(590, 44);
            this.lblOrderTotalAmountTitle.Name = "lblOrderTotalAmountTitle";
            this.lblOrderTotalAmountTitle.Size = new System.Drawing.Size(92, 17);
            this.lblOrderTotalAmountTitle.TabIndex = 3;
            this.lblOrderTotalAmountTitle.Text = "Total Amount";
            // 
            // lblOrderStatusTitle
            // 
            this.lblOrderStatusTitle.AutoSize = true;
            this.lblOrderStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatusTitle.Location = new System.Drawing.Point(433, 44);
            this.lblOrderStatusTitle.Name = "lblOrderStatusTitle";
            this.lblOrderStatusTitle.Size = new System.Drawing.Size(48, 17);
            this.lblOrderStatusTitle.TabIndex = 2;
            this.lblOrderStatusTitle.Text = "Status";
            this.lblOrderStatusTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOrderDateTitle
            // 
            this.lblOrderDateTitle.AutoSize = true;
            this.lblOrderDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDateTitle.Location = new System.Drawing.Point(232, 44);
            this.lblOrderDateTitle.Name = "lblOrderDateTitle";
            this.lblOrderDateTitle.Size = new System.Drawing.Size(79, 17);
            this.lblOrderDateTitle.TabIndex = 1;
            this.lblOrderDateTitle.Text = "Order Date";
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
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(44, 248);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(700, 170);
            this.dgvOrders.TabIndex = 9;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoveOrder.FlatAppearance.BorderSize = 0;
            this.btnRemoveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemoveOrder.Location = new System.Drawing.Point(650, 177);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(117, 31);
            this.btnRemoveOrder.TabIndex = 13;
            this.btnRemoveOrder.Text = "Cancel Order";
            this.btnRemoveOrder.UseVisualStyleBackColor = false;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 222);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your\'s Orders";
            // 
            // CustomerTrackOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerTrackOrderForm";
            this.Text = "CustomerTrackOrderForm";
            this.Load += new System.EventHandler(this.CustomerTrackOrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}