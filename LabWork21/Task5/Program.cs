Console.WriteLine($"Факториал 5: {Factorial.GetFactorial(5)}\n");
Console.WriteLine($"Факториал 6: {Factorial.GetFactorial(6)}\n");

Console.WriteLine($"Возведение 2 в 15 степень: {Exponential(2, 15)}");

double Exponential(double x, int n)
{
    if (n < 0)
        return -1;

    if (n == 0)
        return 1;

    double temp = Exponential(x, n / 2);

    if (n % 2 != 0)
        return x * temp * temp;

    return temp * temp;
}

class Factorial
{
    public static Dictionary<uint, long> factorialCash = new();

    public static long GetFactorial(uint number)
    {
        if (number <= 1)
            return 1;

        if (factorialCash.ContainsKey(number))
            return factorialCash[number];

        factorialCash[number] = number * GetFactorial(number - 1);

        return factorialCash[number];
    }
}