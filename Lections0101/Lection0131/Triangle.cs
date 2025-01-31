public class Triangle : Figure
{
    public int SideA {  get; set; }
    public int SideB {  get; set; }
    public int SideC {  get; set; }
    public override string Name { get => "треугольник"; }

    public override int GetPerimeter()
        => SideA + SideB + SideC;
}
