using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Database
{
    public class DBHelper
    {
        private static MySqlConnection? _connection = null;
        private DBHelper(
            String host,
            String user,
            String password,
            String database
            )
        {
            var connStr = $"Server={host};Database={database};Uid={user};Pwd={password}";
            _connection = new MySqlConnection(connStr);
            _connection?.Open();
        }

        private static DBHelper instance = null;

        public static DBHelper GetInstance(
            String host = "185.104.248.247",
            String user = "root",
            String password = "pass",
            String database = "persons"
            )
        {
            if(instance == null )
            {
                instance = new DBHelper(host, user, password, database);
            }
            return instance;
        }
        public BindingList<Employee> GetData()
        {
            BindingList<Employee> employees = new BindingList<Employee>();
            var queryStr = "SELECT * FROM Employees";
            var cmd = _connection?.CreateCommand();
            cmd.CommandText = queryStr;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            EId = reader.GetInt32(nameof(Employee.EId)),
                            First_name = reader.GetString(nameof(Employee.First_name)),
                            Second_name = reader.GetString(nameof(Employee.Second_name)),
                            Phone_number = reader.GetString(nameof(Employee.Phone_number)),
                            Salary = reader.GetInt32(nameof(Employee.Salary)),
                            Job_id = reader.GetInt32(nameof(Employee.Job_id))
                        });
                    }
                }
            }
            return employees;
        }

        internal void InsertNew(Employee newEmp)
        {
            var cmd = _connection.CreateCommand();
            cmd.CommandText = "INSERT INTO `Employees`(`eid`, `first_name`, `second_name`, `phone_number`, `salary`, `job_id`) " +
                "Value (@id, @name, @sname, @phone, @salary, @jid);";
            cmd.Parameters.Add(new MySqlParameter("@id", newEmp.EId));
            cmd.Parameters.Add(new MySqlParameter("@name", newEmp.First_name ));
            cmd.Parameters.Add(new MySqlParameter("@sname", newEmp.Second_name));
            cmd.Parameters.Add(new MySqlParameter("@phone", newEmp.Phone_number));
            cmd.Parameters.Add(new MySqlParameter("@salary", newEmp.Salary));
            cmd.Parameters.Add(new MySqlParameter("@jid", newEmp.Job_id));
            cmd.ExecuteNonQuery();
        }

        internal void Update(Employee newEmp)
        {
            var cmd = _connection.CreateCommand();
            cmd.CommandText = "UPDATE `Employees` " +
                "SET `first_name` = @name, " +
                "`second_name` = @sname, " +
                "`phone_number` =  @phone, " +
                "`salary` = @salary, " +
                "`job_id` = @jid " +
                "WHERE `eid` = @id;";
            cmd.Parameters.Add(new MySqlParameter("@id", newEmp.EId));
            cmd.Parameters.Add(new MySqlParameter("@name", newEmp.First_name ));
            cmd.Parameters.Add(new MySqlParameter("@sname", newEmp.Second_name));
            cmd.Parameters.Add(new MySqlParameter("@phone", newEmp.Phone_number));
            cmd.Parameters.Add(new MySqlParameter("@salary", newEmp.Salary));
            cmd.Parameters.Add(new MySqlParameter("@jid", newEmp.Job_id));
            cmd.ExecuteNonQuery();
        }

        internal void Remove(Employee emp)
        {
            var cmd = _connection.CreateCommand();
            cmd.CommandText = "DELETE FROM `Employees` WHERE `eid` = @id";
            cmd.Parameters.Add(new MySqlParameter("@id", emp.EId));
            cmd.ExecuteNonQuery();
        }

        internal void Clear()
        {
            var cmd = _connection.CreateCommand();
            cmd.CommandText = "DELETE FROM `Employees`";
            cmd.ExecuteNonQuery();
        }

    }
}
