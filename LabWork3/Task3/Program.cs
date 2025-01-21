using System.Diagnostics;

Debug.WriteLine(Exponential(5, -2));
Debug.Assert(Exponential(5, -2) == -1);

Debug.WriteLine(Exponential(1, 2));
Debug.Assert(Exponential(1, 2) == 1);

Debug.WriteLine(Exponential(2, 2));
Debug.Assert(Exponential(2, 2) == 4);

Debug.WriteLine(Exponential(2, 5));
Debug.Assert(Exponential(2, 5) == 32);

// Задание 3
static double Exponential(double x, int n)
{
    if (n < 0)
        return -1;

    if (n == 0) 
        return 1;

    if (n % 2 != 0)
    {
        n -= 1;
        return x * Exponential(x, n / 2) * Exponential(x, n / 2);
    }  

    return Exponential(x, n / 2) * Exponential(x, n / 2);
}