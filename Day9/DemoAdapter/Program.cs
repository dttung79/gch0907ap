using System;
using System.Collections.Generic;

namespace DemoAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Line(10));
            shapes.Add(new Rectangle(2, 10));
            shapes.Add(new TextShape('^', "Advanced Programming"));

            foreach (Shape s in shapes)
            {
                s.Draw();
            }
        }
    }
}
