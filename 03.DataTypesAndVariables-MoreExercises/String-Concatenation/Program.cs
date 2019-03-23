using System;

namespace String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenORodd = Console.ReadLine().ToLower();
            int numberOfLines = int.Parse(Console.ReadLine());

            string stringCollectorForEven = "";
            string stringCollectorForOdd = "";

            for (int stringCounter = 1; stringCounter <= numberOfLines; stringCounter++)
            {
                string stringForConcatenation = Console.ReadLine();

                string delimiterAsString = "";
                delimiterAsString = Convert.ToString(delimiter);
                stringForConcatenation += delimiterAsString;

                if (stringCounter % 2 == 0 && evenORodd == "even")
                {
                    stringCollectorForEven += stringForConcatenation;
                }
                else if (stringCounter % 2 != 0 && evenORodd == "odd")
                {
                    stringCollectorForOdd += stringForConcatenation;
                }

            }
            if (evenORodd == "even")
            {
                Console.WriteLine(stringCollectorForEven.Remove(stringCollectorForEven.Length-1));
            }
            else if (evenORodd == "odd")
            {
                Console.WriteLine(stringCollectorForOdd.Remove(stringCollectorForOdd.Length-1));
            }
        }
    }
}
