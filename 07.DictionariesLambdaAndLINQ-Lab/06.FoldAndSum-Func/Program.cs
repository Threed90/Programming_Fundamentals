using System;
using System.Linq;

namespace _06.FoldAndSum_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;


            int[] result = numbers.Take(k).Reverse().Concat(numbers.Reverse().Take(k)).Select((x, i) => x + numbers[k + i]).ToArray();
            

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
