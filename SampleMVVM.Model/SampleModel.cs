using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVVM.Model
{
    public class SampleModel
    {
        //model에 클래스 만들면 internal인데 viewModel에서 접근하기 위해 public을 써줘야 한다.
        public double CalculateSquareRoot(double number)
        {
            return Math.Sqrt(number);
        }
    }
}
