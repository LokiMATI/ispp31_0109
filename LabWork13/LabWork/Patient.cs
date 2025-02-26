public class Patient
{
    public string FullName { get; set; }
    public string Polis { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}
