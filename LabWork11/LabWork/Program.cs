// Задание 1
List<string> flowers = ["Мак", "Роза", "Ромашка"];

Console.Write("Введите количество новых элементов: ");
int count = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значения для новых элементов:");
for (int i = 0; i < count; i++)
    flowers.Add(Console.ReadLine());

for (int i = 0; i < flowers.Count; i++)
    Console.WriteLine($"{i + 1}: {flowers[i]}");

// Задание 4
Console.Write("\nВведите значение элемента: ");
string deleteValue = Console.ReadLine();

flowers.RemoveAll(f => f.ToLower() == deleteValue.ToLower());

foreach (var flower in flowers)
    Console.WriteLine(flower);