using LabWork;

// Задание 1
Console.WriteLine("Задание 1");
Applicant applicant1 = new();
Applicant applicant2 = new("Тестов Тест Тесторович", 11, 4.55);

applicant1.Print();
applicant2.Print();

// Задание 2
Console.WriteLine("\nЗадание 2");
applicant1.FullName = "";
applicant1.AverageScore = -5;
applicant1.ClassNumber = -3;
applicant1.Print();

applicant2.FullName = "Матигоров Никита Иванович";
applicant2.AverageScore = 4.44;
applicant2.ClassNumber = 9;
applicant2.Print();

// Задание 4
//Console.WriteLine("\nЗадание 4");
//Applicant[] applicants = [
//    applicant1,
//    applicant2,
//    new("Иванова Татьяна Николаевна", 10, 4.56),
//    new("Иванова Мария Васильевна", 11, 5)];

//applicants[2].Gender = Gender.Female;
//applicants[3].Gender = Gender.Female;

//Console.Write("Введите пол(0 - мужской, 1 - женский): ");
//byte gender = byte.Parse(Console.ReadLine());

//foreach (var applicant in applicants)
//    if (applicant.Gender == (Gender)gender)
//        applicant.Print();

// Здание 5
Console.WriteLine("\nЗадание 5");
Flight flight1 = new()
{
    Destination = "Москва",
    FlightNumber = "FD 2850",
    PassengerCapacity = 250
};

Flight flight2 = new()
{
    Destination = "Москва",
    FlightNumber = "FD 2850",
    PassengerCapacity = 250
};

Flight flight3 = new()
{
    Destination = "Архангельск",
    FlightNumber = "FF 7777",
    PassengerCapacity = 666
};

Console.WriteLine(flight1);
Console.WriteLine(flight2);
Console.WriteLine(flight3);

Console.WriteLine();

Console.WriteLine($"Сравнение flight1 и flight2 даёт результат: {flight1 == flight2}");
Console.WriteLine($"Сравнение flight1 и flight3 даёт результат: {flight1 == flight3}");
Console.WriteLine($"Сравнение flight2 и flight3 даёт результат: {flight2 == flight3}\n");

Console.WriteLine($"Сравнение flight1 и flight2 даёт результат: {flight1.Equals(flight2)}");
Console.WriteLine($"Сравнение flight1 и flight3 даёт результат: {flight1.Equals(flight3)}");
Console.WriteLine($"Сравнение flight2 и flight3 даёт результат: {flight2.Equals(flight3)}");
