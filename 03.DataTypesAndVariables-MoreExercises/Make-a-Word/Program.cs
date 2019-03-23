using System;

namespace Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            

            string charSum = "";

            for (int lineCounter = 0; lineCounter < numberOfLines; lineCounter++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                charSum += Convert.ToString(currentChar);

            }
            Console.WriteLine($"The word is: {charSum}");
        }
    }
}
