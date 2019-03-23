using System;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {

        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int sumSequence = int.Parse(Console.ReadLine());

            long[] array = new long[arraySize];

            array[0] = 1;

            GetArrayValues(array, sumSequence);

            Console.WriteLine(string.Join(" ", array));
        }

        private static void GetArrayValues(long[] array, int k)
        {
            
            for (int elementsCount = 0; elementsCount < array.Length; elementsCount++)
            {
                int start = Math.Max(0, elementsCount - k);

                long sum = 0;
                
                for (int i = start; i <= elementsCount; i++)
                {
                    sum += array[i];
                }

                array[elementsCount] = sum;
            }
 
        }
    }
}
