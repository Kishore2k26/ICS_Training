using System;

namespace Assignment_5
{
    class Books
    {
        public string BookName;
        public string AuthorName;

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine("Book Name: " + BookName);
            Console.WriteLine("Author Name: " + AuthorName);
            Console.WriteLine();
        }
    }

    class BookShelf
    {
        private Books[] books = new Books[5];

        public Books this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }
    }

    internal class IndexerEg
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();

            shelf[0] = new Books("C# Programming", "John");
            shelf[1] = new Books("Java Basics", "James");
            shelf[2] = new Books("Python Guide", "Guido");
            shelf[3] = new Books("Data Structures", "Mark");
            shelf[4] = new Books("OOP Concepts", "Robert");

            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }

            Console.ReadLine();
        }
    }
}