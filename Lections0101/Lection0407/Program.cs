//if (args.Length == 0)
//{
//    Console.WriteLine("error: input command");
//    return;
//}

//var command = args[0];
//if (command == "commit")
//{
//    if (args.Length == 1)
//    {
//        Console.WriteLine("input massage");
//        return;
//    }
//    Console.WriteLine("commit ...");
//}
//else if (command == "branch")
//{
//    Console.WriteLine("all branches: ...");
//}

Console.Title = "my app";

string command;

Console.Write("input login: ");
var login = Console.ReadLine();
Console.Write("input password: ");
var password = "";
ConsoleKeyInfo key;
do
{
    key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.Enter)
        break;

    password += key.KeyChar;
}
while (true);

Console.WriteLine($"\n{password}");
Console.ReadKey(true);

while (true)
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green; // текст
    Console.BackgroundColor = ConsoleColor.White; // фон
    Console.WriteLine("1-open | 2-save | 3-close");

    Console.ForegroundColor = ConsoleColor.Gray; // текст
    command = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Green;
    switch (command)
    {
        case "1":
            Console.WriteLine("File opened");
            break;
        case "2":
            Console.WriteLine("File saved");
            break;
        case "3":
            Console.WriteLine("File closed");
            break;
        default:
            Console.WriteLine("unknown command");
            break;
    }
    Console.WriteLine();
    Console.ReadKey();
}