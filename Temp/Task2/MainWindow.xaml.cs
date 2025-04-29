using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users =
                [
                    new User 
                    {
                        Address = "Test@test.com",
                        Login = "Test",
                        Password = "Test",
                        Category = "email",
                        IsArchived = true
                    },
                    new User
                    {
                        Address = "Test.com",
                        Login = "UserTest",
                        Password = "TestUser",
                        Category = "сайт",
                        IsArchived = false
                    },
                    new User
                    {
                        Address = "TestBase",
                        Login = "Admin",
                        Password = "Admin",
                        Category = "БД",
                        IsArchived = false
                    },
                    new User
                    {
                        Address = "Test213231@test.com",
                        Login = "Test",
                        Password = "Test",
                        Category = "email",
                        IsArchived = true
                    },
                    new User
                    {
                        Address = "Test.ru",
                        Login = "Test",
                        Password = "Test",
                        Category = "сайт",
                        IsArchived = true
                    },
                ];

            List<string> categories = ["email", "сайт", "БД"];

            CategoryDGComboBoxColumn.ItemsSource = categories;

            UsersDataGrid.ItemsSource = users;
        }

        private void CopyPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            var user = (sender as Button).DataContext as User;
            if (user is null) 
                return;

            Clipboard.SetDataObject(user.Password);
        }
    }
}