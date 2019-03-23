using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleSumsOFEvensAndOdds(number));
        }
        /// <summary>
        /// Multiplies the sums of even and odd digits in the integer.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int GetMultipleSumsOFEvensAndOdds(int number)
        {
            int multipleResult = GetSumOfEven(number) * GetSumOfOdd(number);

            return multipleResult;
        }
        /// <summary>
        /// Write the number and get the sum of all even digits in it.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int GetSumOfEven(int number)
        {
            int sum = 0;
            int even = 0;
            while (number!=0)
            {
                even = number % 10;
                if (even % 2 == 0)
                {
                    sum += even;
                }
                number /= 10;
            }

            return sum;
        }
        /// <summary>
        /// Write the number and get the sum of all odd digits in it.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int GetSumOfOdd(int number)
        {
            int sum = 0;
            int odd = 0;
            while (number != 0)
            {
                odd = number % 10;
                if (odd % 2 != 0)
                {
                    sum += odd;
                }
                number /= 10;
            }

            return sum;
        }
    }
}
