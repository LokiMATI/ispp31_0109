using System.Globalization;

// Задание 4
Console.WriteLine("Задание 4");
Patient patient = new() { FullName = "Иванов Иван Иванович", BirthDate = DateTime.Now, PolicyNumber = 3456789 };
CultureInfo.CurrentCulture = new("en-US", false);
Console.WriteLine(patient);
