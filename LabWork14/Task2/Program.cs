// Задание 2
using System.Text.RegularExpressions;

Console.Write("Введите строку: ");
string input = Console.ReadLine();
string pattern = @"\s+";
string replacement = " ";

Console.WriteLine(Regex.Replace(input, pattern, replacement));