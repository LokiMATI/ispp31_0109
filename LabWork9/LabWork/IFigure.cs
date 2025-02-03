public interface IFigure
{
    string Name { get => "фигура"; }
    double GetSquare();
    double GetPerimeter();
    void ShowInfo();
}
