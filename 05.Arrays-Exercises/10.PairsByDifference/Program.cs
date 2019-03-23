using System;
using System.Linq;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int diffrence = int.Parse(Console.ReadLine());

            int sequnce = GetSequncesNumber(array, diffrence);

            Console.WriteLine(sequnce);
        }

        private static int GetSequncesNumber(int[] array, int diffrence)
        {
            int counter = 0;
            //bool[] isPassedNumber = new bool[array.Length];
            
            //Array.Fill(isPassedNumber, true);

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]-array[j] == diffrence || array[i] - array[j] == diffrence*(-1))//&& isPassedNumber[j]) //&& i!=j)
                    {
                        counter++;
                    }
                    
                }
                //isPassedNumber[i] = false;
            }
            

            return counter;
        }
    }
}
