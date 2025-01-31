public class Applicant
{
    public string FullName { get; set; }
    public int ClassNumber { get; set; }
    public double AverageScore { get; set; }

    public void Print() =>
        Console.WriteLine($"ФИО: {FullName}; Выпускной класс: {ClassNumber}; Средний балл: {AverageScore}");

    public override string ToString() 
        => $"ФИО: {FullName}; Выпускной класс: {ClassNumber}; Средний балл: {AverageScore}";

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj)) 
            return true;

        return obj is Applicant applicant 
            && FullName == applicant.FullName
            && ClassNumber == applicant.ClassNumber
            && AverageScore == applicant.AverageScore;
    }
}