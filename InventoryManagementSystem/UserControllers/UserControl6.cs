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
using InventoryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.UserControllers

{
    public partial class UserControl6 : UserControl
    {
        ProductInWarehouseController pwc;
        WithdrawPermitController wpc;
        WithdrawPermitProductController wppc;
        ClientController cc;
        WarehouseController wc;
        ProductController productController;
        public UserControl6()
        {
            InitializeComponent();
            pwc = new ProductInWarehouseController();
            wpc = new WithdrawPermitController();
            wppc = new WithdrawPermitProductController();
            cc = new ClientController();
            wc = new WarehouseController();
            productController = new ProductController();

            var products = productController.GetAllProducts();

            //checkedListBox1.Items.Clear();
            //checkedListBox1.DataSource = products;
            //checkedListBox1.DisplayMember = "Display";  // Shows product.Name in the list
            //checkedListBox1.ValueMember = "ProductID"; // Optional, for identification

            var Clients = cc.GetAllClients();
            comboBox1.DataSource = Clients;
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

            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (item is ProductDisplayItem product)
                {
                    // Product name label (bold)
                    Label lblProduct = new Label();
                    lblProduct.Text = product.Display.Split('-')[0].Trim(); // Only product name
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

                    yPosition += spacingY + 10;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var withdrawData = wpc.GetAllWithdrawPermits()
                .Select(c => new
                {
                    c.PermitID,
                    c.PermitDate,
                    c.ClientId,
                    c.WarehouseId
                }).ToList();
            dataGridView1.DataSource = withdrawData;
            var withdrawProducts = wppc.GetAllWithdrawPermitProducts()
                .Select(c => new
                {
                    c.WithdrawPermitId,
                    c.ProductId,
                    c.Quantity,
                }).ToList();
            dataGridView2.DataSource = withdrawProducts;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new SupplyPermit and set properties
            var permit = new WithdrawPermit
            {
                ClientId = (int)comboBox1.SelectedValue,
                PermitDate = DateTime.Now,
                WarehouseId = (int)comboBox2.SelectedValue
            };

            var productDataList = new List<(int ProductId, int Quantity)>();

            // Loop through controls in the panel containing dynamic inputs
            foreach (Control control in panel1.Controls)
            {
                // Look for Quantity numeric updown, ProductionDate DateTimePicker, ExpiryDate DateTimePicker, etc. based on control.Name convention

                if (control is NumericUpDown numericUpDown && control.Name.StartsWith("numQuantity_"))
                {
                    // Extract ProductId from control name: e.g. numQuantity_5 -> 5
                    int productId = int.Parse(control.Name.Split('_')[1]);

                    // Find related DateTimePickers for production and expiry dates
                    int quantity = (int)numericUpDown.Value;

                    // Add the tuple to list
                    productDataList.Add((productId, quantity));
                }
            }

            wpc.AddWithdrawPermit(permit, productDataList);

            MessageBox.Show("Withdraw Permit added successfully.");
            panel1.Controls.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem is Warehouse selectedWarehouse)
            {
                var selectedWarehouseId = selectedWarehouse.Id;

                var allProducts = pwc.GetAllProductsInWarehouse();

                var filteredProducts = allProducts
                    .Where(p => p.WarehouseId == selectedWarehouseId && p.Product != null && p.Quantity > 0)
                    .GroupBy(p => new { p.ProductId, p.Product.Name })
                    .Select(g => (
                        ProductID: g.Key.ProductId,
                        Display: $"{g.Key.Name} - {g.Sum(p => p.Quantity)} in stock",
                        TotalQuantity: g.Sum(p => p.Quantity)
                    ))
                    .OrderByDescending(p => p.TotalQuantity)
                    .ToList();

                var products = pwc.GetProductsWithTotalQuantity().Where(p => p.WarehouseId == selectedWarehouseId).ToList();
                checkedListBox1.DataSource = null;
                checkedListBox1.Items.Clear();
                checkedListBox1.DataSource = products;
                checkedListBox1.DisplayMember = "Display";
                checkedListBox1.ValueMember = "ProductID";
            }
        }
        public class ProductDisplayItem
        {
            public int ProductID { get; set; }
            public int WarehouseId { get; set; }
            public string Display { get; set; }
            public int TotalQuantity { get; set; }
        }
    }
}
