using System;
using System.Collections.Generic;

namespace MobileShop
{
    public class Shop
    {
        private List<Product> products;
        public Shop()
        {
            products = new List<Product>();
            products.Add(new Product("Iphone 14", "Silver", 1500, 8, 64));
            products.Add(new Product("Galaxy 22", "Gold", 1400, 8, 128));
            products.Add(new Product("Xiami Note 12", "Black", 1000, 16, 256));
        }
        private void PrintMenu()
        {
            Console.WriteLine("FPT Shop");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, products[i].Name);
            }
            // another way to print menu
            // foreach (Product p in products)
            // {
            //     Console.WriteLine("{0}. {1}", products.IndexOf(p) + 1, p.Name);
            // }
        }
        private int ChooseProduct()
        {
            bool invalidProduct = true;
            int choice = 0;
            while (invalidProduct)
            {
                Console.Write("Choose product to buy: ");
                choice = Convert.ToInt32(Console.ReadLine());
                invalidProduct = choice < 1 || choice > products.Count;
                if (invalidProduct)
                {
                    Console.WriteLine("Invalid choice! Please choose again!");
                }
            }
            return choice;
        }
        private void PrintProductInfo(int pid)
        {
            Console.WriteLine("Product info:");
            Console.WriteLine("Name: {0}", products[pid].Name);
            Console.WriteLine("Color: {0}", products[pid].Color);
            Console.WriteLine("Price: {0}", products[pid].Price);
            Console.WriteLine("RAM: {0}", products[pid].RAM);
            Console.WriteLine("Storage: {0}", products[pid].Storage);
        }
        private void SellProduct(int pid)
        {
            int nProducts = 0;
            bool invalidQuantity = true;
            while (invalidQuantity)
            {
                Console.Write("How many products do you want to buy? ");
                nProducts = Convert.ToInt32(Console.ReadLine());
                invalidQuantity = nProducts < 1 || nProducts > 5;
                if (invalidQuantity)
                {
                    Console.WriteLine("Invalid quantity! Please choose again!");
                }
            }
            int payment = products[pid].Price * nProducts;
            Console.WriteLine("Payment: {0}", payment);
        }
        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = ChooseProduct();
                PrintProductInfo(choice - 1);
                SellProduct(choice - 1);
            }
        }
    }
}