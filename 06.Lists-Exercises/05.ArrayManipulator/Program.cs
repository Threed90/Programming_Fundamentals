using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();


            string[] commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    nums.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands[0] == "addMany")
                {
                    CollectionAdd(nums, commands);
                }
                else if (commands[0] == "contains")
                {
                    PrintResult(nums, commands);
                }
                else if (commands[0] == "remove")
                {
                    CollectionRemove(nums, commands);
                }
                else if (commands[0] == "shift")
                {
                    CollectionShift(nums, commands);
                }
                else if (commands[0] == "sumPairs")
                {
                    CollectionSumPairs(nums, commands);
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please write add, addMany, contains, shift or sumPairs");
                }

                commands = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }

        private static void CollectionSumPairs(List<int> nums, string[] commands)
        {
            int holder = nums.Count;
            for (int i = 1; i < holder; i += 2)
            {
                nums.Add(nums[i - 1] + nums[i]);
            }
            if (holder % 2 != 0)
            {
                nums.Add(nums[holder - 1]);
            }

            nums.RemoveRange(0, holder);
            //for (int i = 0; i < nums.Count-1; i++)
            //{
            //    nums[i] = nums[i] + nums[i + 1];
            //    nums.RemoveAt(nums[i + 1]);
            //}

        }

        private static void CollectionShift(List<int> nums, string[] commands)
        {
            for (int i = 0; i < int.Parse(commands[1])%nums.Count; i++)
            {
                int tempHolder = nums[0];
                nums.RemoveAt(0);
                nums.Add(tempHolder);
            }
        }

        private static void CollectionRemove(List<int> nums, string[] commands)
        {
            nums.RemoveAt(int.Parse(commands[1]));
        }

        private static void PrintResult(List<int> nums, string[] commands)
        {
            if (nums.Contains(int.Parse(commands[1])))
            {
                Console.WriteLine(nums.IndexOf(int.Parse(commands[1])));
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        private static void CollectionAdd(List<int> nums, string[] commands)
        {
            for (int i = 2, j = int.Parse(commands[1]); i < commands.Length; i++, j++)
            {
                nums.Insert(j, int.Parse(commands[i]));
            }
        }
    }
}
