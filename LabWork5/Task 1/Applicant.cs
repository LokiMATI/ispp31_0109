public class Applicant
{
    private string? _fullName;                       //закрытое поле,строковое знач(null)
    private int _classNumber;                        //закрытое поле,цел знач
    private double _averageScore;                    //закрытое поле,вещ знач

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
        get => _fullName;                               //Возращает
        set                                             //присваевает
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
            if (value > 0 && value <= 11)
                _classNumber = value;
        }
    }

    public double AverageScore
    {
        get => _averageScore;
        set
        {
            if (value > 0 && value <= 5.0)              //знач которое мы ввели
                _averageScore = value;
        }
    }

    public void Print()                     //выводит инф об объекте
        => Console.WriteLine($"Абитуриент: {_fullName} закончил {_classNumber} классов со средним балом {_averageScore}");
}
