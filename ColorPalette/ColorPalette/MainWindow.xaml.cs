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

namespace ColorPalette
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {      

        List<User> users = new List<User>();      
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow(ref users);
            registrationWindow.ShowDialog();
        }

        private void LoginInButton_Click(object sender, RoutedEventArgs e)
        {
            User checkingUser = new User()
            {
                Login=loginTextBox.Text,
                Password=passwordPasswordBox.Password
            };

            bool isDone = true;

            foreach(User user in users)
            {
                if (user.Login.Equals(checkingUser.Login))
                {
                    if (user.Password.Equals(checkingUser.Password))
                    {
                        isDone = false;
                        errorLabel.Content = "";                       
                        registerButton.IsEnabled = false;
                        loginInButton.IsEnabled = false;                                         
                        loginOutButton.IsEnabled = true;
                        Background = new SolidColorBrush(user.Brush);
                    }
                }
            }
            if (isDone)
            {
                errorLabel.Content = "Ошибка ввода";
            }
        }

        private void LoginOutButton_Click(object sender, RoutedEventArgs e)
        {
            loginTextBox.Text = "";
            passwordPasswordBox.Password=null;
            registerButton.IsEnabled = true;
            loginInButton.IsEnabled = true;
            loginOutButton.IsEnabled = false;
            Background = new SolidColorBrush(Colors.White);
        }
    }
}
