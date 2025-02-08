public class DescendingComparer : IComparer<Applicant>
{
    public int Compare(Applicant? applicant1, Applicant? applicant2)
        => -applicant1.CompareTo(applicant2);
}