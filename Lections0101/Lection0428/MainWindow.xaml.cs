using System.IO;
using System.Windows;

namespace Lection0428
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //FilesDataGrid.ItemsSource = new DirectoryInfo(@"Y:\МДК.01.01").GetFiles();

            List<Breed> breeds =
            [
                new Breed { BreedId = 1, BreedName = "Персидская" },
                new Breed { BreedId = 2, BreedName = "Сиамская" },
                new Breed { BreedId = 3, BreedName = "Британская короткошерстная" },
                new Breed { BreedId = 4, BreedName = "Мейн-кун" },
                new Breed { BreedId = 5, BreedName = "Рэгдолл" },
                new Breed { BreedId = 6, BreedName = "Сфинкс" },
            ];

            List<string> colors =
            [
                "Белый",
                "Сил-пойнт",
                "Серый",
                "Рыжий",
                "Трехцветный",
                "Черный",
            ];

            List<Cat> cats =
            [
                new Cat { Id = 1, Name = "Усатик", Breed = "Персидская", Color = "Белый", Age = 5 },
                new Cat { Id = 2, Name = "Варежка", Breed = "Сиамская", Color = "Сил-пойнт", Age = 3 },
                new Cat { Id = 3, Name = "Дымок", Breed = "Британская короткошерстная", Color = "Серый", Age = 7 },
                new Cat { Id = 4, Name = "Белла", Breed = "Мейн-кун", Color = "Рыжий", Age = 4 },
                new Cat { Id = 5, Name = "Макс", Breed = "Рэгдолл", Color = "Сил-миттед", Age = 2 },
                new Cat { Id = 6, Name = "Луна", Breed = "Персидская", Color = "Трехцветный", Age = 6 },
                new Cat { Id = 7, Name = "Оливер", Breed = "Британская короткошерстная", Color = "Черный", Age = 8 },
                new Cat { Id = 8, Name = "Клео", Breed = "Сиамская", Color = "Коричневый", Age = 3 },
                new Cat { Id = 9, Name = "Симба", Breed = "Мейн-кун", Color = "Рыжий", Age = 5 },
                new Cat { Id = 10, Name = "Ромашка", Breed = "Персидская", Color = "Белый", Age = 2 }
            ];

            CatsDataGrid.ItemsSource = cats;
            ColorsColumn.ItemsSource = colors;
        }
    }
}