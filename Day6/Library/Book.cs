using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        // price
        public int Price { get; set; }
        public int ID 
        {
            get { return id; }
        }
        private int id;
        private static int count = 0;
        // default cosntructor
        public Book()
        {
            Name = "";
            Pages = 0;
            Price = 0;
            id = ++count;
        }
        // constructor with parameters
        public Book(string name, int pages, int price)
        {
            Name = name;
            Pages = pages;
            Price = price;
            id = ++count;
        }
    }
}