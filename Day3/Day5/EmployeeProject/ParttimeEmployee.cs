using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class ParttimeEmployee : FulltimeEmployee
    {
        private const int MAX_DAYS = 5;
        private int dow;
        public int DOW
        {
            get { return dow; }
            set 
            { 
                dow = value; 
                if (dow < 1 || dow > MAX_DAYS)
                {
                    Console.WriteLine("DOW must be between 1 and 5");
                    dow = 1;
                }
            }
        }
        // default constructor
        public ParttimeEmployee()
        {
            DOW = 2;
        }
        // constructor with parameters
        public ParttimeEmployee(string name, double rate, int dow) : base(name, rate)
        {
            DOW = dow;
        }
        public override double Salary()
        {
            return BASIC_SALARY / MAX_DAYS * DOW;
        }
    }
}