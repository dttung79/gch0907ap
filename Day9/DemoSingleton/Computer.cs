using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSingleton
{
    public class Computer
    {
        public string Name { get; set; }
        public string IP { get; set; }
        private Printer spooler;

        public Computer(string name, string ip)
        {
            Name = name;
            IP = IP;
        }
        public void Print(Document doc)
        {
            if (spooler == null)
            {
                Console.WriteLine("Printer is not connected.");
                return;
            }
            spooler.Print(doc);
        }
        public bool ConnectPrinter()
        {
            Console.Write("Enter printer IP: ");
            string ip = Console.ReadLine();
            if (ip != "10.22.7.246")
            {
                Console.WriteLine("Cannot connect to {0}.", ip);
                return false;
            }
            spooler = Printer.GetSpooler();
            Console.WriteLine("Connected to printer {0} at {1}.", spooler.Name, spooler.IP);
            return true;
        }
    }
}