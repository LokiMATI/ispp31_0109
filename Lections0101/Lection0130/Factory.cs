public class Factory
{
    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Прибыль
    /// </summary>  
    public int Income { get; set; }

    public void ShowInfo()
        => Console.WriteLine($"{Name}, {Income} руб.");

    public static Factory operator ++(Factory factory) => 
        new() 
        { 
            Name = factory.Name, 
            Income = factory.Income + 1000 
        };

    public static Factory operator +(Factory factoryParent, Factory factoryChild) =>
        new()
        {
            Name = factoryParent.Name,
            Income = factoryParent.Income + factoryChild.Income
        };

    public static bool operator true(Factory factory)
    {
        return factory.Income > 0;
    }

    public static bool operator false(Factory factory)
    {
        return factory.Income <= 0;
    }
}
