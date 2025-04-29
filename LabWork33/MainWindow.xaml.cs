
using System.IO;
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

namespace LabWork33
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var files = new DirectoryInfo(@"Y:\МДК.01.01").GetFiles();
            FilesListView.ItemsSource = files;
        }

        private void MoreDetailedButton_Click(object sender, RoutedEventArgs e)
        {
            var file = (sender as Button).DataContext as FileInfo;
            MessageBox.Show(file.FullName);
        }
    }
}