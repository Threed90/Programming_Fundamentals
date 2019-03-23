using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> numCounters = new SortedDictionary<double, int>();

            foreach (double item in numbers)
            {
                if(!numCounters.ContainsKey(item))
                {
                    numCounters.Add(item, 1);
                }
                else
                {
                    numCounters[item]++;
                }
            }

            

            foreach (KeyValuePair<double, int> pairs in numCounters)
            {
                Console.WriteLine($"{pairs.Key} -> {pairs.Value}");
            }
        }
    }
}
