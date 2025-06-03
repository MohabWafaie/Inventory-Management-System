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
    public partial class UserControl12 : UserControl
    {
        ProductInWarehouseController pwc;
        WithdrawPermitController wpc;
        WithdrawPermitProductController wppc;
        ClientController cc;
        WarehouseController wc;
        ProductController productController;
        public UserControl12()
        {
            InitializeComponent();
            pwc = new ProductInWarehouseController();
            wpc = new WithdrawPermitController();
            wppc = new WithdrawPermitProductController();
            cc = new ClientController();
            wc = new WarehouseController();
            productController = new ProductController();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
