using System;

namespace ShapeProject
{
    public class Shape
    {
        protected string stype;
        public string SType
        {
            get { return stype; }
        }
        public string Name { get; set; }

        public Shape()
        {
            stype = "Generic Shape";
            Name = "S";
        }
        public Shape(string name)
        {
            stype = "Generic Shape";
            Name = name;
        }
        public double Area()
        {
            return 0.0;
        }
        public void Print()
        {
            Console.WriteLine("{0} {1}", SType, Name);
        }
    }
}