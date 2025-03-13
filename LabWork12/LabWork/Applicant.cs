namespace LabWork;

public struct Applicant
{
    private string _fullName;
    private int _classNumber;
    private double _averageScore;

    public string FullName
    {
        get => _fullName;
        set
        {
            if (value != String.Empty)
                _fullName = value;
        }
    }
    public int ClassNumber
    {
        get => _classNumber;
        set
        {
            if (value >= 0)
                _classNumber = value;
        }
    }
    public double AverageScore
    {
        get => _averageScore;
        set
        {
            if (value >= 0)
                _averageScore = value;
        }
    }

    public Gender Gender { get; set; }

    public Applicant(string fullName, int classNumber, double averageScore)
    {
        FullName = fullName;
        ClassNumber = classNumber;
        AverageScore = averageScore;
        Gender = Gender.Male;
    }    

    public void Print()
        => Console.WriteLine($"ФИО: {_fullName}, пол: {Gender} выпускной класс: {_classNumber}, средний балл: {_averageScore}");
}
