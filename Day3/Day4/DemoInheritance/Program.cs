using System;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student s = new Student();
            // s.Print();

            TopupStudent ts = new TopupStudent("Paul", 22, "Topup");
            ts.Print();
        }
    }
}
