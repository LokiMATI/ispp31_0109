using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace Lection0421
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //var image1 = new BitmapImage(path1);
            //ellipse.Fill = new ImageBrush(image1);

            //var image2 = new BitmapImage(path2);
            //rect.Fill = new ImageBrush(image2);

            //var image3 = new BitmapImage(path3);
            //image.Source = image3;

            var cursorPath = new Uri("/images/hand.ani", UriKind.Relative);
            StreamResourceInfo stream = Application.GetResourceStream(cursorPath);
            Cursor cursor = new(stream.Stream);
            Cursor = cursor;

            //SolidColorBrush brush1 = new(Colors.AliceBlue);
            //SolidColorBrush brush2 = new(Color.FromArgb(100, 255, 100, 78));

            //Background = brush1;
            //Foreground = brush2;
        }
    }
}