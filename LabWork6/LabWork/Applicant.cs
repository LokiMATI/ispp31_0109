namespace LabWork;

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
        _fullName = fullName;
        _classNumber = classNumber;
        _averageScore = averageScore;
    }
    public object this[string index]
    {
        get
        {
            switch (index)
            {
                case "ФИО":
                    return _fullName;
                case "Класс":
                    return _classNumber;
                case "Средний балл":
                    return _averageScore;
                default:
                    return null;
            }
        }
    }

    public char this[int index]
    {
        get
        {
            if (index >= 0 && index < _fullName.Length && _fullName != null)
                return _fullName[index];

            return '\0';
        }
    }
}
