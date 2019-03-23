using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x >= 0).Reverse().ToList();

            //string result = "";

            //for (int i = nums.Count - 1; i >= 0; i--)
            //{
            //    if(nums[i]>=0)
            //    {
            //        result += nums[i] + " ";
            //    }
            //}

            //if(result == string.Empty)
            //{
            //    Console.WriteLine("empty");
            //}
            //else
            //{
            //    Console.WriteLine(result.TrimEnd());
            //}
            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
