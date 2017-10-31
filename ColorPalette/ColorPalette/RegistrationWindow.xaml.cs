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
using System.Windows.Shapes;

namespace ColorPalette
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {       
        List<User> currentUsers;       
        public RegistrationWindow(ref List<User> users)
        {
            InitializeComponent();
            currentUsers = users;
        }

        private void MainRegisterButton_Click(object sender, RoutedEventArgs e)
        {                    

            if (passwordPasswordBox.Password.Equals(confirmPasswordBox.Password))
            {
                Person newPerson = new Person()
                {
                    Name = nameTextBox.Text,
                    Surname = surnameTextBox.Text
                };             

                User newUser = new User()
                {
                    Person = newPerson,
                    Email = emailTextBox.Text,
                    Login = loginTextBox.Text,
                    Password = passwordPasswordBox.Password
                };

                newUser.Brush=Color.FromRgb((byte)redSlider.Value, (byte)greenSlider.Value, (byte)blueSlider.Value);

                currentUsers.Add(newUser);
                MessageBox.Show(newUser.Brush.ToString());
               Close();
 
            }
            else {
                errorLabel.Content = "Неверный пароль";
            }
        }
    }
}
