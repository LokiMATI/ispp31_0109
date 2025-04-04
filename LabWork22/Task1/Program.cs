await Task.Run(() => Exponentiation(2, 5));
await Task.Run(() => Exponentiation(4, 2));
await Task.Run(() => Exponentiation(1, 5));
Console.WriteLine();
var task1 = Task.Run(() => Exponentiation(7, 2));
var task2 = Task.Run(() => Exponentiation(5, 2));
var task3 = Task.Run(() => Exponentiation(4, 2));

await Task.WhenAll(task1, task2, task3);

static void Exponentiation(double a, int x)
    => Console.WriteLine($"{a}^{x}={Math.Pow(a, x)}");