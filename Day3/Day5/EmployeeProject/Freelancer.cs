using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class Freelancer : Employee
    {
        private Contract contract;
        public Contract ProjectContract
        {
            get { return contract; }
            set { contract = value; }
        }

        public Freelancer()
        {
            contract = new Contract();
        }
        public Freelancer(string name, Contract contract) : base(name)
        {
            ProjectContract = contract;
        }

        public override double Salary()
        {
            if (contract.Status == Contract.DONE)
            {
                return contract.Budget;
            }
            return 0.0;
            //return contract.Status == Contract.DONE ? contract.Budget : 0.0;
        }

    }
}