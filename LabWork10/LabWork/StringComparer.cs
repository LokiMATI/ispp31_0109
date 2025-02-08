public class StringComparer : IComparer<Applicant>
{
    public int Compare(Applicant? applicant1, Applicant? applicant2) 
        => applicant1.FullName.CompareTo(applicant2?.FullName);
}
