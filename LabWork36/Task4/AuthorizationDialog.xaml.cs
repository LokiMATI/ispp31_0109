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

namespace Task4
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationDialog.xaml
    /// </summary>
    public partial class AuthorizationDialog : Window
    {
        public AuthorizationDialog()
        {
            InitializeComponent();
        }
        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == "admin" && PasswordTextBox.Text == "qwerty")
            {
                AdministratorWindow window = new();
                Hide();
                window.ShowDialog();
                Show();
            }
            else if (LoginTextBox.Text == "manager" && PasswordTextBox.Text == "12345")
            {
                ManagerWindow window = new();
                Hide();
                window.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Неверные данные", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow window = new();
            window.Show();
        }
    }
}
