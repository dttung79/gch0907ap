using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class Text : IDrawable
    {
        public string Content { get; set; }
        public Text(string content)
        {
            Content = content;
        }
        public void Draw()
        {
            Console.Write("+");
            for (int i = 0; i < Content.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            Console.WriteLine("|{0}|", Content);
            Console.Write("+");
            for (int i = 0; i < Content.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}