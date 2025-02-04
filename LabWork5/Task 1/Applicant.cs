public class Applicant
{
    private string _fullName;
    private int _classNumber;
    private double _averageScore;

    public Applicant() : this("Unknown", 1, 1)
    {
    }

    public Applicant(string fullName, int classNumber, double averageScore)
    {
        FullName = fullName;
        ClassNumber = classNumber;
        AverageScore = averageScore;
    }

    public string FullName
    {
        get => _fullName;
        set
        {
            if (value.Trim() != String.Empty)
                _fullName = value.Trim();
        }
    }

    public int ClassNumber
    {
        get => _classNumber;
        set
        {
            if (value >= 0 && value <= 11)
                _classNumber = value;
        }
    }

    public double AverageScore
    {
        get => _averageScore;
        set
        {
            if (value > 0 && value <= 5.0)
                _averageScore = value;
        }
    }

    public void Print()
        => Console.WriteLine($"Абитуриент: {_fullName} закончил {_classNumber} классов со средним балом {_averageScore}");
}
