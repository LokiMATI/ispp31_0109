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
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();

            LoginTextBox.Text = Properties.Settings.Default.Login;
            EmailTextBox.Text = Properties.Settings.Default.Email;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Login = LoginTextBox.Text;
            if (PasswordTextBox.Text.Length > 0)
            {
                Properties.Settings.Default.Password = Hash.GetHash(PasswordTextBox.Text);
            }
            Properties.Settings.Default.Email = EmailTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow window = new();
            window.Show();
        }
    }
}
