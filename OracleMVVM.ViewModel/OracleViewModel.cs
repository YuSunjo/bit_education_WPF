using OracleMVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OracleMVVM.ViewModel
{
    public class OracleViewModel :INotifyPropertyChanged
    {
        private OracleModel _model;
        private Employee employee;
        public event PropertyChangedEventHandler PropertyChanged;
        private RelayCommand _oracleCommand;
        private RelayCommand _closeCommand;
        public string Number
        {
            get; set;
        }
        public OracleViewModel()
        {
            _model = new OracleModel();
        }
        public Employee GridEmployee
        {
            get
            {
                return employee;
            }
            private set
            {
                if(employee != value)
                {
                    employee = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GridEmployee"));
                }
            }
        }
        public ICommand EmployeeCommand
        {
            get
            {
                if(_oracleCommand ==null)
                {
                    _oracleCommand = new RelayCommand(param => this.EmployeeSearch());
                }
                return _oracleCommand;
            }
        }
        
        
        private void EmployeeSearch()
        {
            //GridEmployee = HrDAO.Instance.GetEmployee(Number);
            long id;
            if (Int64.TryParse(Number, out id))
            {
                try
                {
                    GridEmployee = HrDAO.Instance.GetEmployee(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error contatcing database");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }

        private ICollection<Employee> employees;

        public ICollection<Employee> Emp_List
        {
            get
            {
                return employees;
            }
            private set
            {
                if (employees != value)
                {
                    employees = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Emp_List"));
                }
            }
        }
        public ICommand EmployeeListCommand
        {
            get
            {
                if (_oracleCommand == null)
                {
                    _oracleCommand = new RelayCommand(param => this.EmployeeListSearch());
                }
                return _oracleCommand;
            }
        }

        private void EmployeeListSearch()
        {
            Emp_List = HrDAO.Instance.GetEmployeeList();
        }


        public ICollection<Employee> GridEmployees
        {
            get
            {
                return employees;
            }
            private set
            {
                if (employees != value)
                {
                    employees = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GridEmployees"));
                }
            }
        }
        public ICommand GridDataCommand
        {
            get
            {
                if (_oracleCommand == null)
                {
                    _oracleCommand = new RelayCommand(param => this.GridDataSearch());
                }
                return _oracleCommand;
            }
        }

        private void GridDataSearch()
        {
            GridEmployees = HrDAO.Instance.GetEmployeeList();
        }

       
        public ICommand OkCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand(param => this.CloseWindow(param));
                }
                return _closeCommand;
            }
        }
        private void CloseWindow(object obj)
        {
            Window win = obj as Window;
            win.Close();
        }
    }
    
    
}
