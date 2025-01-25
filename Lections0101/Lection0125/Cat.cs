using System.Threading.Channels;

public class Cat(string name, int age)
{
    public int Master { get; set; }

    private string breed;

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }


    public Cat() : this("kisa-kisa", 1)
    {
    }

    public void Print()
        => Console.WriteLine($"{name} {age}");
}

