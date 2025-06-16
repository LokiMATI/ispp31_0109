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

namespace Task5
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

        private void ChangeColorButton_Click(object sender, RoutedEventArgs e)
        {
            ColorAnimationUsingKeyFrames animation = new();
            animation.Duration = TimeSpan.FromSeconds(5);

            animation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Orange, KeyTime.FromPercent(0.2)));
            animation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Blue, KeyTime.FromPercent(0.4)));
            animation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Green, KeyTime.FromPercent(0.6)));
            animation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromPercent(0.8)));
            animation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Purple, KeyTime.FromPercent(1)));

            RadialGradientBrush.GradientStops[1].BeginAnimation(GradientStop.ColorProperty, animation);
        }
    }
}