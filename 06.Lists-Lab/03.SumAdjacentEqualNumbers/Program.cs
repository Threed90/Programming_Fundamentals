using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();

            for (int i = 0; i < nums.Count-1; i++)
            {
                if (nums[i] == nums[i+1])
                {
                    decimal sum = nums[i] + nums[i + 1];
                    
                    nums.RemoveRange(i, 2);
                    nums.Insert(i, sum);

                    i = -1;
                }
            }

            

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
