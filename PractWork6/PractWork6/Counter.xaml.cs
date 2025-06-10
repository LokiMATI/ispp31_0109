using System.Windows;
using System.Windows.Controls;

namespace PractWork6
{
    /// <summary>
    /// Логика взаимодействия для Counter.xaml
    /// </summary>
    public partial class Counter : UserControl
    {
        public int MaxValue { get; set; } = int.MaxValue;

        public event RoutedEventHandler ValueChanged;

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(Counter), new PropertyMetadata(0));

        public Counter()
        {
            InitializeComponent();
            Value = 0;

            DataContext = this;
        }

        private void ReduceButton_Click(object sender, RoutedEventArgs e)
        {
            Value -= 1;

            if (Value == 0)
                ReduceButton.IsEnabled = false;

            ValueChanged?.Invoke(sender, e);
        }

        private void IncreaseButton_Click(object sender, RoutedEventArgs e)
        {
            Value += 1;

            if (Value == MaxValue)
                IncreaseButton.IsEnabled = false;

            ValueChanged?.Invoke(sender, e);
        }
    }
}
