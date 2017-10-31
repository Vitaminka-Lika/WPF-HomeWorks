using Microsoft.Win32;
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
using System.Windows.Threading;

namespace MultiMedia
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer mainDispatcherTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            mainMediaElement.Source = new Uri(openFileDialog.FileName);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            mainMediaElement.Play();
            mainDispatcherTimer.Start();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            mainMediaElement.Pause();
            mainDispatcherTimer.Stop();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            mainMediaElement.Stop();
            mainDispatcherTimer.Stop();
        }
    }
}
