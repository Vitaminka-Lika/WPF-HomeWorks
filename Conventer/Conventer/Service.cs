using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conventer
{
    public class Service : IMultiValueConverter
    {
        public int? Days { get; set; }
        public int? Month { get; set; }
        public int? Years { get; set; }

        public DateTime Convert(int day, int month, int year)
        {
            DateTime date = new DateTime(year,month,day);          
            return date;
        }

        public void ConvertBack(DateTime date)
        {
            Days = date.Day;
            Month = date.Month;
            Years = date.Year;
        }
    }
}
