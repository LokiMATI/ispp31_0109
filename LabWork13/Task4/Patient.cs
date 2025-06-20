public class Patient
{
    public string FullName { get; set; }
    public int PolicyNumber { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        return String.Format("{0};{1:D9};{2:yyyy/MM/dd}", FullName, PolicyNumber, BirthDate);
    }
}
