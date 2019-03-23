using System;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            int letterToNumber = letter1;
            int letterToNumber2 = letter2;
            int letterToNumber3 = letter3;

            int min = Math.Min(letterToNumber, letterToNumber2);
            int max = Math.Max(letterToNumber, letterToNumber2);

            for (int firstLetter = min; firstLetter <= max; firstLetter++)
            {
                for (int secondLetter = min; secondLetter <= max; secondLetter++)
                {
                    for (int thirdLetter = min; thirdLetter <= max; thirdLetter++)
                    {
                        if (firstLetter != letterToNumber3 && secondLetter != letterToNumber3 && thirdLetter != letterToNumber3)
                        {
                            Console.Write($"{(char)firstLetter}{(char)secondLetter}{(char)thirdLetter} ");
                        }
                    }
                }
            }
        }
    }
}
