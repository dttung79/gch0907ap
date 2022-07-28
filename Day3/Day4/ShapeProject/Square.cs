using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Square : Rectangle
    {
        public Square() : base("ABCD", 1.0, 1.0)
        {
            stype = "Square";
        }
        public Square(string name, double side) : base(name, side, side)
        {
            stype = "Square";
        }
    }
}