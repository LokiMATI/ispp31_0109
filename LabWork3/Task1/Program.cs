using System.Diagnostics;

Debug.WriteLine(Factorial(-1));
Debug.Assert(Factorial(-1) == 0);

Debug.WriteLine(Factorial(0));
Debug.Assert(Factorial(0) == 1);

Debug.WriteLine(Factorial(1));
Debug.Assert(Factorial(1) == 1);

Debug.WriteLine(Factorial(5));
Debug.Assert(Factorial(5) == 120);

// Задание 1
static int Factorial(int n)
{
    if (n < 0)
        return 0;

    if (n <= 1)
        return 1;

    return n * Factorial(n - 1);
}