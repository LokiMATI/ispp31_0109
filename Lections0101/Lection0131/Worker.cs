public class Worker : Person
{
    public string Post { get; set; }

    public Worker(int age, string name, string post)
        : base(age, name)
    {
        Post = post;
    }

    public override void ShowInfo()
    {
        base.ShowInfo(); // необязательно
        Console.WriteLine($"Должность: {Post}");
    }

    //public override string ToString() => $"{Name}, должность: {Post}";
}
