using System;
using System.Linq;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (array.Length > 3)
            {
            int[] result = GetResult(array);

            Console.WriteLine(string.Join(" ", result));
            }
            

        }

        private static int[] GetResult(int[] array)
        {
            int k = (array.Length / 2) / 2;

            int[] firstArray = new int[array.Length / 2];

            for (int i = 0; i < k; i++)
            {
                firstArray[i] = array[k - 1 - i];
                
            }
            
            for (int i = firstArray.Length-1, j = k; i >= firstArray.Length - k; i--, j--)
            {
                firstArray[i] = array[array.Length - j];
            }

            int[] secondArray = new int[array.Length / 2];

            for (int i = k, j =0; i <= array.Length/2 + k-1; i++, j++)
            {
                secondArray[j] = array[i];
            }

            int[] sum = new int[array.Length / 2];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstArray[i] + secondArray[i];
            }

            return sum;
        }
    }
}
