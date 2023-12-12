namespace InventoryManagement
{
    partial class sales
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            listBox1 = new ListBox();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1823, 164);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(1381, 41);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(340, 43);
            dateTimePicker1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(532, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 43);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CASH", "DEBIT" });
            comboBox1.Location = new Point(908, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 45);
            comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(168, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 43);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1240, 43);
            label4.Name = "label4";
            label4.Size = new Size(126, 37);
            label4.TabIndex = 3;
            label4.Text = "Bill Date";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(775, 43);
            label3.Name = "label3";
            label3.Size = new Size(127, 37);
            label3.TabIndex = 2;
            label3.Text = "Bill Type";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(386, 46);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 1;
            label2.Text = "Lastname";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 49);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 0;
            label1.Text = "Firstname";
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(25, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(1823, 300);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1565, 148);
            button3.Name = "button3";
            button3.Size = new Size(236, 46);
            button3.TabIndex = 13;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(168, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 164);
            listBox1.TabIndex = 12;
            listBox1.Visible = false;
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(1390, 38);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 43);
            textBox6.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1302, 41);
            label8.Name = "label8";
            label8.Size = new Size(82, 37);
            label8.TabIndex = 10;
            label8.Text = "Total";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(925, 41);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 43);
            textBox5.TabIndex = 9;
            textBox5.Leave += textBox5_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(790, 44);
            label7.Name = "label7";
            label7.Size = new Size(129, 37);
            label7.TabIndex = 8;
            label7.Text = "Quantity";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(532, 44);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 43);
            textBox4.TabIndex = 7;
            textBox4.Enter += textBox4_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(434, 47);
            label6.Name = "label6";
            label6.Size = new Size(81, 37);
            label6.TabIndex = 6;
            label6.Text = "Price";
            label6.Click += label6_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(168, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 43);
            textBox3.TabIndex = 5;
            textBox3.KeyDown += textBox3_KeyDown;
            textBox3.KeyUp += textBox3_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 50);
            label5.Name = "label5";
            label5.Size = new Size(119, 37);
            label5.TabIndex = 1;
            label5.Text = "Product";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 520);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1258, 530);
            dataGridView1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1327, 629);
            label9.Name = "label9";
            label9.Size = new Size(188, 37);
            label9.TabIndex = 9;
            label9.Text = "Grand Total : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1544, 629);
            label10.Name = "label10";
            label10.Size = new Size(33, 37);
            label10.TabIndex = 10;
            label10.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1327, 758);
            button1.Name = "button1";
            button1.Size = new Size(279, 54);
            button1.TabIndex = 11;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1327, 872);
            button2.Name = "button2";
            button2.Size = new Size(385, 62);
            button2.TabIndex = 12;
            button2.Text = "Save and Print Bill";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // sales
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1860, 1082);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "sales";
            Text = "sales";
            Load += sales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}