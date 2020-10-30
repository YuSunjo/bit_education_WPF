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

namespace class3
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //CommandBinding binding;
            //binding = new CommandBinding(ApplicationCommands.New);
            //binding.Executed += NewCommand;
            //this.CommandBindings.Add(binding);

            //binding = new CommandBinding(ApplicationCommands.Open);
            //binding.Executed += OpenCommand;
            //this.CommandBindings.Add(binding);

            //binding = new CommandBinding(ApplicationCommands.Save);
            //binding.Executed += SaveCommand_Executed;
            //binding.CanExecute += SaveCommand_CanExecute;
            //this.CommandBindings.Add(binding);
        }

        //private void txt_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    isDirty = true;
        //}
        //private void NewCommand(object sender, ExecutedRoutedEventArgs e)
        //{
        //    MessageBox.Show("New command triggered with " + e.Source.ToString());
        //    isDirty = false;
        //}

        //private void OpenCommand(object sender, ExecutedRoutedEventArgs e)
        //{
        //    isDirty = false;
        //}

        //private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    MessageBox.Show("Save command triggered with " + e.Source.ToString());
        //    isDirty = false;
        //}

        //private bool isDirty = false;
        //private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        //{
        //    e.CanExecute = isDirty;
        //}

        //private void cmd_ShowProperty(object sender, RoutedEventArgs e)
        //{
        //    //object 형식으로 나와서 형변환 해줘야함 
        //    MyClass m = (MyClass)this.Resources["myclass"];
        //    MessageBox.Show("" + m.Size);
        //}

        //private void cmd_SetSmall(object sender, RoutedEventArgs e)
        //{
        //    sliderFontSize.Value = 2;
        //}

        //private void cmd_SetNormal(object sender, RoutedEventArgs e)
        //{
        //    sliderFontSize.Value = this.FontSize;
        //}

        //private void cmd_SetLarge(object sender, RoutedEventArgs e)
        //{
        //    lblSampleText.FontSize = 30;
        //}
    }
}
