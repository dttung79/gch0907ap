using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() : base("R")
        {
            stype = "Rectangle";
            Width = 1.0;
            Height = 1.0;
        }
        public Rectangle(string name, double width, double height) : base(name)
        {
            stype = "Rectangle";
            Width = width;
            Height = height;
        }
        public new double Area()
        {
            return Width * Height;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Width: {0}, Height: {1}", Width, Height);
        }
    }
}