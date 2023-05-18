namespace DatabaseK
{
    partial class EditForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 4);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(776, 395);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 300);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 12;
            label5.Text = "Профессия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 75);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 150);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Номер телефона";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 225);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Зарплата";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(235, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(538, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(235, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(538, 27);
            textBox1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Инженер", "Врач", "Учитель" });
            comboBox1.Location = new Point(235, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(538, 28);
            comboBox1.TabIndex = 14;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown2.Location = new Point(235, 228);
            numericUpDown2.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(538, 27);
            numericUpDown2.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(235, 153);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(538, 27);
            textBox4.TabIndex = 8;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(15, 413);
            button1.Name = "button1";
            button1.Size = new Size(203, 29);
            button1.TabIndex = 1;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(585, 413);
            button2.Name = "button2";
            button2.Size = new Size(203, 29);
            button2.TabIndex = 2;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Name = "EditForm";
            Text = "EditForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox4;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}