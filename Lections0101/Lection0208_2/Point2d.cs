struct Point2d
{
    public int X;
    public int Y;

    public Point2d(int n) : this(n, n)
    {
    }

    public Point2d(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
        => $"x={X} y={Y}";
}
