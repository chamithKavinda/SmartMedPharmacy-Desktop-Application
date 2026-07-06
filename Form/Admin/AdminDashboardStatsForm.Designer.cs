namespace SmartMedPharmacy.Forms.Admin
{
    partial class AdminDashboardStatsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxNewOrders = new System.Windows.Forms.GroupBox();
            this.groupBoxLowStockAerts = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NewOrderLabel = new System.Windows.Forms.Label();
            this.LowStockAlertsLabel = new System.Windows.Forms.Label();
            this.todaysRevenueLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxNewOrders.SuspendLayout();
            this.groupBoxLowStockAerts.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNewOrders
            // 
            this.groupBoxNewOrders.Controls.Add(this.NewOrderLabel);
            this.groupBoxNewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNewOrders.Location = new System.Drawing.Point(44, 32);
            this.groupBoxNewOrders.Name = "groupBoxNewOrders";
            this.groupBoxNewOrders.Size = new System.Drawing.Size(200, 100);
            this.groupBoxNewOrders.TabIndex = 0;
            this.groupBoxNewOrders.TabStop = false;
            this.groupBoxNewOrders.Text = "New Orders ";
            this.groupBoxNewOrders.Enter += new System.EventHandler(this.groupBoxNewOrders_Enter);
            // 
            // groupBoxLowStockAerts
            // 
            this.groupBoxLowStockAerts.Controls.Add(this.LowStockAlertsLabel);
            this.groupBoxLowStockAerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLowStockAerts.Location = new System.Drawing.Point(297, 32);
            this.groupBoxLowStockAerts.Name = "groupBoxLowStockAerts";
            this.groupBoxLowStockAerts.Size = new System.Drawing.Size(200, 100);
            this.groupBoxLowStockAerts.TabIndex = 1;
            this.groupBoxLowStockAerts.TabStop = false;
            this.groupBoxLowStockAerts.Text = "Low Stock Alerts";
            this.groupBoxLowStockAerts.Enter += new System.EventHandler(this.groupBoxLowStockAerts_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.todaysRevenueLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(558, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Today\'s Revenue";
            // 
            // NewOrderLabel
            // 
            this.NewOrderLabel.AutoSize = true;
            this.NewOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderLabel.Location = new System.Drawing.Point(49, 42);
            this.NewOrderLabel.Name = "NewOrderLabel";
            this.NewOrderLabel.Size = new System.Drawing.Size(85, 29);
            this.NewOrderLabel.TabIndex = 0;
            this.NewOrderLabel.Text = "label1";
            this.NewOrderLabel.Click += new System.EventHandler(this.NewOrderLabel_Click);
            // 
            // LowStockAlertsLabel
            // 
            this.LowStockAlertsLabel.AutoSize = true;
            this.LowStockAlertsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowStockAlertsLabel.Location = new System.Drawing.Point(52, 42);
            this.LowStockAlertsLabel.Name = "LowStockAlertsLabel";
            this.LowStockAlertsLabel.Size = new System.Drawing.Size(85, 29);
            this.LowStockAlertsLabel.TabIndex = 1;
            this.LowStockAlertsLabel.Text = "label1";
            this.LowStockAlertsLabel.Click += new System.EventHandler(this.LowStockAlertsLabel_Click);
            // 
            // todaysRevenueLabel
            // 
            this.todaysRevenueLabel.AutoSize = true;
            this.todaysRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaysRevenueLabel.Location = new System.Drawing.Point(51, 42);
            this.todaysRevenueLabel.Name = "todaysRevenueLabel";
            this.todaysRevenueLabel.Size = new System.Drawing.Size(85, 29);
            this.todaysRevenueLabel.TabIndex = 2;
            this.todaysRevenueLabel.Text = "label1";
            this.todaysRevenueLabel.Click += new System.EventHandler(this.todaysRevenueLabel_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.Title = "Month";
            chartArea1.AxisY.Title = "Sales Revenue $";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(19, 35);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(360, 218);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart2);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 271);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monthly Sales Overview";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend1.Name = "tt";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(384, 37);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "tt";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(310, 189);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // AdminDashboardStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxLowStockAerts);
            this.Controls.Add(this.groupBoxNewOrders);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboardStatsForm";
            this.Text = "AdminDashboardStatsForm";
            this.Load += new System.EventHandler(this.AdminDashboardStatsForm_Load);
            this.groupBoxNewOrders.ResumeLayout(false);
            this.groupBoxNewOrders.PerformLayout();
            this.groupBoxLowStockAerts.ResumeLayout(false);
            this.groupBoxLowStockAerts.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNewOrders;
        private System.Windows.Forms.GroupBox groupBoxLowStockAerts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label NewOrderLabel;
        private System.Windows.Forms.Label LowStockAlertsLabel;
        private System.Windows.Forms.Label todaysRevenueLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}