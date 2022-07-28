using System;

namespace ShapeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square("ABCD", 5.0);
            sq.Print();
            Console.WriteLine("Area: {0}", sq.Area());
        }
    }
}
