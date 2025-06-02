using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.UserControllers
{
    public partial class UserControl5 : UserControl
    {
        ProductController productController;
        SupplyPermitController spc;
        SupplyPermitProductController sppc;
        SupplierController sc;
        WarehouseController wc;
        public UserControl5()
        {
            InitializeComponent();
            productController = new ProductController();
            spc = new SupplyPermitController();
            sppc = new SupplyPermitProductController();
            sc = new SupplierController();
            wc = new WarehouseController();

            var products = productController.GetAllProducts();
            checkedListBox1.Items.Clear();
            checkedListBox1.DataSource = products;
            checkedListBox1.DisplayMember = "Name";  // Shows product.Name in the list
            checkedListBox1.ValueMember = "ProductID"; // Optional, for identification

            var suppliers = sc.GetAllSuppliers();
            comboBox1.DataSource = suppliers;
            comboBox1.DisplayMember = "Name";    // Property to show in the list
            comboBox1.ValueMember = "ID";

            var warehouses = wc.GetAllWarehouses();
            comboBox2.DataSource = warehouses;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "ID"; // Optional, for identification
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            int yPosition = 10;

            foreach (Product product in checkedListBox1.CheckedItems)
            {
                // Product name label (bold)
                Label lblProduct = new Label();
                lblProduct.Text = product.Name;
                lblProduct.Location = new Point(10, yPosition);
                lblProduct.AutoSize = true;
                lblProduct.Font = new Font(lblProduct.Font, FontStyle.Bold);
                panel1.Controls.Add(lblProduct);

                int labelX = 100;
                int controlX = 250;
                int spacingY = 25; // Vertical spacing between rows of inputs

                // Quantity label and NumericUpDown
                Label lblQuantity = new Label();
                lblQuantity.Text = "Quantity:";
                lblQuantity.Location = new Point(labelX, yPosition);
                lblQuantity.AutoSize = true;
                panel1.Controls.Add(lblQuantity);

                NumericUpDown numQuantity = new NumericUpDown();
                numQuantity.Name = $"numQuantity_{product.ProductID}";
                numQuantity.Location = new Point(controlX, yPosition - 3);
                numQuantity.Minimum = 0;
                numQuantity.Maximum = 100000;
                numQuantity.Width = 60;
                panel1.Controls.Add(numQuantity);

                // Production Date label and DateTimePicker
                Label lblProductionDate = new Label();
                lblProductionDate.Text = "Production Date:";
                lblProductionDate.Location = new Point(labelX, yPosition + spacingY);
                lblProductionDate.AutoSize = true;
                panel1.Controls.Add(lblProductionDate);

                DateTimePicker dtpProduction = new DateTimePicker();
                dtpProduction.Name = $"dtpProduction_{product.ProductID}";
                dtpProduction.Location = new Point(controlX, yPosition + spacingY - 3);
                dtpProduction.Format = DateTimePickerFormat.Short;
                dtpProduction.Width = 100;
                panel1.Controls.Add(dtpProduction);

                // Expiry Date label and DateTimePicker
                Label lblExpiryDate = new Label();
                lblExpiryDate.Text = "Expiry Date:";
                lblExpiryDate.Location = new Point(labelX, yPosition + spacingY * 2);
                lblExpiryDate.AutoSize = true;
                panel1.Controls.Add(lblExpiryDate);

                DateTimePicker dtpExpiry = new DateTimePicker();
                dtpExpiry.Name = $"dtpExpiry_{product.ProductID}";
                dtpExpiry.Location = new Point(controlX, yPosition + spacingY * 2 - 3);
                dtpExpiry.Format = DateTimePickerFormat.Short;
                dtpExpiry.Width = 100;
                panel1.Controls.Add(dtpExpiry);

                // Increase yPosition by the total height of this group + some padding
                yPosition += spacingY * 3 + 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var supplyData = spc.GetAllSupplyPermits()
                .Select(c => new
                {
                    c.PermitID,
                    c.PermitDate,
                    c.SupplierId,
                    c.WarehouseId
                }).ToList();
            dataGridView1.DataSource = supplyData;
            var supplyProducts = sppc.GetAllSupplyPermitProducts()
                .Select(c => new
                {
                    c.SupplyPermitId,
                    c.ProductId,
                    c.Quantity,
                    c.ProductionDate,
                    c.ExpiryDate
                }).ToList();
            dataGridView2.DataSource = supplyProducts;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new SupplyPermit and set properties
            var permit = new SupplyPermit
            {
                SupplierId = (int)comboBox1.SelectedValue,
                PermitDate = DateTime.Now,
                WarehouseId = (int)comboBox2.SelectedValue
            };

            var productDataList = new List<(int ProductId, int Quantity, DateTime ProductionDate, DateTime ExpiryDate)>();

            // Loop through controls in the panel containing dynamic inputs
            foreach (Control control in panel1.Controls)
            {
                // Look for Quantity numeric updown, ProductionDate DateTimePicker, ExpiryDate DateTimePicker, etc. based on control.Name convention

                if (control is NumericUpDown numericUpDown && control.Name.StartsWith("numQuantity_"))
                {
                    // Extract ProductId from control name: e.g. numQuantity_5 -> 5
                    int productId = int.Parse(control.Name.Split('_')[1]);

                    // Find related DateTimePickers for production and expiry dates
                    DateTime productionDate = DateTime.MinValue;
                    DateTime expiryDate = DateTime.MinValue;
                    int quantity = (int)numericUpDown.Value;

                    // Find ProductionDate picker control by naming convention: dtProduction_5
                    var prodPicker = panel1.Controls.Find("dtProduction_" + productId, false).FirstOrDefault() as DateTimePicker;
                    if (prodPicker != null) productionDate = prodPicker.Value;

                    // Find ExpiryDate picker control by naming convention: dtExpiry_5
                    var expiryPicker = panel1.Controls.Find("dtExpiry_" + productId, false).FirstOrDefault() as DateTimePicker;
                    if (expiryPicker != null) expiryDate = expiryPicker.Value;

                    // Add the tuple to list
                    productDataList.Add((productId, quantity, productionDate, expiryDate));
                }
            }

            spc.AddSupplyPermit(permit, productDataList);

            MessageBox.Show("Supply Permit and products added successfully.");
            panel1.Controls.Clear();
        }
    }
}
