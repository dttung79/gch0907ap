using System;

namespace DemoTemplateMethod
{
    public class Applicant
    {
        public string Name { get; set; }
        public double Ielts { get; set; }
        public double GPA { get; set; }
        public Applicant(string name, double ielts, double gpa)
        {
            Name = name;
            Ielts = ielts;
            GPA = gpa;
        }
    }
}