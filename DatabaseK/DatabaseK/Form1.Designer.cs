namespace DatabaseK
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            назадToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(801, 419);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, изменитьToolStripMenuItem, удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(157, 76);
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(156, 24);
            добавитьToolStripMenuItem.Text = "Добавить...";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(156, 24);
            изменитьToolStripMenuItem.Text = "Изменить...";
            изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(156, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { очиститьToolStripMenuItem, назадToolStripMenuItem, toolStripComboBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(87, 28);
            очиститьToolStripMenuItem.Text = "Очистить";
            очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
            // 
            // назадToolStripMenuItem
            // 
            назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            назадToolStripMenuItem.Size = new Size(65, 28);
            назадToolStripMenuItem.Text = "Назад";
            назадToolStripMenuItem.Click += назадToolStripMenuItem_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Items.AddRange(new object[] { "Все", "Инженер", "Врач", "Учитель" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem назадToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
    }
}