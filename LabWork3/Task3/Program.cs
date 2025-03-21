using System.Diagnostics;

Exponential(2, 15);

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

    double y = Exponential(x, n / 2);

    if (n % 2 != 0)
        return x * y * y;

    return y * y;
}