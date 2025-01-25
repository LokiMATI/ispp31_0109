
public class Person
{
    // данные класса
    // field
    private string fullName;
    public static string Country;
    public const int MajorityAge = 18;
    private int _age;

    public string FullName
    {
        get => fullName;
        //set
        //{ 
        //    if (value.Trim() != String.Empty) 
        //        fullName = value.Trim();
        //}
    }
    public int Age
    {
        get => _age;
        set
        {
            if (value >= 0)
            _age = value;
        }
    }

    public Person()
        : this("unknown", 18)
    {
    }

    ~Person()
    {
        // очистка ресурсов
    }

    public Person(string fullName, int age)
    {
        FullName = fullName;
        Age = age;
    }

    public int BirthYear() 
        => DateTime.Now.Year - Age;

    // функции класса
    public void Print()
    {
        // this.полу
        Console.WriteLine($"name: {FullName}");
        Console.WriteLine($"country: {Country}");
        Console.WriteLine($"majority age: {MajorityAge}");
    }
}