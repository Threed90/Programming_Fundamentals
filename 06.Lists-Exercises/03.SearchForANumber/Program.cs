using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] actions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < actions[0]; i++)
            {
                result.Add(nums[i]);
            }

            for (int i = 0; i < actions[1]; i++)
            {
                result.RemoveAt(0);
            }

            //nums.RemoveRange(actions[0],nums.Count-1-actions[0]);
            //nums.RemoveRange(0, actions[1]);

            if (result.Contains(actions[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}