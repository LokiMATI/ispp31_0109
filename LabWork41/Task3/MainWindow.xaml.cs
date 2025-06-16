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

            DoubleAnimation widthButtonAnimation = new();
            widthButtonAnimation.To = Button.Width * 2;
            widthButtonAnimation.Duration = TimeSpan.FromSeconds(1);
            widthButtonAnimation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(4));
            widthButtonAnimation.AutoReverse = true;

            DoubleAnimation heightButtonAnimation = new();
            heightButtonAnimation.To = Button.Height * 2;
            heightButtonAnimation.Duration = TimeSpan.FromSeconds(1);
            heightButtonAnimation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(4));
            heightButtonAnimation.AutoReverse = true;

            DoubleAnimation fontSizeButtonAnimation = new();
            fontSizeButtonAnimation.To = Button.FontSize * 2;
            fontSizeButtonAnimation.Duration = TimeSpan.FromSeconds(1);
            fontSizeButtonAnimation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(4));
            fontSizeButtonAnimation.AutoReverse = true;

            Button.BeginAnimation(Button.WidthProperty, widthButtonAnimation);
            Button.BeginAnimation(Button.HeightProperty, heightButtonAnimation);
            Button.BeginAnimation(Button.FontSizeProperty, fontSizeButtonAnimation);
        }
    }
}