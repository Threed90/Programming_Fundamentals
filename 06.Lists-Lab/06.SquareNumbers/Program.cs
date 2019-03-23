using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> numbers = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (Math.Sqrt(nums[i]) == (int)Math.Sqrt(nums[i]))
                {
                    numbers.Add(nums[i]);
                }
            }

            int holder = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        holder = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = holder;
                    }
                }
            }

            string result = "";

            foreach (var num in numbers)
            {
                result += num.ToString() + " ";
            }

            Console.WriteLine(result.TrimEnd());
            //numbers.Sort((a,b) => b.CompareTo(a));

            //Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
