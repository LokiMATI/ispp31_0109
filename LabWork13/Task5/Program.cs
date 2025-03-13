// Задание 5
Console.WriteLine("Задание 5");
string[] strings = ["Проспект Дурова", "Проект Москвы", "Дубовый Проём", "проект", "Абрикос"];
Console.WriteLine("Элементы массива: ");
foreach (var stringItem in strings)
    Console.WriteLine(stringItem);
Console.Write("Введите подстроку: ");
string substring = Console.ReadLine();
List<string> containSubstring = new();

foreach (var stringItem in strings)
    if (stringItem.Contains(substring))
        containSubstring.Add(stringItem);

if (containSubstring.Count > 0)
    foreach (var stringItem in containSubstring)
        Console.WriteLine(stringItem);
else
    Console.WriteLine("Строки содержащие данную подстроку отсутствуют в массиве.");
