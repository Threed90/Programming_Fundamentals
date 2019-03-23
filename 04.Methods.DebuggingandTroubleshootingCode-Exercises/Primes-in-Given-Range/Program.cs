using System;
using System.Linq;
using System.Collections.Generic;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            string result = "";

            foreach( int i in GetListOfPrimeNumbersBetween(startNumber, endNumber))
            {
                result += (Convert.ToString(i) + ", ");
            }
            if (startNumber > endNumber)
            {
                Console.WriteLine();
            }
            else
            {
            Console.WriteLine(result.Remove(result.Length-2));
            }
        }

        static List<int> GetListOfPrimeNumbersBetween(int start, int end)
        {
            List<int> primeNumberList = new List<int>();
            for (int numbers = start; numbers <= end; numbers++)
            {
                
                    primeNumberList.Add(numbers);
                
                if (numbers>1)
                {
                    for (int primeChecker = 2; primeChecker <= Math.Sqrt(numbers); primeChecker++)
                    {
                        if (numbers % primeChecker == 0)
                        {
                            primeNumberList.Remove(numbers);
                            break;
                        }
                        
                    }
                }
            }
            primeNumberList.Remove(0);
            primeNumberList.Remove(1);

            return primeNumberList;
        }
    }
}
