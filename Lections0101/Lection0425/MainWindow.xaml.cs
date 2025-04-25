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

namespace Lection0425
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //UsersListBox.Items.Add("Admin");
            //UsersListBox.Items.Add("User");

            var files = new DirectoryInfo(@"Y:\МДК.01.01").GetFiles();
            FilesListBox.ItemsSource = files;
        }
    }
}