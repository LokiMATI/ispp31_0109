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

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int _deadline = 400;
        const int _speed = 3;
        const int _widthEnemy = 30;
        const int _heightEnemy = 30;
        DispatcherTimer timer = new(DispatcherPriority.Render);
        DispatcherTimer timerMove = new(DispatcherPriority.Render);

        int score = 0;
        Label ScoreLabel = new();

        public MainWindow()
        {
            InitializeComponent();

            StartTimer(timer, 500, Timer_Tick);
            StartTimer(timerMove, 50, TimerMove_Tick);

            GameCanvas.Children.Add(ScoreLabel);
            ScoreLabel.Foreground = new SolidColorBrush(Colors.White);
            ScoreLabel.Content = 0;
        }

        private void StartTimer(DispatcherTimer timer, int interval, EventHandler handler)
        {
            timer.Interval = TimeSpan.FromMilliseconds(interval);
            timer.Start();
            timer.Tick += handler;
        }

        private void TimerMove_Tick(object? sender, EventArgs e)
        {
            foreach (Shape item in GameCanvas.Children.OfType<Shape>())
            {
                double y = (double)item.GetValue(Canvas.TopProperty);
                Canvas.SetTop(item, y + _speed);
                if (y >= _deadline)
                {
                    timerMove.Stop();
                    MessageBox.Show("End");
                    break;
                }
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            SpawnEnemy();
        }

        private void SpawnEnemy()
        {
            Ellipse enemy = new()
            {
                Width = _widthEnemy,
                Height = _heightEnemy,
                Fill = new SolidColorBrush(Colors.Purple)
            };
            GameCanvas.Children.Add(enemy);

            double x = new Random().NextDouble() * Width;
            Canvas.SetLeft(enemy, x);
            Canvas.SetTop(enemy, -enemy.Height);

            enemy.MouseDown += Enemy_MouseDown;
        }

        private void Enemy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GameCanvas.Children.Remove(sender as UIElement);

            ScoreLabel.Content = ++score;
        }
    }
}