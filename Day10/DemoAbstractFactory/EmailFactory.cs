using System;

namespace DemoAbstractFactory
{
    public abstract class EmailFactory
    {
        public abstract Header CreateHeader();
        public abstract Message CreateMessage();
    }

    public class SimpleEmailFactory : EmailFactory
    {
        public override Header CreateHeader()
        {
            Console.Write("Enter email title: ");
            string title = Console.ReadLine();
            return new SimpleHeader(title);
        }
        public override Message CreateMessage()
        {
            Console.Write("Enter email content: ");
            string content = Console.ReadLine();
            return new SimpleMessage(content);
        }
    }
    public class FancyEmailFactory : EmailFactory
    {
        public override Header CreateHeader()
        {
            Console.Write("Enter email title: ");
            string title = Console.ReadLine();
            return new FancyHeader(title);
        }
        public override Message CreateMessage()
        {
            Console.Write("Enter email content: ");
            string content = Console.ReadLine();
            return new FancyMessage(content);
        }
    }
}