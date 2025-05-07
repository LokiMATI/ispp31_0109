using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LabWork32
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CategoriesListBox.Items.Add("Электроника");
            CategoriesListBox.Items.Add("Мебель");
            CategoriesListBox.Items.Add("Транспорт");
            CategoriesListBox.Items.Add("Игрушки");

            List<Product> products = [
                new Product
                {
                    Id = 0,
                    Name = "Ока(Капсула смерти)",
                    Category = "Транспорт",
                    Price = 200_000
                },
                new Product
                {
                    Id = 1,
                    Name = "Стул из ИКЕИ",
                    Category = "Мебель",
                    Price = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Револьвер",
                    Category = "Игрушки",
                    Price = 20
                },
                new Product
                {
                    Id = 3,
                    Name = "Аккумулятор",
                    Category = "Электроника",
                    Price = 2000
                },
                new Product
                {
                    Id = 0,
                    Name = "Нива",
                    Category = "Транспорт",
                    Price = 1000000
                }
                ];
            ProductsListView.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ApplyAvailabilityParametersButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder builder = new("Наличие:\n");

            foreach (CheckBox item in AvailabilityParametersListBox.Items)
                if (item.IsChecked.Value)
                    builder.AppendLine(item.Content.ToString());

            AvailabilityParametersTextBlock.Text = builder.ToString();
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            var product = (e.Source as Button).DataContext as Product;
            ConsumerBasketListBox.Items.Add(product);
        }

        private void DeleteProductButton_Click(object sender, RoutedEventArgs e)
        {
            Product[] products = new Product[ConsumerBasketListBox.SelectedItems.Count];
            ConsumerBasketListBox.SelectedItems.CopyTo(products, 0);
            foreach (var item in products)
                ConsumerBasketListBox.Items.Remove(item);
        }
    }
}