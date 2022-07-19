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
                if (value == "") Console.WriteLine("Invalid name");
                else name = value; 
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) Console.WriteLine("Invalid age");
                else age = value;
            }
        }
        public double GPA
        {
            get { return gpa; }
            set
            {
                if (value < 0 || value > 10) Console.WriteLine("Invalid GPA");
                else gpa = value;
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

        // normal methods
        private void PrintInfo()
        {
            Console.WriteLine("Student Name: {0}, Age: {1}, GPA: {2}", name, age, gpa);
        }
        public void ShowInfo()
        {
            PrintInfo();
        }
    }
}