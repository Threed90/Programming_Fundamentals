using System;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger facturial = 1;

            for (int i = 1; i <= n; i++)
            {
                facturial *= i;
            }

            Console.WriteLine(facturial);
        }
    }
}
