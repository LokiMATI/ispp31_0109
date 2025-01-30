using System.Runtime.CompilerServices;

namespace LabWork;

public class Applicant
{
    public string FullName {  get; set; }
    public int ClassNumber { get; set; }
    public double AverageScore { get; set; }

    public void Print() =>
        Console.WriteLine($"ФИО: {FullName}; Выпускной класс: {ClassNumber}; Средний балл: {AverageScore}");

    public static Applicant operator ++(Applicant applicant) => 
        new Applicant 
        { 
        FullName = applicant.FullName, 
        ClassNumber = applicant.ClassNumber, 
        AverageScore = Double.Round((applicant.AverageScore + 1), 2)
        };

    public static Applicant operator +(Applicant applicant1, Applicant applicant2) =>
        new Applicant
        {
            FullName = applicant1.FullName,
            ClassNumber = applicant1.ClassNumber,
            AverageScore = Double.Round(applicant1.AverageScore + applicant2.AverageScore, 2)
        };

    public static bool operator ==(Applicant applicant1, Applicant applicant2)
    {
        if (applicant1.FullName == applicant2.FullName 
            && applicant1.ClassNumber == applicant2.ClassNumber
            && applicant1.AverageScore == applicant2.AverageScore)
            return true;

        return false;
    }

    public static bool operator !=(Applicant applicant1, Applicant applicant2)
    {
        if (applicant1.FullName != applicant2.FullName
            && applicant1.ClassNumber != applicant2.ClassNumber
            && applicant1.AverageScore != applicant2.AverageScore)
            return true;

        return false;
    }

    public static bool operator true(Applicant applicant) =>
        applicant.AverageScore >= 0;

    public static bool operator false(Applicant applicant) =>
        applicant.AverageScore < 0;
    public static bool operator !(Applicant applicant) =>
        applicant.AverageScore >= 0;
}

