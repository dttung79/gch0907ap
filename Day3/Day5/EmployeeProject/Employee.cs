using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public abstract class Employee
    {
        protected static int count = 0;
        protected string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        protected const double BASIC_SALARY = 1000.0;
        
        protected int id;
        public int ID
        {
            get { return id; }
        }

        public Employee()
        {
            Name = "No name";
            id = ++count;
        }

        public Employee(string name)
        {
            Name = name;
            id = ++count;
        }

        public void PrintInfo()
        {
            Console.WriteLine("ID: {0}, name: {1}, salary: {2}", ID, Name, Salary());
        }

        public abstract double Salary();
    }
}