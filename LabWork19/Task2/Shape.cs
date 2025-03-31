using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Circle : IShape
    {
        public void Draw() 
            => Console.WriteLine("Inside Circle::draw() method.");
    }

    public class Square : IShape
    {
        public void Draw()
            => Console.WriteLine("Inside Square::draw() method.");
    }

    public class Rectangle : IShape
    {
        public void Draw() 
            => Console.WriteLine("Inside Rectangle::draw() method.");
    }

    public class Pentagon : IShape
    {
        public void Draw()
            => Console.WriteLine("Inside Pentagon::draw() method.");
    }
}