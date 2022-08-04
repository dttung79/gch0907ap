using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryManager : MenuProgram
    {
        private List<Book> books;
        private List<Reader> readers;

        public LibraryManager()
        {
            books = new List<Book>();
            readers = new List<Reader>();
        }
        protected override void PrintMenu()
        {
            // add book, add reader, borrow books, return books
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Add reader");
            Console.WriteLine("3. Borrow books");
            Console.WriteLine("4. Return books");
            Console.WriteLine("0. Exit");
        }
        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddBook(); break;
                case 2: AddReader(); break;
                case 3: BorrowBooks(); break;
                case 4: ReturnBooks(); break;
                case 0: break;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
        private void AddBook()
        {
            Console.Write("Enter book name: ");
            string name = Console.ReadLine();
            Console.Write("Enter book pages: ");
            int pages = int.Parse(Console.ReadLine());
            Console.Write("Enter book price: ");
            int price = int.Parse(Console.ReadLine());
            Book book = new Book(name, pages, price);
            books.Add(book);
        }
        private void AddReader()
        {
            Console.Write("Enter reader name: ");
            string name = Console.ReadLine();
            Reader reader = new Reader(name);
            readers.Add(reader);
        }
        private void BorrowBooks()
        {
            Console.Write("Enter reader ID: ");
            int id = int.Parse(Console.ReadLine());
            Reader reader = FindReaderByID(id);
            if (reader == null)
            {
                Console.WriteLine("Reader not found");
                return;
            }
            Console.Write("Enter book ID: ");
            int bookId = int.Parse(Console.ReadLine());
            Book book = FindBookByID(id);
            if (book == null)
            {
                Console.WriteLine("Book not found");
                return;
            }
            reader.AddBook(book);
        }
        private void ReturnBooks()
        {
            Console.Write("Enter reader ID: ");
            int id = int.Parse(Console.ReadLine());
            Reader reader = FindReaderByID(id);
            if (reader == null)
            {
                Console.WriteLine("Reader not found");
                return;
            }
            int payment = reader.Pay();
            Console.WriteLine("Payment: " + payment);
            reader.ReturnBooks();
            Console.WriteLine("Books returned");
        }
        private Reader FindReaderByID(int id)
        {
            foreach (Reader reader in readers)
            {
                if (reader.ID == id)
                {
                    return reader;
                }
            }
            return null;
        }
        private Book FindBookByID(int id)
        {
            foreach (Book book in books)
            {
                if (book.ID == id)
                {
                    return book;
                }
            }
            return null;
        }
    }
}