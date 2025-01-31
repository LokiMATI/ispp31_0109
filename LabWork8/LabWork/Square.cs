using System.Threading.Channels;

public class Square : Figure
{

    public override string Name { get => "квадрат"; }
    public double Side { get; }

    public Square() : this(2)
    {
    }
    public Square(double side)
    {
        Side = side;
    }


    public override double GetPerimeter()
        => Side * 4;

    public override double GetSquare()
    => Side * Side;

    public override void ShowInfo()
        => Console.WriteLine($"У квадрата сторона равна {Side}");
}

