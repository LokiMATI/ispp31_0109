using LabWork46Library;
using System.Windows;

namespace LabWork46
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly IDatabase _database;
        public MainWindow()
        {
            InitializeComponent();

            _database = new SqlDatabase();
        }

        private void SQLButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResultTextBlock.Text = _database.ExecuteQuery(SQLTextBox.Text).ToString();
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = ex.Message;
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Game game = new()
                {
                    Id = int.Parse(GameIdTextBox.Text),
                    Title = TitleTextBox.Text,
                    Price = double.Parse(PriceTextBox.Text)
                };

                ResultTextBlock.Text = _database.UpdateGame(game) ? "Игра обновлена" : "Игра не обновлена.";
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = ex.Message;
            }
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _database.InsertGame(TitleTextBox.Text, double.Parse(PriceTextBox.Text), ReleaseDatePicker.SelectedDate.Value);

                ResultTextBlock.Text = $"Игра добавлена с названием: {TitleTextBox.Text}; ценой: {PriceTextBox.Text}; датой выпуска: {ReleaseDatePicker.SelectedDate.Value}";
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = ex.Message;
            }
        }
    }
}