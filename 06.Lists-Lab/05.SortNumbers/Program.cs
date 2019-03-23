using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));

            //double holder = 0;

            //for (int i = 0; i < numbers.Count-1; i++)
            //{
            //    for (int j = i+1; j < numbers.Count; j++)
            //    {
            //        if (numbers[i] > numbers[j])
            //        {
            //            holder = numbers[i];
            //            numbers[i] = numbers[j];
            //            numbers[j] = holder;
            //        }
            //    }
            //}

            //string result = "";

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    result += $"{numbers[i]} <= ";
            //}

            //Console.WriteLine(result.TrimEnd(' ', '<', '='));
        }
    }
}
