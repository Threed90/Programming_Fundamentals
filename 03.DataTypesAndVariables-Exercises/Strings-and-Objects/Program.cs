using System;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";

            object allStringsHere = firstWord + " " + secondWord;

            string objectToString = Convert.ToString(allStringsHere);

            Console.WriteLine(objectToString);
        }
    }
}
