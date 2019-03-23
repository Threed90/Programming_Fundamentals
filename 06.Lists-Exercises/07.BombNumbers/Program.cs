using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            
            while (nums.Contains(bomb[0]))
            {
                int index = nums.IndexOf(bomb[0]);
                int startIndex = index - bomb[1];
                int iterator = bomb[1]*2+1;

                if (startIndex < 0)
                {
                    iterator -= startIndex*(-1);
                    startIndex = 0;
                }
                if (index+bomb[1] > nums.Count - 1)
                {
                    iterator = nums.Count - startIndex;
                }

                for (int i = 0; i < iterator; i++)
                {
                    nums.RemoveAt(startIndex);
                }
                
            }
            
            Console.WriteLine(nums.Sum());
        }
    }
}
