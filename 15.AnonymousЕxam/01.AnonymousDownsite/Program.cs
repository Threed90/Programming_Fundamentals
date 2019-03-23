using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());

            List<string> sites = new List<string>();

            decimal total = 0;

            for (int i = 0; i < numLines; i++)
            {
                string[] input = Console.ReadLine().Split();

                sites.Add(input[0]);

                total += (uint.Parse(input[1]) * decimal.Parse(input[2]));
            }

            Console.WriteLine(string.Join(Environment.NewLine, sites));
            Console.WriteLine($"Total Loss: {total:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(key, numLines)}");
        }
    }
}
