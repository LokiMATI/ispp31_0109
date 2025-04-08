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
using System.Xml.Serialization;

namespace LabWork26
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

        private void TaskButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            switch (button.Name)
            {
                case "Task1Button":
                    OpenWindow(new Window1());
                    break;
                case "Task2Button":
                    OpenWindow(new Window2());
                    break;
                case "Task3Button":
                    OpenWindow(new Window3());
                    break;
                case "Task4Button":
                    OpenWindow(new Window4());
                    break;
                case "Task5Button":
                    OpenWindow(new Window5());
                    break;
            }
        }

        private void OpenWindow(Window window)
        {
            window.Show();
        }
    }
}