using System;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            
                Console.WriteLine(GetCountOfZeros(number));
             
        }
        static BigInteger GetFactorialNumber(int number)
        {
            BigInteger facturialNum = 1;
            for (int i = number; i > 0; i--)
            {
                facturialNum *= i;
            }
            return facturialNum;
        }

        static int GetCountOfZeros(int number)
        {
            BigInteger factorialNumber = GetFactorialNumber(number);
            int counter = 0;
            while(factorialNumber%10 == 0)
            {
                BigInteger zeroCounter = factorialNumber % 10;
                if(factorialNumber%10 == 0)
                {
                    counter++;
                }
                factorialNumber /= 10;
            }
            return counter;
        }
        
    }
}
