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

namespace TextEditor
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

        private void CutButton_Click(object sender, RoutedEventArgs e)
        {
          mainRichTextBox.Cut();
        } 

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            mainRichTextBox.Copy();
        }

        private void PasteButton_Click(object sender, RoutedEventArgs e)
        {
            mainRichTextBox.Paste();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (mainRichTextBox.Selection.Text == "")
            {
                cutButton.IsEnabled = false;
                copyButton.IsEnabled = false;
            }
            else
            {
                cutButton.IsEnabled = true;
                copyButton.IsEnabled = true;
            }
        }
    }
}
