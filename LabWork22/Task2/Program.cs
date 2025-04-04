try
{
    CancellationTokenSource cts = new();

    cts.CancelAfter(50);

    await WriteRandomNumbersAsync("numbers2.txt", 500_000, cts.Token);
    Console.WriteLine("Конец программы");
}
catch (OperationCanceledException ex)
{
    Console.WriteLine(ex.Message);
}

static async Task WriteRandomNumbersAsync(
    string fileName, 
    int numbersCount, 
    CancellationToken cancellationToken)
{
    Console.WriteLine($"Запись в файл {fileName} начата");
    using (StreamWriter writer = new(fileName, false))
    {
        for (int i = 1; i <= numbersCount; i++)
        {
            if (cancellationToken.IsCancellationRequested)
                throw new OperationCanceledException("Операция не успела окончить свою работу до конца.");

            await writer.WriteLineAsync($"Число {i}: {Random.Shared.Next()}");
        }
    }
    Console.WriteLine($"Запись в файл {fileName} закончена");
}