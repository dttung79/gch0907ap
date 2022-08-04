using System;
using DemoInterface;

namespace ShapeProject
{
    public class Rectangle : Shape, IDrawable
    {
        public void Draw()
        {
            Console.Write("+");
            for (int i = 0; i < Width; i++)
            {
                Console.Write("--");
            }
            Console.WriteLine("+");

            for (int i = 0; i < Height; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("  "); // 2 spaces
                }
                Console.WriteLine("|");
            }
            Console.Write("+");
            for (int i = 0; i < Width; i++)
            {
                Console.Write("--");
            }
            Console.WriteLine("+");
        }
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
        public override double Area()
        {
            return Width * Height;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Width: {0}, Height: {1}", Width, Height);
        }
    }
}