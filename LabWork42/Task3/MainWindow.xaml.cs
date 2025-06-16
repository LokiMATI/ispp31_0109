using System.Media;
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
        private MediaPlayer _soundPlayer = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FirstSoundButton_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void SecondSoundButton_Click(object sender, RoutedEventArgs e)
        {
            _soundPlayer.Open(new Uri(@"C:\Users\0109-13\Downloads\legend.mp3"));
            _soundPlayer.Play();
        }

        private void ThirdSoundButton_Click(object sender, RoutedEventArgs e)
        {
            _soundPlayer.Open(new Uri(@"C:\Users\0109-13\Downloads\music.mp3"));
            _soundPlayer.Play();
        }
    }
}