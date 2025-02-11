using System.Text.RegularExpressions;

var point = (2, 5);
point.Item1 = 68;

//var point = (x: 2, y: 5);
//point.Item1 = 4;
//point.x = 75;
Console.WriteLine(point);

(double, double, double) point3d = (0, 3, 5);

(int, string) user = (Id: 123, Login: "admin");
Console.WriteLine(user);

SummerMonth month = SummerMonth.Jule;
Color purple = Color.Red | Color.Blue;

Season season = (Season)3;      // Season.Winter
int monthNumber = (int)month;   // 7
int purpleValue = (int)purple;  // 1+4=5

RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.RightToLeft;

for (int i = 0; i < 16; i++)
{
    ConsoleColor color = (ConsoleColor)i;
    Console.BackgroundColor = (ConsoleColor)i;
    Console.WriteLine(color);
}

Person person1 = new() { Id = 123, FullName = "qwe asd zxc" };
Console.WriteLine(person1);
Person person2 = new() { Id = 1, FullName = "qwe asd zxc" };
Console.WriteLine(person2);

if (person1.Equals(person2))
    Console.WriteLine("равны");
else
    Console.WriteLine("не равны");
