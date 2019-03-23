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

        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.Books = books;
        }

        public override string ToString()
        {
            Dictionary<string, double> result = new Dictionary<string, double>();
            foreach (Book item in Books)
            {
                if(!result.ContainsKey(item.Author))
                {
                    result.Add(item.Author, item.Price);
                }
                else
                {
                    result[item.Author] += item.Price;
                }
            }
            string final = string.Join(Environment.NewLine, 
                           result.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                           .Select(x => new string($"{x.Key} -> {x.Value:f2}".ToCharArray())).ToArray());
            return final;
        }
    }
}
