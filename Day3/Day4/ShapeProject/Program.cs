using System;
using System.Collections.Generic;

namespace ShapeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("C1", 1.0));
            shapes.Add(new Rectangle("ABCD", 2.0, 4.0));
            shapes.Add(new Square("MNPQ", 3.0));

            foreach (Shape s in shapes)
            {
                s.Print();
                Console.WriteLine("Area: {0}", s.Area());
            }
        }
    }
}
