using System;
using System.Linq;

namespace _02.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).ToArray();

            int[] result = numbers.Select(x => (numbers.Average() < x) ? x + 1 : x - 1).ToArray();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers.Average() < numbers[i])
            //    {
            //        numbers[i]++;
            //    }
            //    else if(numbers.Average()>= numbers[i])
            //    {
            //        numbers[i]--;
            //    }
            //}
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
