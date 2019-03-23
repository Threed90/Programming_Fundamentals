using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, System.Collections.Generic.List<double>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if(input[0] == "stocked")
                {
                    break;
                }

                if (!products.ContainsKey(input[0]))
                {
                    products.Add(input[0], new List<double>());
                    products[input[0]].Add(double.Parse(input[1]));
                    products[input[0]].Add(double.Parse(input[2]));
                }
                else
                {
                    products[input[0]][0] = double.Parse(input[1]);
                    products[input[0]][1] += double.Parse(input[2]);
                }
            }
            double total = 0;
            foreach (KeyValuePair<string,List<double>> productValues in products)
            {
                total += (productValues.Value[0] * productValues.Value[1]);
                Console.WriteLine($"{productValues.Key}: ${productValues.Value[0]:f2} * {productValues.Value[1]} = ${productValues.Value[0]* productValues.Value[1]:f2}");
            }
            Console.WriteLine(new string('-', 30));

            Console.WriteLine($"Grand Total: ${total:f2}");
        }
    }
}
