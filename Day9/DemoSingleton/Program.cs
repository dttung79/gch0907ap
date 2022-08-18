using System;

namespace DemoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer spooler = Printer.GetSpooler();

            Computer comp01 = new Computer("Comp01", "10.22.7.100");
            Document asm = new Document("ASM1.docx", 100);
            comp01.Print(asm);

            // connect printer
            comp01.ConnectPrinter();
            comp01.Print(asm);

            // refill printer
            spooler.Refill();
            comp01.Print(asm);

            Computer lap02 = new Computer("Lap02", "10.22.7.101");
            Document csharp = new Document("CSharp1.pdf", 10000);
            lap02.ConnectPrinter();
            lap02.Print(csharp);
        }
    }
}
