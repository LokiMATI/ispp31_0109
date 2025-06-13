namespace DataBaseLibrary.Models;

public class Game
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public short PublicationYear { get; set; }
    public double Price { get; set; }
}
