Console.WriteLine("operations\n");

Factory factory = new() { Name = "SEVMASH", Income = 1000000 };
factory.ShowInfo();
factory++;
factory.ShowInfo();

Factory starFactory = new() { Name = "Zvezdochka", Income = 500000 };

Factory Severodvinsk = factory + starFactory;
Severodvinsk.ShowInfo();
