using System;

namespace Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string IDType = Console.ReadLine();
            int NumberOfID = int.Parse(Console.ReadLine());

            long ThiefID = long.MinValue;

            for (int idCounter = 0; idCounter < NumberOfID; idCounter++)
            {
                long idNumber = long.Parse(Console.ReadLine());

                bool isSbyte = idNumber >= sbyte.MinValue && idNumber <= sbyte.MaxValue;

                if (isSbyte && IDType == "sbyte" && ThiefID < idNumber)
                {
                    ThiefID = idNumber;
                }

                bool isInteger = idNumber >= int.MinValue && idNumber <= int.MaxValue;

                if (isInteger && IDType == "int" && ThiefID < idNumber)
                {
                    ThiefID = idNumber;
                }

                if ( IDType == "long" && ThiefID < idNumber)
                {
                    ThiefID = idNumber;
                }
            }
            double sentence = 0;
            if(ThiefID > 0)
            {
                sentence = Math.Ceiling(ThiefID / 127.0);
            }
            else
            {
                sentence = Math.Ceiling(ThiefID / -128.0);
            }

            if (sentence > 1)
            {
                Console.WriteLine($"Prisoner with id {ThiefID} is sentenced to {sentence} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {ThiefID} is sentenced to {sentence} year");
            }
        }
    }
}
