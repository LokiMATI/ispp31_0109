using System.Diagnostics;

Debug.WriteLine(Exponential(5, 3));
Debug.Assert(Exponential(5, 3) == 125);

Debug.WriteLine(Exponential(10,-2));
Debug.Assert(Exponential(10, -2) == 0.01);

// Задание 2
static double Exponential(double x, int n)
{
    if (n == 0)
        return 1;

    if (n < 0)
        return 1 / Exponential(x, -n);

    return x * Exponential(x, n - 1);
}