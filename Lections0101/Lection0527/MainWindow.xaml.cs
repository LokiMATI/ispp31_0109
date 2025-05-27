using System.Windows;

namespace Lection0527
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Cat MyCat { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Cat cat = new()
            {
                Id = 1,
                Name = "Barsik",
                Age = 7
            };
            MyCat = new()
            {
                Id = 2,
                Name = "Murzik",
                Age = 5
            };
            DataContext = this;

            NameTextBox.DataContext = cat.Name;
            DateTime date = DateTime.Now;
            //YearTextBox.DataContext = date;
        }
    }
}