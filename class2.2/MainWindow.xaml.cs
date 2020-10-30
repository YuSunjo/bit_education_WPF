using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace class2._2
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

        private void cmd_SetSmall(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 2;
        }

        //window 자체의 fontsize
        private void cmd_SetNormal(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = this.FontSize;
        }
        //직접 값을 줬을 경우 바인딩이 깨짐 (mode가 oneway일 경우) twoway일 경우 됨 
        private void cmd_SetLarge(object sender, RoutedEventArgs e)
        {
            lblSampleText.FontSize = 30;
        }

        //private void MouseMoved(object sender, MouseEventArgs e)
        //{
        //    Point pt = e.GetPosition(this);
        //    lblInfo.Text =
        //        String.Format("You are at ({0},{1}) in window coordinates",
        //        pt.X, pt.Y);
        //}

        //private void cmdCapture_Click(object sender, RoutedEventArgs e)
        //{
        //    this.AddHandler(
        //          Mouse.LostMouseCaptureEvent,
        //          new RoutedEventHandler(this.LostCapture));
        //    Mouse.Capture(rect);

        //    cmdCapture.Content = "[ Mouse is now captured ... ]";
        //}
        //private void LostCapture(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Lost capture");
        //    cmdCapture.Content = "Capture the Mouse";
        //}


        //private void pnl_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    //숫자만 나오게 
        //    //문자하나하나가 2바이트기 때문에 short 줌 
        //    short val;
        //    if (!Int16.TryParse(e.Text, out val))
        //    {
        //        e.Handled = true;
        //    }

        //    //정규 표현식 사용해서 문자만 들어가게 하기 
        //    //Regex regex = new Regex("[a-zA-Z]");
        //    //Match m = regex.Match(e.Text);
        //    //if(!m.Success)
        //    //{
        //    //    e.Handled = true;
        //    //}
        //}

        ////spacebar는 안먹기 때문에 따로 해줘야함 
        //private void pnl_PreviewKeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Space)
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void KeyEvent(object sender, KeyEventArgs e)
        //{
        //    //
        //    if ((bool)chkIgnoreRepeat.IsChecked && e.IsRepeat) return;

        //    string message = //"At: " + e.Timestamp.ToString() +
        //        "Event: " + e.RoutedEvent + " " +
        //        " Key: " + e.Key;
        //    lstMessages.Items.Add(message);
        //}

        //private new void TextInput(object sender, TextCompositionEventArgs e)
        //{
        //    string message = //"At: " + e.Timestamp.ToString() +
        //        "Event: " + e.RoutedEvent + " " +
        //        " Text: " + e.Text;
        //    lstMessages.Items.Add(message);
        //}

        //private void TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    string message =
        //      "Event: " + e.RoutedEvent;
        //    lstMessages.Items.Add(message);
        //}

        //private void cmdClear_Click(object sender, RoutedEventArgs e)
        //{
        //    lstMessages.Items.Clear();
        //}


    }

}
