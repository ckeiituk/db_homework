using Database;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

namespace DatabaseK
{
    enum jobs { Èíæåíåð, Âðà÷, Ó÷èòåëü };
    public partial class Form1 : Form
    {

        BindingList<Employee> employees = new();
        BindingList<Employee> backup = new();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dbh = DBHelper.GetInstance(
                "185.104.248.247",
                "root",
                "pass",
                "persons"
                );
            employees = dbh.GetData();
            dataGridView1.DataSource = employees;
        }

        private void äîáàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backup.Clear();
            foreach (var t in employees)
                backup.Add(t);
            var newEmp = new Employee()
            {
                EId = (employees.Count > 0) ?
            employees.Last().EId + 1 : 1,
                Job_id = 1

            };
            var ef = new EditForm(newEmp, true);
            if (ef.ShowDialog() == DialogResult.OK)
            {

                employees.Add(newEmp);
            }
        }

        private void èçìåíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backup.Clear();
            foreach (var t in employees)
                backup.Add(t);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var ind = dataGridView1.SelectedRows[0].Index;
                var emp = employees[ind];
                var emp_cp = new Employee();
                emp.CopyTo(emp_cp);
                var ef = new EditForm(emp_cp);
                if (ef.ShowDialog() == DialogResult.OK)
                {
                    emp_cp.CopyTo(emp);
                }
            }
        }

        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backup.Clear();
            foreach (var t in employees)
                backup.Add(t);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var ind = dataGridView1.SelectedRows[0].Index;
                var emp = employees[ind];
                employees.Remove(emp);
                DBHelper.GetInstance().Remove(emp);
            }
        }

        private void î÷èñòèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backup.Clear();
            foreach (var t in employees)
                backup.Add(t);
            employees.Clear();
            DBHelper.GetInstance().Clear();
        }

        private void íàçàäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBHelper.GetInstance().Clear();
            employees.Clear();
            foreach (var t in backup)
            {
                employees.Add(t);
                DBHelper.GetInstance().InsertNew(t);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
                dataGridView1.DataSource = employees;

            else
            {
                BindingList<Employee> filtered = new();
                foreach (var t in employees)
                {
                    if (toolStripComboBox1.SelectedIndex - 1 == t.Job_id)
                        filtered.Add(t);
                }
                dataGridView1.DataSource = filtered;
            }
        }
    }
}