using System;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n%2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    n = Math.Abs(n);

                    Console.WriteLine("The number is: {0}", n);
                    break;
                }
            }
        }
    }
}
