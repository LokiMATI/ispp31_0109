Console.Write("Введите путь до папки: ");
var path = Console.ReadLine();

if (!Directory.Exists(path))
{
    Console.WriteLine("Данной папки не существует.");
    return;
}

Console.Write("Введите текст: ");
var searchFileName = Console.ReadLine() ?? string.Empty;

var fileNames = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

foreach (var fileName in fileNames)
    if (fileName.Contains(searchFileName, StringComparison.OrdinalIgnoreCase))
    {
        FileInfo fileInfo = new(fileName);
        Console.WriteLine($"Полное имя файла: {fileInfo.FullName} | Размер файла: {fileInfo.Length} Б");
    }
