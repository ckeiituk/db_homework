using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Database
{
    public class Employee : INotifyPropertyChanged
    {
        private int _eid;
        private string _first_name ;
        private string _second_name;
        private string _phone;
        private int _salary;
        private int _jid;

        public int EId { get => _eid;
            set 
            {
                _eid = value;
                OnPropertyChanged(nameof(EId));
            } 
        }
        [DisplayName("Имя")]
        public string First_name 
        {
            get => _first_name ;
            set
            {
                _first_name  = value;
                OnPropertyChanged(nameof(First_name ));
            }
        }
        [DisplayName("Фамилия")]
        public string Second_name
        {
            get => _second_name;
            set { _second_name = value; OnPropertyChanged(nameof(Second_name)); }
        }
        [DisplayName("Номер телефона")]
        public string Phone_number
        {
            get => _phone;
            set
            {
                //if (value[0] != '+') throw new Exception("Неправильный формат номера телефона");
                _phone = value;
                OnPropertyChanged(nameof(Phone_number));

            }
        }
        [DisplayName("Зарплата")]
        public int Salary { get => _salary; set { _salary = value; OnPropertyChanged(nameof(Salary)); } }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public int Job_id
        {
            get => _jid;
            set
            {
                
                _jid = value;
                OnPropertyChanged(nameof(Job_id));
            }
        }

        internal void CopyTo(Employee emp_cp)
        {
            emp_cp.EId = EId;
            emp_cp.First_name  = First_name ;
            emp_cp.Second_name = Second_name;
            emp_cp.Phone_number = Phone_number;
            emp_cp.Salary = Salary;
            emp_cp._jid = Job_id;
        }
    }
}
