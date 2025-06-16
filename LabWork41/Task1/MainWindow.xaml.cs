using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
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

        private void OpenMenuButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new();
            animation.From = Menu.Width;
            animation.To = Menu.Width > 0 ? 0 : 80;
            animation.Duration = TimeSpan.FromSeconds(1);
            Menu.BeginAnimation(Menu.WidthProperty, animation);
        }
    }
}