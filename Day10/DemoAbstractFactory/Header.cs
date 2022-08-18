using System;

namespace DemoAbstractFactory
{
    public abstract class Header
    {
        public string Title { get; set; }
        public Header(string title)
        {
            Title = title;
        }
        public abstract void Print();
    }

    public class SimpleHeader : Header
    {
        public SimpleHeader(string title) : base(title)
        {
        }
        public override void Print()
        {
            Console.WriteLine("Title: {0}", Title);
        }
    }
    public class FancyHeader : Header
    {
        public FancyHeader(string title) : base(title)
        {
        }
        public override void Print()
        {
            for (int i = 0; i < Title.Length + 11; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("* Title: {0} *", Title);
            for (int i = 0; i < Title.Length + 11; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}