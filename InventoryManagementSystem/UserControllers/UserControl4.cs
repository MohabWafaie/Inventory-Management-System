using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Controllers;

namespace InventoryManagementSystem.UserControllers
{
    public partial class UserControl4: UserControl
    {
        SupplierController sc;
        public UserControl4()
        {
            InitializeComponent();
            sc = new SupplierController();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var data = sc.GetAllSuppliers()
                .Select(c => new
                {
                    c.ID,
                    c.Name,
                    c.Email,
                    c.PhoneNumber,
                    c.Fax,
                    c.Website
                }).ToList();
            dataGridView1.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier
            {
                Name = textBox2.Text,
                Email = textBox3.Text,
                PhoneNumber = textBox4.Text,
                Fax = textBox5.Text,
                Website = textBox6.Text
            };
            sc.AddSupplier(s);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Supplier supplier = sc.GetSupplierById(int.Parse(textBox1.Text));
            supplier.Name = textBox2.Text;
            supplier.Email = textBox3.Text;
            supplier.PhoneNumber = textBox4.Text;
            supplier.Fax = textBox5.Text;
            supplier.Website = textBox6.Text;
            sc.UpdateSupplier(supplier);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = string.Empty;
        }
    }
}
