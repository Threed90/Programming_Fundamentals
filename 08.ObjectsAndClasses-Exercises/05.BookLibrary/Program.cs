using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int iteration = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();

            Library library = new Library("Library", books);

            for (int i = 0; i < iteration; i++)
            {
                books.Add(ReadBook());
            }

            Console.WriteLine(library);
        }

        private static Book ReadBook()
        {
            string[] input = Console.ReadLine().Split().ToArray();

            return new Book(input[0], input[1], input[2],
                            DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                            input[4], double.Parse(input[5]));
        }
    }
}
