using System;

namespace DemoStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student();
            john.Name = "John"; // call setter of attribute name
            john.Age = 20; // call setter of attribute age
            john.GPA = 7.5; // call setter of attribute gpa
            Console.WriteLine(john.Name); // call getter of attribute name
            Console.WriteLine(john.Age); // call getter of attribute age
            Console.WriteLine(john.GPA); // call getter of attribute gpa
            //john.PrintInfo(); // call method PrintInfo()
            john.ShowInfo();
        }
    }
}
