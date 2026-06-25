namespace SmartMedPharmacy.Forms.Customer
{
    partial class CustomerPlaceOrderForm
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
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblDeliveryMethod = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDiliveryAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLKR = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicineTitle
            // 
            this.lblMedicineTitle.AutoSize = true;
            this.lblMedicineTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineTitle.Location = new System.Drawing.Point(22, 19);
            this.lblMedicineTitle.Name = "lblMedicineTitle";
            this.lblMedicineTitle.Size = new System.Drawing.Size(155, 18);
            this.lblMedicineTitle.TabIndex = 1;
            this.lblMedicineTitle.Text = "Your Shopping Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(25, 56);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(736, 132);
            this.dgvCart.TabIndex = 2;
            // 
            // lblDeliveryMethod
            // 
            this.lblDeliveryMethod.AutoSize = true;
            this.lblDeliveryMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryMethod.Location = new System.Drawing.Point(22, 256);
            this.lblDeliveryMethod.Name = "lblDeliveryMethod";
            this.lblDeliveryMethod.Size = new System.Drawing.Size(106, 15);
            this.lblDeliveryMethod.TabIndex = 6;
            this.lblDeliveryMethod.Text = "Dilivery Method";
            this.lblDeliveryMethod.Click += new System.EventHandler(this.lblName_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Pickup",
            "Dilivery"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lblDiliveryAddress
            // 
            this.lblDiliveryAddress.AutoSize = true;
            this.lblDiliveryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiliveryAddress.Location = new System.Drawing.Point(343, 256);
            this.lblDiliveryAddress.Name = "lblDiliveryAddress";
            this.lblDiliveryAddress.Size = new System.Drawing.Size(109, 15);
            this.lblDiliveryAddress.TabIndex = 8;
            this.lblDiliveryAddress.Text = "Dilivery Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(471, 256);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(289, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.Location = new System.Drawing.Point(529, 204);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(114, 31);
            this.btnRemoveItem.TabIndex = 13;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(660, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear Cart";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.Location = new System.Drawing.Point(500, 326);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(99, 15);
            this.labelTotalAmount.TabIndex = 15;
            this.labelTotalAmount.Text = "Total Amount :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(606, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 16;
            // 
            // lblLKR
            // 
            this.lblLKR.AutoSize = true;
            this.lblLKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLKR.Location = new System.Drawing.Point(727, 325);
            this.lblLKR.Name = "lblLKR";
            this.lblLKR.Size = new System.Drawing.Size(34, 15);
            this.lblLKR.TabIndex = 17;
            this.lblLKR.Text = "LKR";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlaceOrder.Location = new System.Drawing.Point(606, 367);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(154, 40);
            this.btnPlaceOrder.TabIndex = 18;
            this.btnPlaceOrder.Text = "Confirm Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // CustomerPlaceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblLKR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblDiliveryAddress);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDeliveryMethod);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblMedicineTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerPlaceOrderForm";
            this.Text = "CustomerPlaceOrderForm";
            this.Load += new System.EventHandler(this.CustomerPlaceOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicineTitle;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblDeliveryMethod;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDiliveryAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLKR;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}