using System;
using System.Collections.Generic;

namespace MobileShop
{
    public class ProductWarehouse
    {
        private const int ADD_PRODUCT = 1;
        private const int DEL_PRODUCT = 2;
        private const int EDIT_PRODUCT = 3;
        private const int SEARCH_PRODUCT = 4;
        private const int EXIT = 0;

        private List<Product> products;
        public List<Product> Products
        {
            get { return products; }
        }
        
        public ProductWarehouse()
        {
            products = new List<Product>();
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int option = GetMenuOption();
                DoTask(option);
                running = option != EXIT;
            }
        }
        private void PrintMenu()
        {
            Console.WriteLine("FPT Shop Warehouse");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. Edit product");
            Console.WriteLine("4. Search products");
            Console.WriteLine("0. Exit");
        }
        private int GetMenuOption()
        {
            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        private void DoTask(int option)
        {
            switch (option)
            {
                case ADD_PRODUCT   : AddProduct   (); break;
                case DEL_PRODUCT   : DeleteProduct(); break;
                case EDIT_PRODUCT  : EditProduct  (); break;
                case SEARCH_PRODUCT: SearchProduct(); break;
                case EXIT          : Exit         (); break;
                default: Console.WriteLine("Invalid option!"); break;
            }
        }
        private void AddProduct()
        {
            Console.Write("Enter number of products: ");
            int nProducts = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nProducts; i++)
            {
                Console.Write("Enter product name: ");
                string name = Console.ReadLine();
                Console.Write("Enter product color: ");
                string color = Console.ReadLine();
                Console.Write("Enter product price: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter product RAM (Gb): ");
                int ram = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter product storage (Gb): ");
                int storage = Convert.ToInt32(Console.ReadLine());
                Product p = new Product(name, color, price, ram, storage);
                products.Add(p);
            }
        }
        private void DeleteProduct()
        {
            Console.Write("Enter product id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            products.RemoveAt(id);
            Console.WriteLine("Product removed!");
        }
        private void EditProduct()
        {
            Console.Write("Enter product id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            products[id].Price = price;
            Console.WriteLine("Product price updated!");
        }
        private void SearchProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            bool found = false;
            foreach (Product p in products)
            {
                if (p.Name.Contains(name))
                {
                    int id = products.IndexOf(p);
                    Console.WriteLine("Product id: {0}", id);
                    p.PrintInfo();
                    found = true;
                }
            }
            if (!found) Console.WriteLine("Product not found!");
        }
        private void Exit()
        {
            Console.WriteLine("Bye!");
        }
    }
}