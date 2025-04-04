Console.Write("Введите имя файла: ");
string path = Console.ReadLine();

if (!File.Exists(path))
    Console.WriteLine("Файла с данным именем нет.");
else
    Console.WriteLine(File.ReadAllText(path));