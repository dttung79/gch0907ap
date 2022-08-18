using System;

namespace DemoSingleton
{
    public class Document
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        
        public Document(string name, int pages)
        {
            Name = name;
            Pages = pages;
        }
    }
}