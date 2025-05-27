using System.Windows;

namespace PractWork4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Game> Games { get; set; }
        public Game SelectedGame {  get; set; }
        public List<Category> Categories { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Games = new()
            {
                new Game{IdGame = 1, Name = "Tetris", Category = "головоломка", Price = 150},
                new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
                new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Category = "аркада", Price = 300},
                new Game{IdGame = 4, Name = "Arkanoid", Category = "аркада", Price = 400},
                new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Category = "платформер", Price = 1000},
                new Game{IdGame = 6, Name = "Tetris2", Price = 150},
                new Game{IdGame = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
                new Game{IdGame = 8, Name = "Pac-man2", Description = "игра про колобка", Price = 300},
                new Game{IdGame = 9, Name = "Arkanoid2", Category = "аркада", Price = 400},
                new Game{IdGame = 10, Name = "Mario2", Description = "игра про Марио", Price = 1000},
            };

            Categories = new()
            {
                new Category{Name = "головоломка", Description = "описание жанра головоломка"},
                new Category{Name = "платформер", Description = "описание жанра платформер"},
                new Category{Name = "RPG", Description = "описание жанра RPG"},
                new Category{Name = "аркада", Description = "описание жанра аркада"}
            };

            GamesListView.DataContext = this;
            CategoriesListView.DataContext = this;

        }

        private void GamesListView_Selected(object sender, RoutedEventArgs e)
        {
            SelectedGame = (Game)sender;
        }
    }
}