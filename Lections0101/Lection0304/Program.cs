using System.Threading.Tasks.Sources;

Console.WriteLine("LINQ-запросы");

var numbers = Enumerable.Range(1, 5).ToList();

List<string> users = ["admin", "user1", "user2"];

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

var cats1 = cats.Select(cat => cat.Name).ToList;
var cats2 = cats.Select(cat => new { cat.Name, cat.Age }).ToList();
var cats3 = cats.Select(cat => new CatDto { Name = cat.Name, Breed = cat.Breed }).ToList;

var numbers1 = numbers.Where(n => n % 2 == 0);
var user1 = users.Where(user => user.StartsWith("user")).ToList();

var cats4 = cats.Where(c => c.Breed == "Сиамская" && c.Age < 5).ToList();

var cats0 = cats.OrderBy(c => c.Name).ToList();
var cats12 = cats.OrderByDescending(c => c.Name).ToList();
var cats15 = cats
    .OrderBy(c => c.Breed)
    .ThenByDescending(c => c.Age)
    .ThenBy(c => c.Name)
    .ToList();


Console.WriteLine();

int rowsCount = 3; // pageSize / elementsCount
int currentPage = 1;

var cats13 = cats
    .Skip((currentPage - 1) * rowsCount)
    .Take(rowsCount);

int lastPage = (int)Math.Ceiling(1.0 * currentPage / rowsCount);

var persCount = cats.Count(c => c.Breed == "Персидская");
var catsCount = cats.Count();

var maxAge = cats.Max(c => c.Age);
var ageSum = cats.Sum(c => c.Age);

var multResult = numbers.Aggregate((x, y) => x *  y);

var catsGroupByColor = cats.GroupBy(c => c.Color)
    .Select(group => new { Color = group.Key, Count = group.Count() })
    .ToList();

var catsGroupByColorBreed = cats.GroupBy(c => new { c.Color, c.Breed })
    .Select(group => new { group.Key.Color, group.Key.Breed, AveAge = group.Average(c => c.Age) })
    .ToList();

cats.Select(c => c.Breed).Distinct();

Console.WriteLine();