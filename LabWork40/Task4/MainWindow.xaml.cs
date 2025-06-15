using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] _tags = ["enemy", "hero", "treasure"];
        public MainWindow()
        {
            InitializeComponent();

            Canvas.Width = Width;
            Canvas.Height = Height;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.Source is Canvas)
            {
                Ellipse circle = new();

                circle.Width = circle.Height = Random.Shared.Next(10, 50);
                circle.Fill = new SolidColorBrush(Color.FromRgb((byte)Random.Shared.Next(0, 256),
                    (byte)Random.Shared.Next(0, 256),
                    (byte)Random.Shared.Next(0, 256)));

                circle.Tag = _tags[Random.Shared.Next(_tags.Length)];

                Canvas.Children.Add(circle);

                Canvas.SetTop(circle, Random.Shared.Next((int)(Canvas.Height - circle.Height)));
                Canvas.SetLeft(circle, Random.Shared.Next((int)(Canvas.Width - circle.Width)));
            }
            else if (e.Source is Ellipse ellipse)
            {
                MessageBox.Show(ellipse.Tag.ToString(), "Вы нажали на круг!");
            }
        }
    }
}