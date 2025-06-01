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
    public partial class UserControl2 : UserControl
    {
        WarehouseController wc;
        public UserControl2()
        {
            InitializeComponent();
            wc = new WarehouseController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = wc.GetAllWarehouses()
                .Select(w => new
                {
                    w.Id,
                    w.Name,
                    w.Location,
                    w.Manager
                }).ToList();
            dataGridView1.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Warehouse w = new Warehouse
            {
                Name = textBox2.Text,
                Location = textBox3.Text,
                Manager = textBox4.Text
            };
            wc.AddWarehouse(w);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = wc.GetWarehouseById(int.Parse(textBox1.Text));
            warehouse.Name = textBox2.Text;
            warehouse.Location = textBox3.Text;
            warehouse.Manager = textBox4.Text;
            wc.UpdateWarehouse(warehouse);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
        }
    }
}
