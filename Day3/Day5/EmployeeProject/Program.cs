using System;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee john = new FulltimeEmployee("John", 1.5);
            Employee mary = new ParttimeEmployee("Mary", 2.0, 3);         
            Freelancer paul = new Freelancer("Paul", new Contract("Secret Project", 100.0));
            paul.ProjectContract.Status = Contract.DONE;
            john.PrintInfo();
            mary.PrintInfo();
            paul.PrintInfo();
        }
    }
}
