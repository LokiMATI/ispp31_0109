using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();

            var settings = File.ReadAllLines("userData.txt");

            LoginTextBox.Text = settings[0];
            PasswordTextBox.Text = settings[1];
            EmailTextBox.Text = settings[2];
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new();
            sb.AppendLine(LoginTextBox.Text);
            sb.AppendLine(PasswordTextBox.Text);
            sb.AppendLine(EmailTextBox.Text);
            File.WriteAllText("userData.txt", sb.ToString());
            MessageBox.Show("Данные сохранены");
        }
    }
}
