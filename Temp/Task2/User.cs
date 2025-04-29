using System.Windows.Controls;

public class User
{
    public string Address { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string HiddenPassword => new('•', Password.Length);
    public string Category { get; set; }
    public bool IsArchived { get; set; }


}