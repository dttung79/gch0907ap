using System;

namespace DemoAbstractFactory
{
    public abstract class Message
    {
        public string Content { get; set; }
        public Message(string content)
        {
            Content = content;
        }
        public abstract void Print();
    }
    public class SimpleMessage : Message
    {
        public SimpleMessage(string content) : base(content)
        {
        }
        public override void Print()
        {
            Console.WriteLine("Message:");
            Console.WriteLine(Content);
        }
    }
    public class FancyMessage : Message
    {
        public FancyMessage(string content) : base(content)
        {
        }
        public override void Print()
        {
            for (int i = 0; i < Content.Length + 13; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
            Console.WriteLine("+ Message: {0} +", Content);
            for (int i = 0; i < Content.Length + 13; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
        }
    }
}