public class Rectangle : IPrinter, IFigure
{
    public string Name => "Прямоугольник";
    public double Height { get; set; }
    public double Width { get; set; }

    public double GetPerimeter()
        => 2 * (Height + Width);

    public double GetSquare()
        => Height * Width;

    public void Print()
        => Console.WriteLine($"Высота: {Height}; Ширина: {Width}");

    public void ShowInfo()
        => Console.WriteLine($"{Name}; Высота: {Height}; Ширина: {Width}");
}
