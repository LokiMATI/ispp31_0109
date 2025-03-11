// Задание 2
using System.Text.RegularExpressions;

Console.Write("Введите строку: ");
string inputString = Console.ReadLine();

Regex regex = new(@"\s+");
string target = " ";

Console.WriteLine(regex.Replace(inputString, target));