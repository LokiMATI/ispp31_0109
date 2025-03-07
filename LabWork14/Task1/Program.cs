// Задание 1
using System.Text.RegularExpressions;

Console.Write("Введите номер телефона: ");
string number = Console.ReadLine();

Regex regex = new(@"(\+7|8)\(9[0-9]{2}\)[0-9]{3}\-[0-9]{2}\-[0-9]{2}");

if (regex.IsMatch(number))
    Console.WriteLine("Введенный номер является корректным.");
else
    Console.WriteLine("Введенный номер не является корректным.");