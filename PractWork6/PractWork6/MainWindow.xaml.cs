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

namespace PractWork6
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)e.Source;
            Title = (string)radioButton.Content;
        }

        private void Counter_ValueChanged(object sender, RoutedEventArgs e)
        {
            int price = int.Parse((string)PriceLabel.Content);
            TotalCostLabel.Content = $"Итоговая стоимость: {Counter.Value * price}";
        }
    }
}