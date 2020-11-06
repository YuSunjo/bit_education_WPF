using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OracleMVVM.Model
{
    public class HrDAO
    {
        private string connectionString;
        private static readonly HrDAO instance = new HrDAO();
        private HrDAO()
        {
            connectionString = Properties.Settings.Default.ConString;
        }
        public static HrDAO Instance
        {
            get
            {
                return instance;
            }
        }
        public Employee GetEmployee(long empId)
        {
            Employee emp = new Employee();
            string sql = "select * from employees where employee_id = :emp_id ";      //변수를 만들어줌 

            try
            {
                //오라클 접속이 이루어짐 
                using (OracleConnection conn = new OracleConnection(connectionString))   //쿼리 연결하기 ...
                {
                    OracleCommand cmd = new OracleCommand(sql, conn)
                    { CommandType = CommandType.Text, BindByName = true };
                    cmd.Parameters.Add(":emp_id", OracleDbType.Long).Value = empId;     //위에서 만들어준 변수를 여기에 씀
                    conn.Open();                             //쿼리 날리기 ... 

                    using (OracleDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            emp.Employee_id = reader.GetInt64(0);                //첫번째 column값을 가져옴 
                            emp.First_name = reader.GetString(1);
                            emp.Last_name = reader.GetString(2);
                            emp.Email = reader.GetString(3);
                            emp.Phone_number = reader.GetString(4);
                            emp.hire_date = reader.GetDateTime(5);
                            emp.JOB_ID = reader.GetString(6);
                            emp.Salary = reader.GetDouble(7);
                            emp.Commision_pct = reader.IsDBNull(8) ? 0.0 : reader.GetDouble(8);    // null이 많기 때문에 
                            emp.Manager_id = reader.IsDBNull(9) ? 0 : reader.GetInt64(9);
                            emp.Department_id = reader.IsDBNull(10) ? 0 : reader.GetInt32(10);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return emp;
        }

        public ICollection<Employee> GetEmployeeList()         //모든 컬렉션을 사용 가능 
        {
            ICollection<Employee> empList = new List<Employee>();              //이거 주의!!!!!
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    //테이블 다 가져올때는 편한걸 제공함
                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.TableDirect;

                    cmd.CommandText = "Employees";
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee emp = new Employee();

                            emp.Employee_id = reader.GetInt64(0);                //첫번째 column값을 가져옴 
                            emp.First_name = reader.GetString(1);
                            emp.Last_name = reader.GetString(2);
                            emp.Email = reader.GetString(3);
                            emp.Phone_number = reader.GetString(4);
                            emp.hire_date = reader.GetDateTime(5);
                            emp.JOB_ID = reader.GetString(6);
                            emp.Salary = reader.GetDouble(7);
                            emp.Commision_pct = reader.IsDBNull(8) ? 0.0 : reader.GetDouble(8);
                            emp.Manager_id = reader.IsDBNull(9) ? 0 : reader.GetInt64(9);
                            emp.Department_id = reader.IsDBNull(10) ? 0 : reader.GetInt32(10);

                            empList.Add(emp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return empList;
        }
        public DataSet GetInfo()
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.TableDirect;
                    cmd.CommandText = "Locations";
                    cmd.Connection = conn;

                    OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(cmd);
                    oracleDataAdapter.Fill(dataSet, "LocData");   //LocData = > 키값임


                    cmd.CommandText = "Jobs";
                    oracleDataAdapter.Fill(dataSet, "JobData");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return dataSet;
        }
    }
}
