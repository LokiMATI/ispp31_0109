namespace Task3
{
    public class Circle : IShape
    {
        public void Draw()
            => Console.WriteLine("Shape: Circle");
    }

    public class Rectangle : IShape
    {
        public void Draw()
            => Console.WriteLine("Shape: Rectangle");
    }

    public class Square : IShape
    {
        public void Draw()
            => Console.WriteLine("Shape: Square");
    }
}