using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

           
            Console.WriteLine(GetFactorialRezult(number));
        }

        static BigInteger GetFactorialRezult(int number)
        {
            BigInteger facturialNumber = 1;
            for (int i = number; i > 0; i--)
            {
                facturialNumber *= i;
            }
            return facturialNumber;
        }
    }
}
