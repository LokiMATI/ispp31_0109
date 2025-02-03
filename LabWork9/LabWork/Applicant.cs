public class Applicant : IPrinter
{
    public string FullName { get; set; }
    public int ClassNumber { get; set; }
    public double AverageScore { get; set; }

    public void Print()
        => Console.WriteLine($"ФИО: {FullName}; Номер класса: {ClassNumber}; Средний балл: {AverageScore}");
}
