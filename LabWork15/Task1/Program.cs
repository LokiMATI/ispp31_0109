Console.Write("Введите значение x: ");
int x = int.Parse(Console.ReadLine());

#region Задание 1
MathDelegate mathDelegate = Square;
Console.WriteLine($"Квадрат {x} равен {mathDelegate(x)}");

mathDelegate = Factorial;
Console.WriteLine($"Факториал {x} равен {mathDelegate(x)}");

mathDelegate = Abs;
Console.WriteLine($"Модуль {x} равен {mathDelegate(x)}\n");
#endregion

#region Задание 4
MathDelegate[] mathDelegates = [Square, Factorial, Abs];

for (int i = 0; i < mathDelegates.Length; i++)
    Console.WriteLine($"Вызов {i} метода в массиве возвращает: {mathDelegates[i](x)}");
Console.WriteLine();
#endregion

#region Задание 5
foreach (var item in mathDelegates)
    InvokeMathDelegate(item, x);
#endregion

static int Square(int x) 
    => x * x;

static int Factorial(int n)
{
    if (n < 0)
        return 0;

    if (n == 0)
        return 1;

    return n * Factorial(n - 1);
}

static int Abs(int x)
{
    if (x < 0) 
        return -x;
    return x;
}

static void InvokeMathDelegate(MathDelegate mathDelegate, int x)
    => Console.WriteLine($"Результат вызова переданного делегата: {mathDelegate?.Invoke(x)}");



