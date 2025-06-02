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
    public partial class UserControl8 : UserControl
    {
        ProductController pc;
        ProductMovementController pmc;
        WarehouseController wc;
        public UserControl8()
        {
            InitializeComponent();
            pc = new ProductController();
            pmc = new ProductMovementController();
            wc = new WarehouseController();

            var products = pc.GetAllProducts();
            checkedListBox1.Items.Clear();
            checkedListBox1.DataSource = products;
            checkedListBox1.DisplayMember = "Name"; 
            checkedListBox1.ValueMember = "ProductID"; 

            var warehouses = wc.GetAllWarehouses();
            checkedListBox2.Items.Clear();
            checkedListBox2.DataSource = warehouses;
            checkedListBox2.DisplayMember = "Name";
            checkedListBox2.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedWarehouseIds = checkedListBox2.CheckedItems
                .Cast<Warehouse>()
                .Select(w => w.Id)
                .ToList();

            var selectedProductIds = checkedListBox1.CheckedItems
                .Cast<Product>()
                .Select(p => p.ProductID)
                .ToList();

            var data = pmc.GetProductMovements()
                .Where(pm => selectedWarehouseIds.Contains(pm.WarehouseId)
                          && selectedProductIds.Contains(pm.ProductId)
                          && pm.MovementDate <= dateTimePicker1.Value)
                .ToList();

            var groupedData = data
                .GroupBy(pm => new
                {
                    pm.WarehouseId,
                    WarehouseName = pm.Warehouse.Name,
                    pm.ProductId,
                    ProductName = pm.Product.Name
                })
                .Select(g => new
                {
                    g.Key.ProductId,
                    g.Key.ProductName,
                    g.Key.WarehouseId,
                    g.Key.WarehouseName,
                    TotalQuantity = g.Sum(pm => pm.Quantity)
                })
                .ToList();

            dataGridView1.DataSource = groupedData;
        }
    }
}
