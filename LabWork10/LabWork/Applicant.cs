using System;

public class Applicant : IComparable, IComparable<Applicant>, IEquatable<Applicant>, ICloneable
{
    public string FullName { get; set; }
    public int ClassNumber { get; set; }
    public double AverageScore { get; set; }

    public object Clone() => new Applicant()
    {
        FullName = FullName,
        ClassNumber = ClassNumber,
        AverageScore = AverageScore
    };

    public int CompareTo(object? obj)
    {
        Applicant? applicant = obj as Applicant;
        return AverageScore.CompareTo(applicant?.AverageScore);
    }

    public int CompareTo(Applicant? other)
        => AverageScore.CompareTo(other?.AverageScore);

    public bool Equals(Applicant? other)
    {
        if (ReferenceEquals(this, other)) 
            return true;

        return FullName == other?.FullName &&
            ClassNumber == other.ClassNumber &&
            AverageScore == other.AverageScore;
    }
}
    