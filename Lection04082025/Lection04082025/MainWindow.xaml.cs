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
using Lection04082025.Pages;

namespace Lection04082025
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App.MainFrame = ContentFrame;
            App.MainFrame.Navigate(new StartPage());
        }

        private void Page1Button_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Page1());
        }
        private void Page2Button_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Page2());
        }
        private void Page3Button_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new Page3());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.MainFrame.CanGoBack)
                App.MainFrame.GoBack();
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.MainFrame.CanGoForward)
                App.MainFrame.GoForward();
        }

        private void ContentFrame_ContentRendered(object sender, EventArgs e)
        {
            BackButton.IsEnabled = App.MainFrame.CanGoBack;
            ForwardButton.IsEnabled = App.MainFrame.CanGoForward;
            //if (App.MainFrame.CanGoBack)
            //    BackButton.Visibility = Visibility.Visible;
            //else
            //    BackButton.Visibility = Visibility.Collapsed;

            //ForwardButton.Visibility = App.MainFrame.CanGoForward ? 
            //    Visibility.Visible : Visibility.Collapsed;
        }
    }
}