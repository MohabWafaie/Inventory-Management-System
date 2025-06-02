namespace InventoryManagementSystem.UserControllers
{
    partial class UserControl8
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
            label4 = new Label();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(480, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(486, 464);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 65);
            label1.TabIndex = 1;
            label1.Text = "Products Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 122);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 2;
            label2.Text = "Choose Products";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 285);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 3;
            label3.Text = "Choose Warehouses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 394);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 4;
            label4.Text = "Date";
            // 
            // button1
            // 
            button1.Location = new Point(179, 450);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(179, 65);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 144);
            checkedListBox1.TabIndex = 6;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(179, 231);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(180, 144);
            checkedListBox2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(144, 394);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // UserControl8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker1);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UserControl8";
            Size = new Size(981, 504);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private DateTimePicker dateTimePicker1;
    }
}
