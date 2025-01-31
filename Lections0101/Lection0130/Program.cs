Console.WriteLine("operations\n");

Factory factory = new() { Name = "SEVMASH", Income = 1000000 };
factory.ShowInfo();
factory++;
factory.ShowInfo();

Factory starFactory = new() { Name = "Zvezdochka", Income = -500000 };

Factory Severodvinsk = factory + starFactory;
Severodvinsk.ShowInfo();

if (factory)
    Console.WriteLine("SEVMASH income > 0");
else
    Console.WriteLine("SEVMASH income <= 0");

if (starFactory)
    Console.WriteLine("Zvezdochka income > 0");
else
    Console.WriteLine("Zvezdochka income <= 0");

if (factory == Severodvinsk) 
    Console.WriteLine("factory == Severodvinsk");
else
    Console.WriteLine("factory != Severodvinsk");

var random = new PowerfullRandom();
Console.WriteLine(random.NextDouble(-7.1, 9));

Console.WriteLine(factory);