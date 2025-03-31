// Задание 3
using Task3;

IShape circle = new Circle();
Console.WriteLine("Circle with normal border");
circle.Draw();

IShape redCircle = new RedShapeDecorator(new Circle());
Console.WriteLine("\nCircle of red border");
redCircle.Draw();

IShape redRectangle = new RedShapeDecorator(new Rectangle());
Console.WriteLine("\nRectangle of red border");
redRectangle.Draw();

IShape redSquare = new RedShapeDecorator(new Square());
Console.WriteLine("\nSquare of red border");
redSquare.Draw();
