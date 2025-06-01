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
    public partial class UserControl3 : UserControl
    {
        ClientController cc;
        public UserControl3()
        {
            InitializeComponent();
            cc = new ClientController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = cc.GetAllClients()
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
            Client c = new Client
            {
                Name = textBox2.Text,
                Email = textBox3.Text,
                PhoneNumber = textBox4.Text,
                Fax = textBox5.Text,
                Website = textBox6.Text
            };
            cc.AddClient(c);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client client = cc.GetClientById(int.Parse(textBox1.Text));
            client.Name = textBox2.Text;
            client.Email = textBox3.Text;
            client.PhoneNumber = textBox4.Text;
            client.Fax = textBox5.Text;
            client.Website = textBox6.Text;
            cc.UpdateClient(client);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = string.Empty;
        }
    }
}
