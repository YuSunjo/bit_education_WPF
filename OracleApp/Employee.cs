using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleApp
{
    class Employee
    {
        public long Employee_id
        {
            get; set;
        }
        public string First_name
        {
            get; set;
        }
        public string Last_name
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public string Phone_number
        {
            get; set;
        }

        public DateTime hire_date
        {
            get; set;
        }
        public string JOB_ID
        {
            get; set;
        }
        public double Salary
        {
            get; set;
        }
        public double Commision_pct
        {
            get; set;
        }
        public long Manager_id
        {
            get; set;
        }
        public int Department_id
        {
            get; set;
        }
    }
}
