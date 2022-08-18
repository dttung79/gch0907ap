using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSingleton
{
    public class Printer
    {
        private const int FULL_PAGES = 10000;

        public string Name { get; set; }
        public int Pages { get; set; }
        public string IP { get; set; }

        private static Printer spooler = null;

        private Printer()
        {
            Name = "HP LaserJet 6000";
            Pages = 0;
            IP = "127.0.0.1";
        }
        public static Printer GetSpooler()
        {
            if (spooler == null)
            {
                spooler = new Printer();
                spooler.Configure("HP LaserJet 6000", "10.22.7.246");
            }
            return spooler;
        }

        public void Configure(string name, string ip)
        {
            Name = name;
            IP = ip;
        }

        public void Refill()
        {
            Pages = FULL_PAGES;
        }
        public void Print(Document doc)
        {
            if (Pages == 0)
            {
                Console.WriteLine("Printer is out of paper.");
                return;
            }
            
            if (Pages < doc.Pages)
            {
                Console.WriteLine("Printer can only print {0} pages.", Pages);
                doc.Pages -= Pages;
                Pages = 0;
                return;
            }
            Pages -= doc.Pages;
            Console.WriteLine("Printing {0} pages of {1}.", doc.Pages, doc.Name);
            Console.WriteLine("Printer has {0} pages left.", Pages);

        }
    }
}