using System;

namespace DemoAbstractFactory
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmailFactory factory = ChooseEmailStyle();
            WriteEmail(factory);
        }

        public static void WriteEmail(EmailFactory factory)
        {
            Header header = factory.CreateHeader();
            Message message = factory.CreateMessage();
            header.Print();
            message.Print();
        }
        public static EmailFactory ChooseEmailStyle()
        {
            Console.Write("Simple email (1) or fancy email (2): ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) return new SimpleEmailFactory();
            else             return new FancyEmailFactory();
        }
    }
}
