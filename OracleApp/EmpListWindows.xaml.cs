using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OracleApp
{
    /// <summary>
    /// EmpListWindows.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EmpListWindows : Window
    {
        private ICollection<Employee> employees;
        public EmpListWindows()
        {
            InitializeComponent();
        }
        //Emp_List.Items.Add
        private void cmdGetEmployee_Click(object sender, RoutedEventArgs e)
        {
            employees = HrDAO.Instance.GetEmployeeList();
            //listBox에서는 itemsSource를 사용함  Grid는 DataContext 
            Emp_List.ItemsSource = employees;

        }

        private void cmdConfirm_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
