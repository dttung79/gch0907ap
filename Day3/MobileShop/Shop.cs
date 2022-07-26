using System;
using System.Collections.Generic;

namespace MobileShop
{
    public class Shop
    {
        private List<Product> products;
        public Shop(List<Product> products)
        {
            this.products = products;
        }
        private void PrintMenu()
        {
            Console.WriteLine("FPT Shop");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, products[i].Name);
            }
            Console.WriteLine("0. Exit");
        }
        private int ChooseProduct()
        {
            bool invalidProduct = true;
            int choice = 0;
            while (invalidProduct)
            {
                Console.Write("Choose product to buy: ");
                choice = Convert.ToInt32(Console.ReadLine());
                invalidProduct = choice < 0 || choice > products.Count;
                if (invalidProduct)
                {
                    Console.WriteLine("Invalid choice! Please choose again!");
                }
            }
            return choice;
        }
        private void PrintProductInfo(int pid)
        {
            products[pid].PrintInfo();
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
                if (choice == 0) break;
                
                PrintProductInfo(choice - 1);
                SellProduct(choice - 1);
            }
        }
    }
}