using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTemplateMethod
{
    public abstract class RecruitmentProcess
    {
        public bool Recruit(Applicant a)
        {
            if (!CVFilter(a))  return false;
            if (!Test(a))      return false;
            if (!Interview(a)) return false;
            return true;
        }
        protected bool CVFilter(Applicant a)
        {
            if (a.Ielts < 5.0 || a.GPA < 2.5)
            {
                Console.WriteLine("{0}'s CV is not qualified. Wish you luck next time.", a.Name);
                return false;
            }
            Console.WriteLine("{0}'s CV is qualified.", a.Name);
            return true;
        }
        protected abstract bool Test(Applicant a);
        protected bool Interview(Applicant a)
        {
            string [] questions = { "Do you like company? ", "Do you like low salary? ", "Do you like team work? " };
            string [] answers = { "Yes", "Yes", "Yes" };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.Write(questions[i]);
                string answer = Console.ReadLine();
                if (answer != answers[i])
                {
                    Console.WriteLine("{0}'s interview is not qualified. Wish you luck next time.", a.Name);
                    return false;
                }
            }
            Console.WriteLine("{0}'s interview is qualified.", a.Name);
            return true;
        }
    }

    public class DevRecruitment : RecruitmentProcess
    {
        protected override bool Test(Applicant a)
        {
            Console.WriteLine("Code a small program ...");
            Console.Write("Have you passed the test? ");

            return Console.ReadLine() == "Yes";
        }
    }

    public class AccountantRecruitment : RecruitmentProcess
    {
        protected override bool Test(Applicant a)
        {
            Console.WriteLine("Fill in main book of company financial report ...");
            Console.Write("Have you passed the test? ");

            return Console.ReadLine() == "Yes";
        }
    }
    public class SaleRecruitment : RecruitmentProcess
    {
        protected override bool Test(Applicant a)
        {
            Console.WriteLine("Sell a product ...");
            Console.Write("Have you passed the test? ");

            return Console.ReadLine() == "Yes";
        }
    }
}