using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int entranceNumber = int.Parse(Console.ReadLine());
            
            for (int numberCounter = 1; numberCounter <= entranceNumber; numberCounter++)
            {
                int sum = 0;
                int degradeDigitsOfNumber = numberCounter;
                while (degradeDigitsOfNumber > 0)
                {
                    sum += degradeDigitsOfNumber % 10;
                    degradeDigitsOfNumber /= 10;
                }
                bool isMagic = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{numberCounter} -> {isMagic}");
                
            }

        }
    }
}
