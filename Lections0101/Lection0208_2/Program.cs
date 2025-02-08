Console.WriteLine("struct");

for (int i = 0; i < 16; i++)
{
    ConsoleColor color = (ConsoleColor)i;
    Console.BackgroundColor = (ConsoleColor)i;
    Console.WriteLine(color);
}

Person person1 = new() { Id = 123, FullName = "qwe asd zxc" };
Console.WriteLine(person1);
Person person2 = new() { Id = 123, FullName = "qwe asd zxc" };
Console.WriteLine(person2);

if (person1.Equals(person2))
    Console.WriteLine("равны");
else
    Console.WriteLine("не равны");

Point2d point = new();