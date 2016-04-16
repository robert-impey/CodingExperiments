using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace BookFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>
            {
                new Book ("War and Peace", 1123, Colour.Red),
                new Book ("Doctor Zhivago", 803, Colour.Blue),
                new Book ("Jeeves and the Feudal Spirit", 154, Colour.Red),
                new Book ("Shogun", 1213, Colour.Red)
            };

            PrintRedBooksWithMoreThan500PagesImperative(books);
            PrintRedBooksWithMoreThan500PagesFluent(books);
            PrintRedBooksWithMoreThan500PagesQuery(books);
        }

        private static void PrintRedBooksWithMoreThan500PagesImperative(IList<Book> books)
        {
            WriteLine("Finding the books in the imperative style");

            foreach (var book in books)
            {
                if (book.Colour == Colour.Red && book.NumberOfPages > 500)
                {
                    WriteLine(book.Name);
                }
            }
        }

        private static void PrintRedBooksWithMoreThan500PagesFluent(IList<Book> books)
        {
            WriteLine("Finding the books with fluent linq");

            var longRedBooks = books.Where(b => b.Colour == Colour.Red && b.NumberOfPages > 500);

            foreach (var longRedBook in longRedBooks)
            {
                WriteLine(longRedBook.Name);
            }
        }

        private static void PrintRedBooksWithMoreThan500PagesQuery(IList<Book> books)
        {
            WriteLine("Finding the books with a linq query");

            var longRedBooks = from book in books
                               where book.Colour == Colour.Red && book.NumberOfPages > 500
                               select book;

            foreach (var longRedBook in longRedBooks)
            {
                WriteLine(longRedBook.Name);
            }
        }
    }
}
