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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace InventoryManagementSystem.UserControllers
{
    public partial class UserControl7 : UserControl
    {
        WarehouseController wc;
        ProductMovementController pmc;
        public UserControl7()
        {
            InitializeComponent();
            wc = new WarehouseController();
            pmc = new ProductMovementController();

            var warehouses = wc.GetAllWarehouses();
            checkedListBox1.Items.Clear();
            checkedListBox1.DataSource = warehouses;
            checkedListBox1.DisplayMember = "Name";
            checkedListBox1.ValueMember = "ID"; // Optional, for identification
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedWarehouseIds = checkedListBox1.CheckedItems
                .Cast<Warehouse>()
                .Select(w => w.Id)
                .ToList();

            var data = pmc.GetProductMovements()
                .Where(pm => selectedWarehouseIds.Contains(pm.WarehouseId)
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
                .Where(g => g.Sum(pm => pm.Quantity) > 0) // Filter out groups with zero total quantity
                .Select(g => new
                {
                    g.Key.WarehouseId,
                    g.Key.WarehouseName,
                    g.Key.ProductId,
                    g.Key.ProductName,
                    TotalQuantity = g.Sum(pm => pm.Quantity)
                })
                .ToList();

            dataGridView1.DataSource = groupedData;
        }
    }
}
