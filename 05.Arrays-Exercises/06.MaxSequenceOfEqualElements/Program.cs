using System;
using System.Linq;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string longestSequence = GetLongestSequence(array);

            Console.WriteLine(longestSequence.Trim());
        }

        private static string GetLongestSequence(int[] array)
        {
            int counter = 1;
            int sequenceChecker = 0;
            string sequence = "";
            string longestSequence = "";


            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] == array[i + 1])
                {
                    counter++;


                    if (sequenceChecker < counter && counter > 1)
                    {
                        sequenceChecker = counter;

                        sequence = $"{array[i]} ";

                    }


                }
                else
                {
                    counter = 1;
                }
            }
            if (counter == array.Length || sequenceChecker == 0)
            {
                sequence = $"{array[0]} ";
                sequenceChecker = counter;
            }
            for (int i = 0; i < sequenceChecker; i++)
            {
                longestSequence += sequence;
            }
            return longestSequence;
        }
    }
}
