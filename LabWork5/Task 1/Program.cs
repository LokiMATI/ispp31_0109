// Задание 1
Applicant applicant1 = new();
Applicant applicant2 = new("Матигоров Никита Иванович", 9, 4.54);
applicant1.Print();
applicant2.Print();

// Задание 2
Console.WriteLine("\nЗадание 2");
applicant1.Print();
applicant2.Print();


// Задание 3
Console.WriteLine("\nЗадание 3");
applicant1.FullName = "  ";
applicant2.ClassNumber = 12;
applicant2.AverageScore = -12.0;

applicant1.Print();
applicant2.Print();
Console.WriteLine();

applicant1.FullName = "Тестов Тест Тестирович";
applicant2.ClassNumber = 11;
applicant2.AverageScore = 5;

applicant1.Print();
applicant2.Print();

Console.WriteLine("\nЗадание 4");

Applicant[] applicants = {
    new("Приветов Привет Приветович", 11, 4.89),
    new("Запоздалов Виктор Проспатович", 8, 4.66),
    applicant1,
    applicant2
};

Console.WriteLine("а) Окончившие 11 классов:");
foreach (var applicant in applicants)

    if (applicant.ClassNumber == 11)
        applicant.Print();

Console.Write("\nВведите средний бал: ");
double averageScore = Double.Parse(Console.ReadLine());                 

Console.WriteLine("\nб)  Абитуриенты со средним баллом выше заданного:");
foreach (var applicant in applicants)
    if (applicant.AverageScore > averageScore)
        applicant.Print();
