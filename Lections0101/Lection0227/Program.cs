Console.WriteLine("Делегат");

MathDelegate math = (x, y) =>  x + y;
int sum = math(2, 5);
Console.WriteLine(sum);

Action hello = () => Console.WriteLine("hello word");
hello += WriteCurrentDate;
hello();

Func<int,int> square = x => x * x;
int result = square(5);
Console.WriteLine(result);

Func<int, int, bool> areEquare = (x, y) => x == y;

if (areEquare(123, 234))
    Console.WriteLine("x=y");

Predicate<int> isPositive = x => x > 0;
Console.WriteLine(isPositive(-5));
Console.WriteLine(isPositive(0));
Console.WriteLine(isPositive(5));



static void WriteCurrentDate()
{
    Console.WriteLine(DateTime.Now);
}