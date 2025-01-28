using System.ComponentModel;
using System.Net.WebSockets;

Console.WriteLine("methods");

//var login = "admin";
//login = login.FormatName(); // параметр.МетодРасширения()
//Console.WriteLine(login);

//double x = 5.5;
//Console.WriteLine(x.ToInt());


// имяПараметра: значениеАргумента

Add(b: 5, a: 2);
Substract(5, 2);
Substract(a: 5, b: 2);
Substract(b: 5, a: 2);

static int Add(int a, int b = 1) => a + b;
static int Substract(int a, int b) => a - b;

int x = Add(5, 2);
x = Add(x, 3);

static void PrintValueInfo(params object[] values)
{
    foreach (var value in values)
        Console.WriteLine($"{value} - {value.GetType()}");
}

//PrintValueInfo(5, 3);
//PrintValueInfo(12, "asd", 0.1, true);
//PrintValueInfo([12, "asd", 0.1, true]);

// in

// ref (reference)

static void GetAbs(ref int x)
{
    if (x < 0) 
        x = -x;
}

x = -50;
Console.WriteLine(x);
GetAbs(ref x);
Console.WriteLine(x);

static void Swap(ref int x, ref int y) =>
    (x, y) = (y, x);

int a = 5, b = 2;
Console.WriteLine($"{a} {b}");
Swap(ref a, ref b);
Console.WriteLine($"{a} {b}");

// out
int count;

Int32.TryParse("123", out count);
Console.WriteLine(count);

Int32.TryParse("123abc", out count);
Console.WriteLine(count);

void Sum(int a, int b, out int sum) =>
    sum = a + b;

Sum(12, 7, out count);
Console.WriteLine(count);