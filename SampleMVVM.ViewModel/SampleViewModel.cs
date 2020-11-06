using SampleMVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleMVVM.ViewModel
{
    public class SampleViewModel : INotifyPropertyChanged
    {
        private SampleModel _model;
        private double _result;
        public event PropertyChangedEventHandler PropertyChanged;
        private RelayCommand _calculateSquareRootCommand;

        public SampleViewModel()
        {
            _model = new SampleModel();
        }
        public double Result
        {
            get { return _result; }
            private set
            {
                if(_result != value)
                {
                    _result = value;
                    //if(PropertyChanged != null) PropertyChanged(this, new PropertyChanged("Result");
                    //Result 값이 바뀌었다고 얘기해주는것 --dependency property인가? 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));
                }
            }
        }

        public ICommand CalculateSquareRootCommand
        {
            get
            {
                if(_calculateSquareRootCommand ==null)
                {
                    // 커맨드에 어떤 코드를 실행할지 써준다. 
                    _calculateSquareRootCommand = new RelayCommand(param => this.CalculateSquareRoot());
                }
                return _calculateSquareRootCommand;
            }
        }
        public double Number
        {
            get;set;
        }
        private void CalculateSquareRoot()
        {
            Result = _model.CalculateSquareRoot(Number);
        }



    }
}
