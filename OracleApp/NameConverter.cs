using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace OracleApp
{
    //stringFormat을 할 수 없는 복잡한 연산을 위해서 만듦  
    class NameConverter : IMultiValueConverter
    {
        //value가 배열로 들어옴 
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string val = string.Format("{0} {1}", values[0], values[1]);
            return val;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
