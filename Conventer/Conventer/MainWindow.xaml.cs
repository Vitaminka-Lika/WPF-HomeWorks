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

namespace Conventer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            Service service = new Service();
            bool isDoneFirst, isDoneSecond,isDoneThird;
            isDoneFirst = Int32.TryParse(daysTextBox.Text, out int firstValue);
            isDoneSecond = Int32.TryParse(daysTextBox.Text, out int secondValue);
            isDoneThird = Int32.TryParse(daysTextBox.Text, out int thirdValue);
            if(isDoneFirst&&isDoneSecond&&isDoneThird)
            {
                service.Convert(Int32.Parse(daysTextBox.Text), Int32.Parse(monthsTextBox.Text), Int32.Parse(yearsTextBox.Text));
            }
        }

        private void ConvertBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (mainDatePicker.SelectedDate != null)
            {
                Service service = new Service();
                DateTime date = (DateTime)mainDatePicker.SelectedDate;
                service.ConvertBack(date);
                daysTextBox.Text = service.Days.ToString();
                monthsTextBox.Text = service.Month.ToString();
                yearsTextBox.Text = service.Years.ToString();
            }
        }
    }
}
