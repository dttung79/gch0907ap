using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAdapter
{
    public class FancyText
    {
        public char Decor { get; set; }
        public string Content { get; set; }
        public FancyText()
        {
            Decor = '*';
            Content = "Hello World";
        }
        public FancyText(char decor, string content)
        {
            Decor = decor;
            Content = content;
        }
        public void Display()
        {
            Console.Write(Decor);
            for (int i = 0; i < Content.Length + 2; i++)
            {
                Console.Write(Decor);
            }
            Console.WriteLine(Decor);
            Console.WriteLine("{0} {1} {2}", Decor, Content, Decor);
            Console.Write(Decor);
            for (int i = 0; i < Content.Length + 2; i++)
            {
                Console.Write(Decor);
            }
            Console.WriteLine(Decor);
        }
    }
}