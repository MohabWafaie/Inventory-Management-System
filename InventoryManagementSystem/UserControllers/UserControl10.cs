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

namespace InventoryManagementSystem.UserControllers
{
    public partial class UserControl10 : UserControl
    {
        ProductInWarehouseController pwc;
        public UserControl10()
        {
            InitializeComponent();
            pwc = new ProductInWarehouseController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var minDays = (int)numericUpDown1.Value;

            var data = pwc.GetAllProductsInWarehouse()
                .Where(p => (DateTime.Now - p.EntryDate).TotalDays >= minDays)
                .OrderByDescending(p => p.EntryDate)
                .ToList();

            dataGridView1.DataSource = data.Select(p => new
            {
                p.StockId,
                p.ProductId,
                ProductName = p.Product?.Name ?? "Unknown",
                WarehouseName = p.Warehouse?.Name ?? "Unknown",
                p.Quantity,
                DaysInWarehouse = (int)(DateTime.Now - p.EntryDate).TotalDays,
            }).ToList();
        }

    }
}
