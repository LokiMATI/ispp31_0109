using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace UserElements
{
    /// <summary>
    /// Логика взаимодействия для TimeLabel.xaml
    /// </summary>
    public partial class TimeLabel : UserControl
    {
        private DispatcherTimer _timer;
        public TimeLabel()
        {
            InitializeComponent();
            _timer = new(DispatcherPriority.Render);
            _timer.Tick += Timer_Tick;
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Label.Content = DateTime.Now.ToLongTimeString();
        }
    }
}
