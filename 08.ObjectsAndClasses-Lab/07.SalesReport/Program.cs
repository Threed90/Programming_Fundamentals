using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, decimal> saleBook = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                Sale sale = ReadSales();
                FillDict(saleBook, sale);
            }

            foreach (KeyValuePair<string,decimal> item in saleBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }

        private static void FillDict(SortedDictionary<string, decimal> saleBook, Sale sale)
        {
            if (!saleBook.ContainsKey(sale.Town))
            {
                saleBook.Add(sale.Town, sale.Total);
            }
            else
            {
                saleBook[sale.Town] += sale.Total;
            }
        }

        private static Sale ReadSales()
        {
            string[] input = Console.ReadLine().Split().ToArray();

            return new Sale(input[0], input[1], decimal.Parse(input[2]), decimal.Parse(input[3]));
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Pruduct { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public decimal Total
        {
            get
            {
                return Price * Quantity;
            }
        }

        public Sale(string town, string product, decimal price, decimal quantity)
        {
            this.Town = town;
            this.Pruduct = product;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
