// Задание 5
using System.Text.RegularExpressions;

Regex regex = new(@"^\d{2}[./]\d{2}[./]\d{4}$");
Console.Write("Введите дату: ");
string input = Console.ReadLine();

if (!regex.IsMatch(input))
{
    Console.WriteLine("Некорректный формат ввода даты.");
    return;
}

Regex pattern = new(@"^(?<day>\d{2})[./](?<month>\d{2})[./](?<year>\d{4})$");

string formatedDate = pattern.Replace(input, "${year}-${month}-${day}");

Console.WriteLine(formatedDate);

    