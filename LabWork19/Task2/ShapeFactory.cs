using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
                return new Circle();

            else if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
                return new Rectangle();

            else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
                return new Square();

            else if (shapeType.Equals("PENTAGON", StringComparison.OrdinalIgnoreCase))
                return new Pentagon();

            return null;
        }
    }
}