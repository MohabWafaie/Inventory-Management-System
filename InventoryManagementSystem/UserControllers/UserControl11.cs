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
    public partial class UserControl11 : UserControl
    {
        ProductInWarehouseController pwc;
        public UserControl11()
        {
            InitializeComponent();
            pwc = new ProductInWarehouseController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var minDays = (int)numericUpDown1.Value;

            var data = pwc.GetAllProductsInWarehouse()
                .Where(p => (p.ExpiryDate - DateTime.Now).TotalDays <= minDays)
                .OrderBy(p => p.ExpiryDate)
                .ToList();

            dataGridView1.DataSource = data.Select(p => new
            {
                p.StockId,
                p.ProductId,
                ProductName = p.Product?.Name ?? "Unknown",
                WarehouseName = p.Warehouse?.Name ?? "Unknown",
                p.Quantity,
                p.ExpiryDate,
                DaysLeft = (int)(p.ExpiryDate - DateTime.Now).TotalDays + 1,
            }).ToList();
        }
    }
}
