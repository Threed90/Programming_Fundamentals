using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rotateAction = int.Parse(Console.ReadLine());

            int[] arraySum = GetSumOfArray(array, rotateAction).Clone() as int[];

            Console.WriteLine(string.Join(" ", arraySum));
        }
        /// <summary>
        /// Rotate array's first element with array's last element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="rotateAction"></param>
        /// <returns></returns>
        private static int[] GetSumOfArray(int[] array, int rotateAction)
        {
            int[] sum = new int[array.Length];
            int[] secondArray = new int[array.Length];
            
            for (int i = 0; i < rotateAction; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    secondArray[j] = array[j - 1];
                }
                secondArray[0] = array[array.Length - 1];

                array = secondArray.Clone() as int[]; // secondArray.CopyTo(array, 0) --> where 0 is index of begin

                for (int j = 0; j < array.Length; j++)
                {
                    sum[j] += secondArray[j];
                }
            }

            return sum;
        }
    }
}
