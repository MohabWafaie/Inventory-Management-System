﻿namespace InventoryManagementSystem.UserControllers
{
    partial class UserControl9
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
            label3 = new Label();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(496, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(472, 465);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(457, 48);
            label1.TabIndex = 1;
            label1.Text = "Product Movements Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 148);
            label2.Name = "label2";
            label2.Size = new Size(173, 25);
            label2.TabIndex = 2;
            label2.Text = "Choose Warehouses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 290);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 3;
            label3.Text = "Date";
            // 
            // button1
            // 
            button1.Location = new Point(177, 368);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(249, 101);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 144);
            checkedListBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 290);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // UserControl9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker1);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UserControl9";
            Size = new Size(981, 500);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private DateTimePicker dateTimePicker1;
    }
}
