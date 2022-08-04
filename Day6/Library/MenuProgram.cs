using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public abstract class MenuProgram
    {
        public void Run()
        {
            bool running = 0;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                running = choice == 0;         
            }
        }
        protected abstract void PrintMenu();
        protected int GetChoice()
        {
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        protected abstract void DoTask(int choice);
    }
}