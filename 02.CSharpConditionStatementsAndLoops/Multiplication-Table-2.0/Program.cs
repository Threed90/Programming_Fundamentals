using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            int MultiplicationStartNum = int.Parse(Console.ReadLine());

            if (MultiplicationStartNum > 10)
            {
                Console.WriteLine($"{multiplier} X {MultiplicationStartNum} = {multiplier*MultiplicationStartNum}");
            }
            else
            {
                for (int i = MultiplicationStartNum; i <=10; i++)
                {
                    Console.WriteLine($"{multiplier} X {i} = {i*multiplier}");
                }
            }
            
        }
    }
}
