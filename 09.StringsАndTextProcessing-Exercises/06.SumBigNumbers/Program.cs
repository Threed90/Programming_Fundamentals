using System;

namespace _06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if(first.Length<=second.Length)
            {
                Console.WriteLine(Calculation.Sum(first, second));
            }
            else
            {
                Console.WriteLine(Calculation.Sum(second, first));
            }
            
        }
    }
}
