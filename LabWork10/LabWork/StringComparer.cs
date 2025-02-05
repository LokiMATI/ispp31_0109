public class StringComparer : IComparer<Applicant>
{
    public int Compare(Applicant? x, Applicant? y)
    {
        if (x.FullName.CompareTo(y.FullName) == 1)
            return 1;
        if (x.FullName.CompareTo(y.FullName) == -1)
            return -1;
        return 0;
    }
}
