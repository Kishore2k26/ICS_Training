using System;

namespace Assignment_6
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
            Console.WriteLine("Book Name   : " + BookName);
            Console.WriteLine("Author Name : " + AuthorName);
            Console.WriteLine();
        }
    }

    internal class IndexerEg
    {
        private Books[] books = new Books[5];

        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        static void Main()
        {
            IndexerEg shelf = new IndexerEg();

            shelf[0] = new Books("C# Basics", "John");
            shelf[1] = new Books("ASP.NET", "Smith");
            shelf[2] = new Books("Java", "James");
            shelf[3] = new Books("Python", "Guido");
            shelf[4] = new Books("DSA", "Mark");

            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }

            Console.ReadLine();
        }
    }
}