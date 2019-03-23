using System;
using System.Linq;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            PrintDelimiterOfSumArray(array);
        }

        private static void PrintDelimiterOfSumArray(int[] array)
        {
            if(array.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0 ; i < array.Length; i++)
            {
                leftSum = 0;
                

                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                rightSum = 0;

                for (int k = array.Length-1; k > i; k--)
                {
                    rightSum += array[k];
                }

                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }


            }
            if (leftSum > rightSum || rightSum > leftSum)
            {
                Console.WriteLine("no");
                return;
            }
            if (leftSum == 0 && rightSum == 0)
            {
                Console.WriteLine("0");
                return;
            }
        }
    }
}
