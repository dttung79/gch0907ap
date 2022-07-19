using System;

namespace DemoStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student();
            Console.WriteLine(john.GetName());
            //Console.WriteLine(john.age);
            //Console.WriteLine(john.gpa);

            Student paul = new Student("Paul", 20, 3.5);
            paul.SetName("");
            // paul.age = -21;
            // paul.gpa = -3.5;
            Console.WriteLine(paul.GetName());
            // Console.WriteLine(paul.age);
            // Console.WriteLine(paul.gpa);
        }
    }
}
