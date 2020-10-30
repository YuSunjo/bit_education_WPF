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
    /// DataGridWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DataGridWindow : Window
    {
        private ICollection<Employee> employees;
        public DataGridWindow()
        {
            InitializeComponent();
        }

        private void cmdGetEmployees_click(object sender, RoutedEventArgs e)
        {
            employees = HrDAO.Instance.GetEmployeeList();
            gridEmployees.ItemsSource = employees;
        }
    }
}
