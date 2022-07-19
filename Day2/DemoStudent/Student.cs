using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStudent
{
    public class Student
    {
        private string name;
        private int age;
        private double gpa;
        
        public string Name
        {
            get { return name; }
            set 
            { 
                if (value == "") Console.WriteLine("....");
                else name = value; 
            }
        }
        public Student()
        {
            name = "John";
            age = 20;
            gpa = 3.5;
        }
        public Student(string name, int age, double gpa)
        {
            this.name = name;
            this.age = age;
            this.gpa = gpa;
        }
    }
}