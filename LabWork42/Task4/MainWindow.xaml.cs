using Microsoft.Win32;
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
using System.Windows.Threading;

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer = new();

        public MainWindow()
        {
            InitializeComponent();

            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            CurrentTimelineLabel.Content = String.Format("{0} / {1}", MediaElement.Position.ToString(@"hh\:mm\:ss"), MediaElement.NaturalDuration.TimeSpan.ToString(@"hh\:mm\:ss"));
        }

        private void LoadFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new();
            if (dialog.ShowDialog() == true)
            {
                MediaElement.Source = new Uri(dialog.FileName);
            }
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Pause();
            _timer.Stop();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Play();
            _timer.Start();

        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Stop();
            _timer.Stop();
        }
    }
}