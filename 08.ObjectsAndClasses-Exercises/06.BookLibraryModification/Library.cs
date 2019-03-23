using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public DateTime StartDate { get; set; }

        public Library(string name, List<Book> books, DateTime startDate)
        {
            this.Name = name;
            this.Books = books;
            this.StartDate = startDate;
        }

        public override string ToString()
        {
            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();
            foreach (Book item in Books)
            {
                if (!result.ContainsKey(item.Title) && item.ReleaseDate > StartDate)
                {
                    result.Add(item.Title, item.ReleaseDate);
                }
            }
            string final = string.Join(Environment.NewLine,
                           result.OrderBy(x => x.Value).ThenBy(x => x.Key)
                           .Select(x => new string($"{x.Key} -> {x.Value.ToString("dd.MM.yyyy")}".ToCharArray())).ToArray());
            return final;
        }
    }
}
