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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OracleMVVM.View
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
   

        private void BtnEmp_Click(object sender, RoutedEventArgs e)
        {
            EmpWindow window = new EmpWindow();
            window.Show();
        }

        private void BtnEmpList_Click(object sender, RoutedEventArgs e)
        {
            EmpListWindow window = new EmpListWindow();
            window.Show();
        }

        private void BtnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            DataGridWindow window = new DataGridWindow();
            window.Show();
        }
    }
}
