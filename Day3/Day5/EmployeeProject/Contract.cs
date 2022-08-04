using System;

namespace EmployeeProject
{
    public class Contract
    {
        public const bool DONE = true;
        public const bool NOT_DONE = false;

        public string Project { get; set; }
        public double Budget { get; set; }
        public bool Status { get; set; }

        public Contract()
        {
            Project = "Unknown";
            Budget = 0;
            Status = NOT_DONE;
        }
        public Contract(string project, double budget)
        {
            Project = project;
            Budget = budget;
            Status = NOT_DONE;
        }
    }
}