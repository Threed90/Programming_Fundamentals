using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int entranceNumber = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= entranceNumber; i++)
            {
                int sum = 0;
                int reducedDigitValue = i;
                while (reducedDigitValue>0)
                {
                    sum += (reducedDigitValue % 10);
                    reducedDigitValue /= 10;
                    
                }
                bool isMagic = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isMagic}");

                
            }
        }
    }
}
