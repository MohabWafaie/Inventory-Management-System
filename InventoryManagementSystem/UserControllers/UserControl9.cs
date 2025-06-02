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
    public partial class UserControl9 : UserControl
    {
        WarehouseController wc;
        ProductMovementController pmc;
        public UserControl9()
        {
            InitializeComponent();
            wc = new WarehouseController();
            pmc = new ProductMovementController();

            var warehouses = wc.GetAllWarehouses();
            checkedListBox1.Items.Clear();
            checkedListBox1.DataSource = warehouses;
            checkedListBox1.DisplayMember = "Name";
            checkedListBox1.ValueMember = "ID";
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
                .Select(g => new
                {
                    g.WarehouseId,
                    g.Warehouse.Name,
                    g.ProductId,
                    ProductName = g.Product.Name,
                    g.Quantity,
                    g.MovementDate,
                    MovementType = g.MovementType.ToString(),
                    SourceEntityType = g.SourceEntityType.ToString(),
                    g.SourceEntityId,
                    g.ProductionDate,
                    g.ExpiryDate
                })
                .ToList();

            dataGridView1.DataSource = data;
        }
    }
}
