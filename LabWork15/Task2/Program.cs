// Задание 2
MathDelegate mathDelegate = Sum;
mathDelegate += Difference;
mathDelegate += Multiplication;
mathDelegate += Division;

Console.Write("Введите значение x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение y: ");
int y = int.Parse(Console.ReadLine());

mathDelegate(x, y);


static void Sum(int x, int y) 
    => Console.WriteLine($"{x} + {y} = {x + y}");

static void Difference(int x, int y)
    => Console.WriteLine($"{x} - {y} = {x - y}");

static void Multiplication(int x, int y)
    => Console.WriteLine($"{x} * {y} = {x * y}");

static void Division(int x, int y)
    => Console.WriteLine($"{x} / {y} = {x / y}");