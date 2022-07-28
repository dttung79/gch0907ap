using System;

namespace DemoInheritance
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {
            Name = "John";
            Age = 20;
            Console.WriteLine("Student default constructor");
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Student constructor with parameters");
        }
        public void Print()
        {
            Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
        }
    }
}