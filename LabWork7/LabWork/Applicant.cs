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
        new Applicant { 
        FullName = applicant.FullName, 
        ClassNumber = applicant.ClassNumber, 
        AverageScore = applicant.AverageScore++
    };
}

