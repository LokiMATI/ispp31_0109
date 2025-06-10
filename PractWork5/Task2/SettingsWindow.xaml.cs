using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();

            LoginTextBox.Text = ConfigurationManager.AppSettings["Login"];
            PasswordTextBox.Text = ConfigurationManager.AppSettings["Password"];
            EmailTextBox.Text = ConfigurationManager.AppSettings["Email"];
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Login"].Value = LoginTextBox.Text;
            config.AppSettings.Settings["Password"].Value = PasswordTextBox.Text;
            config.AppSettings.Settings["Email"].Value = EmailTextBox.Text;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Данные сохранены");
        }
    }
}
