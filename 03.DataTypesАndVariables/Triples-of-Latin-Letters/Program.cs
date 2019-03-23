using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int entranceNumber = int.Parse(Console.ReadLine()) + 96;

            for (char letter1 = 'a'; letter1 <= entranceNumber; letter1++)
            {
                for (char letter2 = 'a'; letter2 <= entranceNumber; letter2++)
                {
                    for (char letter3 = 'a'; letter3 <= entranceNumber; letter3++)
                    {
                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }
        }
    }
}
