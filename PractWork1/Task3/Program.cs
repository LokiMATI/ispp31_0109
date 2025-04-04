Console.Write("Введите имя файла: ");
var fileName = Console.ReadLine();

if (!File.Exists(fileName))
{
    Console.WriteLine("Файла с данным именем нет.");
    return;
}

Console.Write("Введите искомый текст: ");
var searchText = Console.ReadLine();

var text = File.ReadAllLines(fileName);

for (int i = 0; i < text.Length; i++)
    if (text[i].Contains(searchText, StringComparison.OrdinalIgnoreCase))
        Console.WriteLine($"{i + 1}: {text[i]}");