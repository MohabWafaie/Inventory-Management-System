namespace InventoryManagementSystem
{
    partial class UserControl1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(498, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(452, 436);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(147, 335);
            button1.Name = "button1";
            button1.Size = new Size(163, 34);
            button1.TabIndex = 1;
            button1.Text = "Display Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(47, 400);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(288, 400);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 112);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 159);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 211);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 265);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(175, 32);
            label5.Name = "label5";
            label5.Size = new Size(159, 48);
            label5.TabIndex = 12;
            label5.Text = "Products";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "UserControl1";
            Size = new Size(980, 500);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
    }
}
