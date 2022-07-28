using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class TopupStudent : Student
    {
        public string Program { get; set; }
        public TopupStudent() : base("Paul", 22)
        {        
            Program = "Topup";
            Console.WriteLine("TopupStudent default constructor");
        }

        public TopupStudent(string name, int age, string program) : base(name, age)
        {
            Program = program;
            Console.WriteLine("TopupStudent constructor with parameters");
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("Program: {0}", Program);
        }
    }
}