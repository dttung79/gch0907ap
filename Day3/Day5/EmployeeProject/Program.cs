using System;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee john = new FulltimeEmployee("John", 1.5);
            Employee noName = new FulltimeEmployee();           
            Employee paul = new FulltimeEmployee("Paul", 2.0);

            john.PrintInfo();
            noName.PrintInfo();
            paul.PrintInfo();
        }
    }
}
