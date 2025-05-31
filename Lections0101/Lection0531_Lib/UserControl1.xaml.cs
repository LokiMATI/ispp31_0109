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

namespace Lection0531_Lib
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Entry : UserControl
    {
        public string Hint { get; set; }



        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxLength.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxLengthProperty =
            DependencyProperty.Register("MaxLength", typeof(int), typeof(Entry), new PropertyMetadata(0));



        public event RoutedEventHandler Edited;
        public event RoutedEventHandler Deleted;
        public Entry()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Deleted?.Invoke(sender, e);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Edited?.Invoke(sender, e);
        }
    }

}
