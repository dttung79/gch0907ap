using System;

namespace MobileShop
{
    public class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // short declaration
        public string Color { get; set; }
        public int Price { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }

        // default constructor
        public Product()
        {
            Name = "Iphone";
            Color = "Silver";
            Price = 1500;
            RAM = 8;
            Storage = 64;
        }
        // constructor with parameters
        public Product(string name, string color, int price, int ram, int storage)
        {
            Name = name;
            Color = color;
            Price = price;
            RAM = ram;
            Storage = storage;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Product info:");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("RAM: {0}", RAM);
            Console.WriteLine("Storage: {0}", Storage);
        }
    }
}