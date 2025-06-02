namespace InventoryManagementSystem.UserControllers
{
    partial class UserControl7
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
            dateTimePicker1 = new DateTimePicker();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(451, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(516, 466);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(439, 65);
            label1.TabIndex = 1;
            label1.Text = "Warehouses Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 131);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 2;
            label2.Text = "Choose Warehose";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 260);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 3;
            label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(117, 260);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(203, 80);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 144);
            checkedListBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(156, 392);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserControl7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UserControl7";
            Size = new Size(981, 501);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private CheckedListBox checkedListBox1;
        private Button button1;
    }
}
