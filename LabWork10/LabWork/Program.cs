// Задание 1
using static System.Runtime.InteropServices.JavaScript.JSType;

Applicant[] applicants = [
    new Applicant
    {
        FullName = "Воландов Воланд Воландович",
        ClassNumber = 100,
        AverageScore = 666.00
    },
    new Applicant
    {
        FullName = "Иванов Иван Иванович",
        ClassNumber = 9,
        AverageScore = 3.25
    },
    new Applicant
    {
        FullName = "Мастеров Мастер Мастерович",
        ClassNumber = 10,
        AverageScore = 5.00
    },
    new Applicant
    {
        FullName = "Маргаритова Маргарита Маргаритовна",
        ClassNumber = 11,
        AverageScore = 4.53
    }
    ];

foreach (var applicant in applicants)
    if (applicant is not null)
        Console.WriteLine($"{applicant.FullName} закончил {applicant.ClassNumber} класс со средним баллом {applicant.AverageScore}.");
    else
        Console.WriteLine("null");


Array.Sort(applicants);
Console.WriteLine();

foreach (var applicant in applicants)
    if (applicant is not null)
        Console.WriteLine($"{applicant.FullName} закончил {applicant.ClassNumber} класс со средним баллом {applicant.AverageScore}.");
    else
        Console.WriteLine("null");

// Задание 3
Applicant applicant1 = new()
{
    FullName = "Крош",
    ClassNumber = 1,
    AverageScore = 2.00
};
Applicant applicant2 = new()
{
    FullName = "Ёжик",
    ClassNumber = 11,
    AverageScore = 5.00
};

Console.WriteLine($"\n{applicant1.Equals(applicant2)}");

// Задание 4
Applicant? cloneApplicant = applicant2.Clone() as Applicant;

applicant2.FullName = "Копатыч";

Console.WriteLine($"\n{cloneApplicant.FullName} закончил {cloneApplicant.ClassNumber} класс со средним баллом {cloneApplicant.AverageScore}.\n");

// Задание 5

foreach (var applicant in applicants)
    if (applicant is not null)
        Console.WriteLine($"{applicant.FullName} закончил {applicant.ClassNumber} класс со средним баллом {applicant.AverageScore}.");
    else
        Console.WriteLine("null");
Console.WriteLine();

Array.Sort(applicants, new DescendingComparer());

foreach (var applicant in applicants)
    if (applicant is not null)
        Console.WriteLine($"{applicant.FullName} закончил {applicant.ClassNumber} класс со средним баллом {applicant.AverageScore}.");
    else
        Console.WriteLine("null");
Console.WriteLine();

Array.Sort(applicants,new StringComparer());

foreach (var applicant in applicants)
    if (applicant is not null)
        Console.WriteLine($"{applicant.FullName} закончил {applicant.ClassNumber} класс со средним баллом {applicant.AverageScore}.");
    else
        Console.WriteLine("null");