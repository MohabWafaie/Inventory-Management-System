using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class UserControl1 : UserControl
    {
        ProductController productController;
        public UserControl1()
        {
            InitializeComponent();
            productController = new ProductController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display data in DataGridView
            var data = productController.GetAllProducts()
            .Select(p => new
            {
                p.ProductID,
                p.Name,
                p.Description,
                p.Price
            }).ToList();

            dataGridView1.DataSource = data;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Name = textBox2.Text,
                Description = textBox3.Text,
                Price = decimal.Parse(textBox4.Text)
            };
            productController.AddProduct(p);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Product product = productController.GetProductById(int.Parse(textBox1.Text));
            product.Name = textBox2.Text;
            product.Description = textBox3.Text;
            product.Price = decimal.Parse(textBox4.Text);
            productController.UpdateProduct(product);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
        }
    }
}
