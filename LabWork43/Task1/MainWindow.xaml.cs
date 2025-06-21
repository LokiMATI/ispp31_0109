using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new(DispatcherPriority.Render);
        int pechenie = 0;
        int babushki = 0;
        int cena = 15;

        public MainWindow()
        {
            InitializeComponent();

            timer.Tick += new(timer_Tick);
            timer.Interval = new(0, 0, 0, 0, 1000);
            timer.Start();

            CheckBabushkaRectangleIsEnabled();
        }

        private void CheckBabushkaRectangleIsEnabled()
        {
            BabushkiRectangle.IsEnabled = (pechenie >= cena);
            BabushkiRectangle.Opacity = (pechenie >= cena) ? 1 : 0.5;
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            IncreaseCookies();
            CheckBabushkaRectangleIsEnabled();
        }

        private void PechenieEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IncreaseCookies();
            CheckBabushkaRectangleIsEnabled();
        }

        private void IncreaseCookies()
        {
            PechenieLabel.Content = ++pechenie;
        }

        private void BabushkiRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pechenie -= cena;
            PechenieLabel.Content = pechenie;
            CheckBabushkaRectangleIsEnabled();

            BabushkiLabel.Content = ++babushki;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / (babushki + 1));
            timer.Start();
        }
    }
}