using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAdapter
{
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Line : Shape
    {
        public int Length { get; set; }
        public Line()
        {
            Length = 10;
        }
        public Line(int length)
        {
            Length = length;
        }
        public override void Draw()
        {
            Console.Write("+");
            for (int i = 0; i < Length; i++)
            {
                Console.Write("--");
            }
            Console.WriteLine("+");
        }
    }
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {
            Width = 1;
            Height = 1;
        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public override void Draw()
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
    }
}