using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(PasswordBox.Password);
            byte[] hashedBytes = SHA256.Create().ComputeHash(inputBytes);
            string hash = Convert.ToHexString(hashedBytes);

            if (Properties.Settings.Default.Login != LoginTextBox.Text ||
                Properties.Settings.Default.Password != hash)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            SettingsWindow window = new();
            window.Show();
            Close();
        }
    }
}
