// Задание 3
using System.Text.RegularExpressions;

Console.Write("Введите строку: ");
string inputString = Console.ReadLine();

Regex regex = new(@"[A-z_0-9\-]{256}@([A-z0-9]\.$){1,2}[A-z]", RegexOptions.IgnoreCase);

if (regex.IsMatch(inputString))
    Console.WriteLine("Всё ок.");
else
    Console.WriteLine("Всё не ок.");