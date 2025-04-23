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

namespace Task3
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

        private void FontSizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = e.OriginalSource as RadioButton;

            int fontSize = int.Parse(radioButton.Content.ToString());

            TextBox.FontSize = fontSize;
        }

        private void LeftTextAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Left;
        }

        private void CenterTextAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Center;
        }

        private void RightTextAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.TextAlignment = TextAlignment.Right;
        }
    }
}