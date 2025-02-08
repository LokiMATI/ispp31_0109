// Задание 2
Dictionary<string, double> currencies = new()
{
    ["Доллар"] = 0.5,
    ["Евро"] = 0.8,
    ["Юань"] = 1000000
};

Console.Write("Введите количество новых элементов: ");
int count = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значения для новых валют:");
for (int i = 0; i < count; i++)
{
    Console.Write("Введите название валюты: ");
    var currencyName = Console.ReadLine();

    Console.Write("Введите курс валюты относительно рубля: ");
    var currencyValue = double.Parse(Console.ReadLine());

    currencies[currencyName] = currencyValue;
    Console.WriteLine();
}

foreach (var currency in currencies)
    Console.WriteLine($"{currency.Key} - {currency.Value}");

Console.WriteLine($"Количество элементов в словаре: {currencies.Count}");

// Задание 3
// 1
Console.Write("\nВведите ключ: ");
string key = Console.ReadLine();

if (currencies.ContainsKey(key))
    Console.WriteLine($"{key} - {currencies[key]}");
else
    Console.WriteLine("Такого ключа нет в словаре.");

// 2
Console.Write("\nВведите значение: ");
double currencyValueInput = double.Parse(Console.ReadLine());

int countValue = 0;

foreach (var value in currencies.Values)
    if (value == currencyValueInput)
        countValue++;

Console.WriteLine($"Количество значений в словаре равно: {countValue}");

// 3
Console.Write("Введите ключ для удаления элемента: ");
var deleteKey = Console.ReadLine();

currencies.Remove(deleteKey);

foreach (var currency in currencies)
    Console.WriteLine($"{currency.Key} - {currency.Value}");