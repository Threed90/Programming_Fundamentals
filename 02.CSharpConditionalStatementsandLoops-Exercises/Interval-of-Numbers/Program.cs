using System;

namespace Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int smallerNum = Math.Min(firstNum, secondNum);
            int largerNum = Math.Max(firstNum, secondNum);

            for (int i = smallerNum; i <= largerNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
