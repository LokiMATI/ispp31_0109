public class Cat
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public bool HasHome { get; set; } = true;

    public int BreedId { get; set; } = 1;
}

public class Breed
{
    public int BreedId { get; set; }
    public string BreedName { get; set; }
}