namespace PractWork4;

public class Game
{
    public int IdGame { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public double Price { get; set; }
    public string PriceInfo { get
        {
            if (Sale > 0)
                return $"~~{Price}~~₽ {Price * (Sale / 100)}₽";
            return $"{Price}₽";
        }
    }
    public double Sale { get; set; } = 0;
}
