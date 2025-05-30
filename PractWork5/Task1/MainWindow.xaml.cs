using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AuthorizationMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow window = new();
            window.Show();
            Close();
        }

        private void ChangeTheme_Click(object sender, RoutedEventArgs e)
        {
            string json = File.ReadAllText("config.json");
            var settings = JsonSerializer.Deserialize<Setting>(json);
            
        }
    }
}