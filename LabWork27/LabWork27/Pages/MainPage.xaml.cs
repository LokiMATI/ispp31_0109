using System.Windows;
using System.Windows.Controls;

namespace LabWork27.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            switch (button.Content)
            {
                case "Авторизация":
                    App.MainFrame.Navigate(new AuthorizationPage());
                    break;
                case "Регистрация":
                    App.MainFrame.Navigate(new RegistrationPage());
                    break;
                case "Настройки":
                    App.MainFrame.Navigate(new SettingsPage());
                    break;
            }
        }
    }
}
