record Person
{
    public Person()
    {
    }

    public Person(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
    public string FullName { get; set; }
}

