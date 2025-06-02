namespace InventoryManagementSystem.UserControllers
{
    partial class UserControl11
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(460, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(504, 469);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(146, 340);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(448, 54);
            label1.TabIndex = 2;
            label1.Text = "Near Expiry Date Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 156);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 3;
            label2.Text = "Products which have";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 158);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 4;
            label3.Text = "Days left until expiry";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(177, 156);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 31);
            numericUpDown1.TabIndex = 5;
            // 
            // UserControl11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "UserControl11";
            Size = new Size(980, 500);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}
