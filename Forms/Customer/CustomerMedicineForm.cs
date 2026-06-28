using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartMedPharmacy.Controller;
using SmartMedPharmacy.Models;

namespace SmartMedPharmacy.Forms.Customer
{
    public partial class CustomerMedicineForm : Form
    {
        private MedicineController medicineController = new MedicineController();
        private List<Medicine> allMedicines = new List<Medicine>();

        private bool formLoaded = false;

        private Action<Form> loadForm;

        public CustomerMedicineForm()
        {
            InitializeComponent();
            this.loadForm = loadForm;
        }

        private void CustomerMedicineForm_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");
            cmbCategory.Items.Add("Tablet");
            cmbCategory.Items.Add("Capsule");
            cmbCategory.Items.Add("Syrup");
            cmbCategory.Items.Add("Injection");

            cmbCategory.SelectedIndex = 0;

            flowMedicines.AutoScroll = true;
            flowMedicines.WrapContents = true;
            flowMedicines.FlowDirection = FlowDirection.LeftToRight;

            LoadMedicines();

            formLoaded = true;
        }

        private void LoadMedicines()
        {
            allMedicines = medicineController.GetAllMedicines();
            DisplayMedicines(allMedicines);
        }

        private void DisplayMedicines(List<Medicine> medicines)
        {
            flowMedicines.Controls.Clear();

            foreach (Medicine medicine in medicines)
            {
                CreateMedicineCard(medicine);
            }
        }

        private void CreateMedicineCard(Medicine medicine)
        {
            Panel card = new Panel
            {
                Width = 230,
                Height = 190,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Margin = new Padding(10)
            };

            Label lblName = new Label
            {
                Text = medicine.Name,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Top = 10,
                Left = 10,
                Width = 200
            };

            Label lblCategory = new Label
            {
                Text = "Category: " + medicine.Category,
                Top = 40,
                Left = 10
            };

            Label lblPrice = new Label
            {
                Text = "Price: Rs " + medicine.Price,
                Top = 65,
                Left = 10
            };

            Label lblStock = new Label
            {
                Text = "Stock: " + medicine.Stock,
                Top = 90,
                Left = 10
            };

            //Label lblQty = new Label
            //{
            //    Text = "Qty:",
            //    Top = 120,
            //    Left = 5
            //};

            Panel qtyPanel = new Panel
            {
                Width = 160,
                Height = 35,
                Top = 115,
                Left = 50
            };

            TextBox txtQty = new TextBox
            {
                Text = "1",
                Width = 50,
                Height = 30,
                Left = 40,
                Top = 3,
                TextAlign = HorizontalAlignment.Center
            };

            Button btnMinus = new Button
            {
                Text = "-",
                Width = 35,
                Height = 30,
                Left = 0,
                Top = 2
            };

            Button btnPlus = new Button
            {
                Text = "+",
                Width = 35,
                Height = 30,
                Left = 95,
                Top = 2
            };

            btnMinus.Click += (s, e) =>
            {
                int qty = int.TryParse(txtQty.Text, out int q) ? q : 1;

                if (qty > 1)
                    txtQty.Text = (--qty).ToString();
            };

            btnPlus.Click += (s, e) =>
            {
                int qty = int.TryParse(txtQty.Text, out int q) ? q : 1;

                if (qty < medicine.Stock)
                    txtQty.Text = (++qty).ToString();
            };

            Button btnAdd = new Button
            {
                Text = "Add To Cart",
                Width = 160,
                Height = 30,
                Top = 150,
                Left = 35,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            btnAdd.Click += (s, e) =>
            {
                int qty = int.TryParse(txtQty.Text, out int q) ? q : 1;
                AddToCart(medicine, qty);
            };

            qtyPanel.Controls.Add(btnMinus);
            qtyPanel.Controls.Add(txtQty);
            qtyPanel.Controls.Add(btnPlus);

            card.Controls.Add(lblName);
            card.Controls.Add(lblCategory);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblStock);
            //card.Controls.Add(lblQty);

            card.Controls.Add(qtyPanel);

            card.Controls.Add(btnAdd);

            flowMedicines.Controls.Add(card);
        }

        private void btnFindMedicine_Click(object sender, EventArgs e)
        {
            string name = txtMedicineName.Text.Trim();
            string category = cmbCategory.SelectedItem.ToString();

            var filtered = allMedicines.AsEnumerable();

            if (!string.IsNullOrEmpty(name))
            {
                filtered = filtered.Where(m =>
                    m.Name.ToLower().Contains(name.ToLower()));
            }

            if (category != "All")
            {
                filtered = filtered.Where(m =>
                    m.Category == category);
            }

            List<Medicine> result = filtered.ToList();

            DisplayMedicines(result);

            if (result.Count == 0 && formLoaded)
            {
                MessageBox.Show("No medicines found.");
            }
        }

        private void AddToCart(Medicine medicine, int quantity)
        {
            var existing = CartManager.Cart
                .FirstOrDefault(c => c.MedicineId == medicine.MedicineId);

            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                CartManager.Cart.Add(new CartItem
                {
                    MedicineId = medicine.MedicineId,
                    Name = medicine.Name,
                    Price = medicine.Price,
                    Quantity = quantity
                });
            }

            MessageBox.Show("Added to cart successfully!");
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded)
                btnFindMedicine_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerPlaceOrderForm form = new CustomerPlaceOrderForm();
            form.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMedicineName.Clear();
            cmbCategory.SelectedIndex = 0;
            LoadMedicines();
        }

        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {
            if (formLoaded)
                btnFindMedicine_Click(sender, e);
        }

        private void lblName_Click(object sender, EventArgs e) { }

        private void dgvMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}