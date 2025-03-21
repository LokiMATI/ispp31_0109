// вычисление площади кольца
Console.Write("Введите значение радиуса первой окружности: ");
int r1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение радиуса второй окружности: ");
int r2 = int.Parse(Console.ReadLine());

double ringSquare = Math.PI * (r1 - r2) * (r1 + r2);

if (ringSquare < 0)
    ringSquare = -ringSquare;

Console.WriteLine($"Площадь кольца: {ringSquare}");

// сумма чисел от 1 до n (заменить на сумму ряда натуральных чисел)

Console.Write($"Введите значение n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Значение суммы чисел от 1 до {n}: {(1 + n) * n / 2}");

Console.WriteLine(GetSize(31457280));
Console.WriteLine(GetSize(3145728000000));
Console.WriteLine(GetSize(5));
string GetSize(ulong bytes) 
    => bytes < 1 << 10 ? $"{bytes} Б"
        : bytes < 1 << 20 ? $"{bytes >> 10} КБ"
        : bytes < 1 << 30 ? $"{bytes >> 20} МБ"
        : $"{bytes >> 30} ГБ";


