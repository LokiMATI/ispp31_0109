using Microsoft.Win32;
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
using System.Windows.Threading;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _currentImage = 0;
        OpenFileDialog _dialog = new();
        public MainWindow()
        {
            InitializeComponent();

            _dialog.Multiselect = true;
            _dialog.Filter = "Изображения|*.jpg;*.png;*.gif";
        }

        private void LoadImagesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (_dialog.ShowDialog() == true)
            {
                DispatcherTimer timer = new();
                timer.Interval = TimeSpan.FromSeconds(0.3);
                timer.Tick += Timer_Tick;
                timer.Start();
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (_currentImage == _dialog.FileNames.Length)
                _currentImage = 0;

            Image.Source = new BitmapImage(new Uri(_dialog.FileNames[_currentImage++]));
        }
    }
}