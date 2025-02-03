public class Rectangle : IPrinter, IFigure
{
    string Name { get => "Прямоугольник"; }
    public double Height { get; set; }
    public double Width { get; set; }

    public double GetPerimeter()
        => 2 * (Height + Width);

    public double GetSquare()
        => Height * Width;

    public void Print()
        => Console.WriteLine($"Высота: {Height}; Ширина: {Width}");

    public void ShowInfo()
        => Console.WriteLine($"Высота: {Height}; Ширина: {Width}");
}
