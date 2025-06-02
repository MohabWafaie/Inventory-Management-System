namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideAllUserControls();
        }
        private void hideAllUserControls()
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            userControl11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            userControl21.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            userControl31.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            userControl41.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            userControl51.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            userControl61.Show();
        }
    }
}
