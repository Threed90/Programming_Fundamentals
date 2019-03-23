using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            string result = "";

            for (int i = input.Length-1; i >= 0; i--)
            {
                result += input[i];
            }

            int sum = result.Split(" ").Select(int.Parse).Sum();
            
            Console.WriteLine(sum);
        }
    }
}
