using System;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int minNum = Math.Min(firstNum, secondNum);
            int maxNum = Math.Max(firstNum, secondNum);

            int biggerFirstNum = 0;
            int biggerSecondNum = 0;
            int counter=0;

            for (int one = minNum; one <= maxNum; one++)
            {
                for (int two = minNum; two <= maxNum; two++)
                {
                    counter++;

                    if ((one+two) == magicNum)
                    {
                        if (biggerFirstNum < one)
                        {
                            biggerFirstNum = one;
                        }
                        biggerSecondNum = two;
                    }
                   
                }
            }

            if ((biggerFirstNum + biggerSecondNum) == magicNum)
            {
                Console.WriteLine($"Number found! {biggerFirstNum} + {biggerSecondNum} = {biggerFirstNum + biggerSecondNum}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }

        }
    }
}
