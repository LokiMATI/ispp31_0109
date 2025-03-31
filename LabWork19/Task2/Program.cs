// Задание 2
using Task2;

ShapeFactory shapeFactory = new ShapeFactory();

IShape shape = shapeFactory.GetShape("CIRCLE");
shape.Draw();

shape = shapeFactory.GetShape("RECTANGLE");
shape.Draw();

shape = shapeFactory.GetShape("SQUARE");
shape.Draw();

shape = shapeFactory.GetShape("PENTAGON");
shape.Draw();