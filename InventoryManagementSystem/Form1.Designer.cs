namespace InventoryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            userControl11 = new UserControl1();
            userControl21 = new InventoryManagementSystem.UserControllers.UserControl2();
            userControl31 = new InventoryManagementSystem.UserControllers.UserControl3();
            userControl41 = new InventoryManagementSystem.UserControllers.UserControl4();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            userControl51 = new InventoryManagementSystem.UserControllers.UserControl5();
            userControl61 = new InventoryManagementSystem.UserControllers.UserControl6();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 189);
            label1.Name = "label1";
            label1.Size = new Size(928, 65);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Inventory Management System";
            // 
            // userControl11
            // 
            userControl11.Location = new Point(224, 0);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(1470, 750);
            userControl11.TabIndex = 2;
            // 
            // userControl21
            // 
            userControl21.Location = new Point(224, 0);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(1470, 750);
            userControl21.TabIndex = 3;
            // 
            // userControl31
            // 
            userControl31.Location = new Point(224, 0);
            userControl31.Name = "userControl31";
            userControl31.Size = new Size(1470, 750);
            userControl31.TabIndex = 4;
            // 
            // userControl41
            // 
            userControl41.Location = new Point(224, -11);
            userControl41.Name = "userControl41";
            userControl41.Size = new Size(1470, 750);
            userControl41.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(42, 87);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 0;
            button1.Text = "Products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(42, 35);
            button2.Name = "button2";
            button2.Size = new Size(123, 34);
            button2.TabIndex = 1;
            button2.Text = "Warehouses";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(42, 137);
            button3.Name = "button3";
            button3.Size = new Size(123, 34);
            button3.TabIndex = 2;
            button3.Text = "Clients";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(42, 189);
            button4.Name = "button4";
            button4.Size = new Size(123, 34);
            button4.TabIndex = 3;
            button4.Text = "Suppliers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 636);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(12, 243);
            button5.Name = "button5";
            button5.Size = new Size(200, 34);
            button5.TabIndex = 4;
            button5.Text = "Make a Supply Permit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // userControl51
            // 
            userControl51.Location = new Point(224, 0);
            userControl51.Name = "userControl51";
            userControl51.Size = new Size(1470, 750);
            userControl51.TabIndex = 6;
            // 
            // userControl61
            // 
            userControl61.Location = new Point(224, 0);
            userControl61.Name = "userControl61";
            userControl61.Size = new Size(1470, 934);
            userControl61.TabIndex = 7;
            // 
            // button6
            // 
            button6.Location = new Point(3, 292);
            button6.Name = "button6";
            button6.Size = new Size(215, 34);
            button6.TabIndex = 5;
            button6.Text = "Make a Withdraw Permit";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 636);
            Controls.Add(userControl61);
            Controls.Add(userControl51);
            Controls.Add(userControl41);
            Controls.Add(userControl31);
            Controls.Add(userControl21);
            Controls.Add(userControl11);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private UserControl1 userControl11;
        private UserControllers.UserControl2 userControl21;
        private UserControllers.UserControl3 userControl31;
        private UserControllers.UserControl4 userControl41;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Button button5;
        private UserControllers.UserControl5 userControl51;
        private Button button6;
        private UserControllers.UserControl6 userControl61;
    }
}
