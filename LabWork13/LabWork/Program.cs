using System.Text;

Console.Write("Введите строку: ");
string inputString = Console.ReadLine();

#region Задание 1
Console.WriteLine("Задание 1");
Console.WriteLine($"Количество символов в ведённой строке: {inputString.Length}");
Console.WriteLine($"Количество символов в ведённой строке без пробелов: {inputString.Replace(" ", string.Empty).Length}");

int letterCount = 0;

foreach (var symbol in inputString)
    if (Char.IsLetter(symbol))
        letterCount++;

Console.WriteLine($"Количество букв в ведённой строке: {letterCount}");

Console.Write("Введите искомый символ: ");
char searchSymbol = Char.Parse(Console.ReadLine());

for (int i = 0; i < inputString.Length; i++)
    if (searchSymbol == inputString[i])
        Console.WriteLine(i);

if (!inputString.Contains(searchSymbol))
    Console.WriteLine("В строке нет искомого символа.");
#endregion

#region Задание 2
Console.WriteLine("\nЗадание 2");

string[] splitStrings = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

inputString = String.Join(" ", splitStrings);

Console.WriteLine($"Строка с убранными лишними побелами:\n{inputString}");

Console.WriteLine("Выберете регистр:\n1) верхний,\n2) нижний,\n3) инвертированный");
Console.Write("Напишите цифру варианта: ");
int register = int.Parse(Console.ReadLine());

switch (register)
{
    case 1:
        Console.WriteLine(inputString.ToUpper());
        break;

    case 2:
        Console.WriteLine(inputString.ToLower());
        break;


    case 3:
        StringBuilder inputStringBuilder = new();
        foreach (char symbol in inputString)
            if (Char.IsLower(symbol))
                inputStringBuilder.Append(Char.ToUpper(symbol));
            else
                inputStringBuilder.Append(Char.ToLower(symbol));

        Console.WriteLine(inputStringBuilder.ToString());
        break;

    default:
        Console.WriteLine("Такого варианта нет.");
        break;
}
#endregion

#region Задание 3
Console.WriteLine("\nЗадание 3");
string[] dividingSymbols = [".", " ", ",", ";", ":"];

var words = inputString.Split(dividingSymbols, StringSplitOptions.RemoveEmptyEntries);

foreach (var word in words)
    Console.WriteLine(word);
#endregion
