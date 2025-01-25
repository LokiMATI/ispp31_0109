public class Applicant
{
    private string? _fullName;
    private int _classNumber;
    private double _gpa;

    public Applicant() : this("Unknown", 1, 1)
    {
    }

    public Applicant(string fullName, int classNumber, double gpa)
    {
        FullName = fullName;
        ClassNumber = classNumber;
        GPA = gpa;
    }

    public string FullName
    {
        get => _fullName;
        set
        {
            if (value.Trim() != String.Empty)
                _fullName = value;
        }
    }

    public int ClassNumber
    {
        get => _classNumber;
        set
        {
            if (value > 0 && value <= 11)
                _classNumber = value;
        }
    }

    public double GPA
    {
        get => _gpa;
        set
        {
            if (value > 0 && value <= 5.0)
                _gpa = value;
        }
    }

    public void Print()
        => Console.WriteLine($"Абитуриент: {_fullName} закончил {_classNumber} классов со средним балом {_gpa}");
}
