using System.Collections;

public class DescendingComparer : IComparer<Applicant>
{
    public int Compare(Applicant? x, Applicant? y)
    {
        if (x.AverageScore < y.AverageScore)
            return 1;
        if (x.AverageScore > y.AverageScore)
            return -1;
        return 0;
    }
}