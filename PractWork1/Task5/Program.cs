Console.Write("Введите путь до папки: ");
var path = Console.ReadLine();

if (!Directory.Exists(path))
{
    Console.WriteLine("Данной папки не существует.");
    return;
}

var files = Directory.GetFiles(path);

foreach (var file in files)
{
    FileInfo fileInfo = new(file);
    Directory.CreateDirectory($@"{path}\{fileInfo.CreationTime.ToString().Replace(":", "_")}");
    fileInfo.MoveTo($@"{path}\{fileInfo.LastAccessTime.ToString().Replace(":", "_")}\{fileInfo.Name}", true);
}