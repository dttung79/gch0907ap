using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Reader
    {
        // static count
        private static int count = 0;
        // id
        public int ID
        {
            get { return id; }
        }
        private int id;
        // name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected List<Book> books;
        public List<Book> Books
        {
            get { return books; }
        }
        // constructor with parameters
        public Reader(string name)
        {
            this.name = name;
            books = new List<Book>();
            id = ++count;
        }
        // add book to reader
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        // return reader's books
        public List<Book> ReturnBooks()
        {
            // print all borrowed books with all info
            foreach (Book book in books)
            {
                Console.WriteLine(book.Name + " " + book.Pages + " " + book.Price);
            }
            books.Clear();
        }
        // abstract pay
        public abstract int Pay();
    }

    public class Student : Reader
    {
        // constructor with parameters
        public Student(string name) : base(name)
        {
        }
        // pay
        public override int Pay()
        {
            int total = 0;
            foreach (Book book in books)
            {
                total += book.Price;
            }
            return total;
        }
    }
    public class Teacher : Reader
    {
        // constructor with parameters
        public Teacher(string name) : base(name)
        {
        }
        // pay
        public override int Pay()
        {
            return 0;
        }
    }
}