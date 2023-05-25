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
            var cB1 = textBox1.DataBindings.Add(nameof(TextBox.Text), _emp, nameof(Employee.First_name));
            cB1.FormattingEnabled = true;
            cB1.BindingComplete += CBinding_BindingComplete;
            var cB2 = textBox2.DataBindings.Add(nameof(TextBox.Text), _emp, nameof(Employee.Second_name));
            cB2.FormattingEnabled = true;
            cB2.BindingComplete += CBinding_BindingComplete;
            numericUpDown2.DataBindings.Add(nameof(NumericUpDown.Value), _emp, nameof(Employee.Salary));
            var cBinding = textBox4.DataBindings.Add(nameof(TextBox.Text), _emp, nameof(Employee.Phone_number));
            comboBox1.DataBindings.Add(nameof(ComboBox.SelectedIndex), _emp, nameof(Employee.Job_id));
            cBinding.FormattingEnabled = true;
            cBinding.BindingComplete += CBinding_BindingComplete;
        }

        private void CBinding_BindingComplete(object? sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteState == BindingCompleteState.Exception)
            {
                if ("Неправильный формат номера телефона" == e.Exception.Message)
                {
                    // e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate;
                    textBox4.BackColor = Color.LightCoral;
                }
                else if ("Введите фамилию!" == e.Exception.Message)
                {
                    textBox2.BackColor = Color.LightCoral;
                }
                else if ("Введите имя!" == e.Exception.Message)
                {
                    textBox1.BackColor = Color.LightCoral;
                }
                e.Cancel = false;
            }
            _bindingException = e.Exception;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_emp.First_name))
                    textBox1.BackColor = Color.LightCoral;
                if (string.IsNullOrEmpty(_emp.Second_name))
                    textBox2.BackColor = Color.LightCoral;
                if (string.IsNullOrEmpty(_emp.First_name))
                    textBox4.BackColor = Color.LightCoral;
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
            //e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }
    }
}
