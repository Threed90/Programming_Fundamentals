using System;
using System.Linq;

namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            PrintSequence(array);
        }

        private static void PrintSequence(int[] array)
        {
            int counter = 1;
            int sequenceChecker = 0;
            int start = 0;
            int end = 0;
            string sequnce = "";

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + 1 <= array[i + 1])
                {
                    counter++;

                    if (sequenceChecker < counter && counter > 1)
                    {
                        sequenceChecker = counter;

                        start = i - counter + 2;
                        end = start + counter;

                        if (sequenceChecker == array.Length)
                        {
                            Console.WriteLine(string.Join(" ", array).Trim());
                            return;
                        }
                    }
                }
                else
                {
                    counter = 1;
                }
                

            }
            
            if (sequenceChecker == 0)
            {
                Console.WriteLine(array[0]);
            }
            else
            {
               
                for (int i = start; i < end; i++)
                {
                     sequnce += $"{array[i]} ";
                }
                Console.WriteLine(sequnce.Trim());
            }
        }
    }
}
