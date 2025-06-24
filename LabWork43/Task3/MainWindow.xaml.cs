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
        const int _racketSpeed = 10;
        public MainWindow()
        {
            InitializeComponent();

            RacketRectangle.TranslatePoint(new Point(Canvas.Width / 2 - RacketRectangle.Width / 2, Canvas.Width - 10), null);
        }

        private void RacketRectangle_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    Rect
                    var point = RacketRectangle.TranslatePoint(new Point(), null);
                    if (point.X < Left + _racketSpeed)
                    {
                        RacketRectangle.TranslatePoint(new(Left + RacketRectangle.Width / 2, point.Y), null);
                    }
                    else
                    {
                        RacketRectangle.TranslatePoint(new(point.X - _racketSpeed, Canvas.Width - 10), null);
                    }
                    break;
            }
        }
    }
}