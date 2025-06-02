namespace InventoryManagementSystem.UserControllers
{
    partial class UserControl10
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(426, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(540, 469);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(409, 54);
            label1.TabIndex = 1;
            label1.Text = "Product Aging Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 141);
            label2.Name = "label2";
            label2.Size = new Size(219, 25);
            label2.TabIndex = 2;
            label2.Text = "Products in warehouse for";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(247, 141);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 31);
            numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 141);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 4;
            label3.Text = "Days or more";
            // 
            // button1
            // 
            button1.Location = new Point(129, 275);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserControl10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UserControl10";
            Size = new Size(978, 499);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button button1;
    }
}
