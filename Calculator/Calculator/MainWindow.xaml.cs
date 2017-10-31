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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long? firstNumber;
        long? secondNumber;
        bool isDone;
        int operationIndex;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "1";
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "2";
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "3";
        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "4";
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "5";
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "6";
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "7";
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "8";
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "9";
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text += "0";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBox.Text = "";
            equalButton.IsEnabled = false;
            firstNumber = null;
            secondNumber = null;
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Int32.Parse(mainTextBox.Text);
            operationIndex = 0;
            mainTextBox.Text = "";
            isDone = true;
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Int32.Parse(mainTextBox.Text);
            operationIndex = 1;
            mainTextBox.Text = "";
            isDone = true;
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Int32.Parse(mainTextBox.Text);
            operationIndex = 2;
            mainTextBox.Text = "";
            isDone = true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Int32.Parse(mainTextBox.Text);
            operationIndex = 3;
            mainTextBox.Text = "";
            isDone = true;
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            switch (operationIndex)
            {
                case 0:
                    {
                        secondNumber = Int32.Parse(mainTextBox.Text);
                        mainTextBox.Text = (firstNumber * secondNumber).ToString();
                        firstNumber = null;
                        secondNumber = null;
                        break;
                    }                   
                case 1:
                    {
                        secondNumber = Int32.Parse(mainTextBox.Text);
                        if (secondNumber != 0)
                        {
                            mainTextBox.Text = (firstNumber / secondNumber).ToString();
                            firstNumber = null;
                            secondNumber = null;
                            break;
                        }
                        else
                        {
                            mainTextBox.Text="Error!";
                            firstNumber = null;
                            secondNumber = null;
                            break;
                        }
                    }                  
                case 2:
                    {
                        secondNumber = Int32.Parse(mainTextBox.Text);
                        mainTextBox.Text = (firstNumber - secondNumber).ToString();
                        firstNumber = null;
                        secondNumber = null;
                        break;
                    }                 
                case 3:
                    {
                        secondNumber = Int32.Parse(mainTextBox.Text);
                        mainTextBox.Text = (firstNumber + secondNumber).ToString();
                        firstNumber = null;
                        secondNumber = null;
                        break;
                    }
            }
            isDone = false;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (mainTextBox.Text == "")
            {
                addButton.IsEnabled = false;
                divideButton.IsEnabled = false;
                multiplyButton.IsEnabled = false;
                subtractButton.IsEnabled = false;
                equalButton.IsEnabled = false;
            }
            else {
                addButton.IsEnabled = true;
                divideButton.IsEnabled = true;
                multiplyButton.IsEnabled = true;
                subtractButton.IsEnabled = true;
            }
            if (isDone)
            {
                equalButton.IsEnabled = true;
            }
            else
            {
                equalButton.IsEnabled = false;
            }
        }
    }
}
