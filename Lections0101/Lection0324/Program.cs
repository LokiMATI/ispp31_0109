using System.Runtime.InteropServices;

Console.WriteLine("async");

CancellationTokenSource cts = new CancellationTokenSource();
cts.CancelAfter(1000);

await Task.Run(async () => 
{
    if (cts.Token.IsCancellationRequested)
        cts.Token.ThrowIfCancellationRequested();

    Console.WriteLine("start");
    await Task.Delay(3000); // 3000 ms = 3 s
    Console.WriteLine("finish");
}, cts.Token);




//cts.CancelAfter(1000);// 1 s

//Task task1 = Task.Run(() => ShowFactorial(3)); // CPU
//Task task2 = ShowFactorialAsync(6); // I/O

//await Task.WhenAny([task1, task2]);

//List<Task> tasks = [task1, task2];
//await Task.WhenAll(tasks);

Console.WriteLine("end");

//var text = await ReadFileAsync("1.txt");

//await Task.Run(() => ShowFactorial(5));
//long f = await Task.Run(() => GetFactorial(6));
//Console.WriteLine(f);

Console.ReadKey();

static async Task<string> GetJsonAsync(string url)
{
    Console.WriteLine("start");
    await Task.Delay(3000); // 3000 ms = 3 s
    Console.WriteLine("finish");
    return "[ ]";
}

static async Task ShowFactorialAsync(int n)
{
    await Task.Run(() => ShowFactorial(n));
}

static void ShowFactorial(int n)
{
    long result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    Console.WriteLine($"{n}! = {result}");
}

static long GetFactorial(int n)
{
    long result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}

static async Task<string> ReadFileAsync(string fileName)
{
    using StreamReader reader = new(fileName);
    return await reader.ReadToEndAsync();
}