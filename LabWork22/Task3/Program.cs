Task task1 = ReadFileAsync("test1.txt");
Task task2 = ReadFileAsync("test2.txt");
Task task3 = ReadFileAsync("test3.txt");

await Task.WhenAll(task1, task3, task2);

static async Task ReadFileAsync(string fileName)
{
    using (StreamReader reader = new(fileName))
    {
        Console.WriteLine($"Чтение из файла {fileName} начато");

        string line;
        while ((line = await reader.ReadLineAsync()) != null)
            Console.WriteLine($"{fileName}: {line}");

        Console.WriteLine($"Чтение из файла {fileName} закончено");
    }
}