using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() : base("C")
        {
            stype = "Circle";
            Radius = 1.0;
        }
        public Circle(string name, double radius) : base(name)
        {
            stype = "Circle";
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Radius: {0}", Radius);
        }
    }
}