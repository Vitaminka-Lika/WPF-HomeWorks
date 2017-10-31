using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conventer
{
    public interface IMultiValueConverter
    {
        DateTime Convert(int day, int month, int year);
        void ConvertBack(DateTime date);
    }
}
