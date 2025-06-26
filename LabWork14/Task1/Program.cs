// Задание 1
using System.Text.RegularExpressions;

string pattern = @"^(\+7|8)\(9\d{2}\)\d{3}-\d{2}-\d{2}$";
Console.WriteLine("Введите номер телефона, чтобы соответствовал формату +7(9хх)ххх-хх-хх или 8(9хх)ххх-хх-хх, где х — любая цифра:");
string numberPhone = Console.ReadLine();

if (Regex.IsMatch(numberPhone, pattern))
    Console.WriteLine("Введёный номер телефона соответствует формату.");
else
    Console.WriteLine("Введёный номен телефона НЕ соответствует формату.");