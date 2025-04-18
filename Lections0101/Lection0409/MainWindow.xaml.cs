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
using Lection0409.Pages;

namespace Lection0409
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App.CurrentFrame = ContentFrame;
        }

        private void OpenPage1Button_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new Page1());
        }

        private void OpenPage2Button_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new Page2());
        }

        private void OpenPage3Button_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new Page3());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CurrentFrame.CanGoBack)
                App.CurrentFrame.GoBack();
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (App.CurrentFrame.CanGoForward)
                App.CurrentFrame.GoForward();
        }

        private void ContentFrame_ContentRendered(object sender, EventArgs e)
        {
            //BackButton.IsEnabled = App.CurrentFrame.CanGoBack;
            //ForwardButton.IsEnabled = App.CurrentFrame.CanGoForward;

            if (App.CurrentFrame.CanGoBack)
                BackButton.Visibility = Visibility.Visible;
            else 
                BackButton.Visibility = Visibility.Hidden;

            ForwardButton.Visibility = App.CurrentFrame.CanGoForward ? Visibility.Visible : Visibility.Hidden;
        }
    }
}