using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseK
{
    public partial class EditForm : Form
    {
        private Employee _emp;
        private bool newRow;
        private Exception _bindingException;
        public EditForm(Employee emp, bool newRow = false)
        {
            this.newRow = newRow;
            InitializeComponent();
            _emp = emp;
            textBox1.DataBindings.Add(nameof(TextBox.Text), _emp, nameof(Employee.First_name));
            textBox2.DataBindings.Add(nameof(TextBox.Text), _emp, nameof(Employee.Second_name));
            var cBinding = numericUpDown2.DataBindings.Add(nameof(NumericUpDown.Value), _emp, nameof(Employee.Salary));
            textBox4.DataBindings.Add(nameof(TextBox.Text), _emp, nameof(Employee.Phone_number));
            comboBox1.DataBindings.Add(nameof(ComboBox.SelectedIndex), _emp, nameof(Employee.Job_id));
            cBinding.FormattingEnabled = true;
            cBinding.BindingComplete += CBinding_BindingComplete;
        }

        private void CBinding_BindingComplete(object? sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteState == BindingCompleteState.Exception)
            {
                e.Cancel = false;
                // e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate;
                textBox4.BackColor = Color.LightCoral;
            }
            _bindingException = e.Exception;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bindingException != null)
                {
                    MessageBox.Show("Неверно указаны данные!");
                }
                else
                {
                    if (newRow)
                        DBHelper.GetInstance().InsertNew(_emp);
                    else DBHelper.GetInstance().Update(_emp);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления новой записи в базу данных!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }
    }
}
