// Задание 4

using System.Text.RegularExpressions;

Regex regex = new(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[.?!]).{6,}$");

while(true)
{
    Console.Write("Введите пароль: ");
    string input = Console.ReadLine();

    if (regex.IsMatch(input))
        break;
    else
        Console.WriteLine("Введён ненадёжный пароль.\n");
}

Console.WriteLine("Введён надёжный пароль.");