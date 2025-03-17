// Задание 5
using Task5;

Configuration configuration = Configuration.GetInstance();

configuration["Цвет"] = "Красный";
configuration["Размер текста"] = "14px";

Console.WriteLine(configuration);
