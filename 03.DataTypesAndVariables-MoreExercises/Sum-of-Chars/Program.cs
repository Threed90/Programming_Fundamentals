using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int sumOfChar = 0;

            for (int charCounter = 0; charCounter < numberOfLines; charCounter++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                sumOfChar += Convert.ToInt32(currentChar);
            }
            Console.WriteLine($"The sum equals: {sumOfChar}");
        }
    }
}
