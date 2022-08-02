using System;

namespace EmployeeProject
{
    public class FulltimeEmployee : Employee
    {
        protected double rate;
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public FulltimeEmployee() : base()
        {
            Rate = 1.0;
        }

        public FulltimeEmployee(string name, double rate) : base(name)
        {
            Rate = rate;
        }

        public override double Salary()
        {
            return BASIC_SALARY * Rate;
        }
    }
}