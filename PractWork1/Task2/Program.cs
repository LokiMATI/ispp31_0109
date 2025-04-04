using System.Text;

Console.Write("Введите имя файла: ");
string path = Console.ReadLine();

if (File.Exists(path))
    Console.WriteLine("Файл с данным именем существет и он будет открыт на дозапись.");
else
    Console.WriteLine("Файла с данным именем не существует и поэтому он будет создан.");

Console.WriteLine("Вводите содержание файла:");
StringBuilder builder = new();
string line;
while(true)
{
    line = Console.ReadLine();
    if (line == "end")
        break;
    builder.AppendLine(line);
}

File.AppendAllText(path, builder.ToString());