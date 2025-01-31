// Задание 1

Applicant applicant1 = new() { FullName = "Иванов Иван Иванович", ClassNumber = 9, AverageScore = 3.44 };
Applicant applicant2 = new() { FullName = "Мхалков Михаил Михайлович", ClassNumber = 11, AverageScore = 5.00 };

Console.WriteLine(applicant1.ToString());
Console.WriteLine(applicant1);

Console.WriteLine(applicant2.ToString());
Console.WriteLine(applicant2);

// Задание 2

Console.WriteLine(applicant1.Equals(applicant2));
Console.WriteLine(applicant1.Equals(applicant1));

