using System;
using System.Linq;

namespace _08.MostFrequentNumber
{
    class Program
    {
        const bool v = true;

        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int sequnceNumber = GetFrequentNumber(array);

            Console.WriteLine(sequnceNumber);
        }

        private static int GetFrequentNumber(int[] array)
        {
            bool[] isAlreadyChecked = new bool[array.Length];

            Array.Fill(isAlreadyChecked, true);

            int counter = 0;

            int sequenceChecker = 0;

            int number = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && isAlreadyChecked[j])
                    {
                        counter++;
                        isAlreadyChecked[j] = false;

                        if (sequenceChecker < counter)
                        {
                            sequenceChecker = counter;

                            number = array[i];
                        }
                    }
                }

                counter = 0;
            }

            return number;


        }
    }
}
