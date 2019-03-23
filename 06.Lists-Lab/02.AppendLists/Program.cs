using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

            List<int> numbers = new List<int>();

            foreach (string num in nums)
            {
                numbers.AddRange(num.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
