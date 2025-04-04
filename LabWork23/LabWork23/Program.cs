using LabWorkLibrary;

int x = 22, y = 5;

Console.WriteLine($"{x}+{y}={Maths.Add(x, y)}");
Console.WriteLine($"{x}-{y}={Maths.Subtract(x, y)}");
Console.WriteLine($"{x}/{y}={Maths.Divide(x, y)}");
Console.WriteLine($"{x}*{y}={Maths.Multiply(x, y)}");
Console.WriteLine($"Площадь прямоугольника со сторонами {x} и {y}: {Maths.GetSquare(x, y)}");
Console.WriteLine($"Константа BINARY_FACTOR = {Maths.BINARY_FACTOR}");

User user = new() { Login = "Git", Password = "tiG", Role = Role.Administrator };