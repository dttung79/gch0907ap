using System;
using System.Collections.Generic;

namespace MobileShop
{
    class Program
    {
        static Shop shop;
        static ProductWarehouse warehouse = new ProductWarehouse();
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();
                int option = GetChoice();
                DoTask(option);
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("1. Warehouse");
            Console.WriteLine("2. Shop");
        }
        static int GetChoice()
        {
            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        static void DoTask(int option)
        {
            switch (option)
            {
                case 2: 
                    shop = new Shop(products);
                    shop.Run(); 
                    break;
                case 1: 
                    warehouse.Run();
                    products = warehouse.Products;
                    break;
                default: 
                    Console.WriteLine("Invalid option!"); 
                    break;
            }
        }
    }
}
