public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public DateTime ExpirationDate { get; set; }

    public override string ToString()
    {
        return String.Format("{0};{1:C2};{2:yyyy-MM-dd}", $"{Char.ToUpper(Name[0])}{Name.Substring(1, Name.Length)}", Price, ExpirationDate);
    }
}
