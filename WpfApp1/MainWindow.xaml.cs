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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //xaml에서 지어준 이름으로 접근 가능함...
            //MessageBox.Show(String.Format("The grid is {0}x{1} units in size.",myGrid.ActualWidth, myGrid.ActualHeight));
        }

        //xaml코드에서 f12누르면 자동으로 함수를 만들어줌 
        //private void cmdAnswer_Click(object sender, RoutedEventArgs e)
        //{

        //    // Dramatic delay...
        //    this.Cursor = Cursors.Wait;
        //    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));

        //    AnswerGenerator generator = new AnswerGenerator();
        //    txtAnswer.Text = generator.GetRandomAnswer(txtQuestion.Text);
        //    this.Cursor = null;

            
      
        //}
    }
}
