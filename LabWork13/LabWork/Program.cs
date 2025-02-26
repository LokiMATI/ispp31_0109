using System.Text;

Console.Write("Введите строку: ");
string input = Console.ReadLine();

#region Задание 1

Console.WriteLine("Задание 1\n");

Console.WriteLine($"Количество символов в ведённой строке: {input.Length}");
Console.WriteLine($"Количество символов в ведённой строке без пробелов: {input.Replace(" ", "").Length}");

int symbolCount = 0;

foreach (var symbol in input)
    if (Char.IsLetter(symbol))
        symbolCount++;

Console.WriteLine($"Количество букв в ведённой строке: {symbolCount}");

Console.Write("Введите искомый символ: ");
char searchSymbol = Char.Parse(Console.ReadLine());

List<int> positions = new();
int lastPosition = 0;

while (input.IndexOf(searchSymbol, lastPosition) != -1 && lastPosition < input.Length)
{
    positions.Add(input.IndexOf(searchSymbol, lastPosition));
    lastPosition = positions[positions.Count - 1] + 1;
}

if (positions.Count == 0)
    Console.WriteLine("В строке нет искомого символа.");
else
    foreach (int position in positions)
        Console.Write($"{position} ");

Console.WriteLine("\nЗадание 2");
#endregion

#region Задание 2
input = input.Trim();

var strings = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

input = String.Join(" ", strings);

Console.WriteLine($"{input}\n");

Console.WriteLine("Выберете регистр:\n1) верхний,\n2) нижний,\n3) инвертированный");
Console.Write("Напишите цифру варианта: ");
int register = int.Parse(Console.ReadLine());

StringBuilder inputStringBuilder = new StringBuilder();

switch (register)
{
    case 1:
        inputStringBuilder.Append(input.ToUpper()); 
        break;

    case 2:
        inputStringBuilder.Append(input.ToLower());
        break;
        

    case 3:
        foreach (var symbol in input)
            if (Char.IsLower(symbol))
                inputStringBuilder.Append(Char.ToUpper(symbol));
            else
                inputStringBuilder.Append(Char.ToLower(symbol));
        break;

    default:
        Console.WriteLine("Такого варианта нет.");
        break;
}

Console.WriteLine($"{inputStringBuilder.ToString()}\n");
#endregion

#region Задание 3
List<string> dividingSymbols = [".", "!", "?", "!?", "?!"];

var sentences = input.Split(dividingSymbols.ToArray(), StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

foreach (var sentence in sentences)
    Console.WriteLine(sentence);
Console.WriteLine();

dividingSymbols.AddRange([" ", ","]);

sentences = input.Split(dividingSymbols.ToArray(), StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

foreach (var sentence in sentences)
    Console.WriteLine(sentence);
Console.WriteLine();
#endregion

#region Задание 4
Product product = new() { Name="тост", Price=2.23, ExpirationDate=DateTime.Now };
Console.WriteLine(product);
#endregion