// Задание 3
using System.Text.RegularExpressions;

Regex regex = new(@"^[a-z1-9_\-\.]+\@([a-z0-9]+\.){0,2}[a-z]+", RegexOptions.IgnoreCase);
Console.Write("Введите адрес электронной почты: ");
string input = Console.ReadLine();

if (regex.IsMatch(input))
    Console.WriteLine("Введён верный адрес электронной почты.");
else
    Console.WriteLine("Введён неверный адрес электронной почты.");