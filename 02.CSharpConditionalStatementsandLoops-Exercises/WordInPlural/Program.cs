using System;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1);

                noun += "ies";
                Console.WriteLine(noun);
            }
            else if(noun.EndsWith("o") || noun.EndsWith("s") || noun.EndsWith("x") || noun.EndsWith("z") || noun.EndsWith("ch") || noun.EndsWith("sh"))
            {
                noun += "es";

                Console.WriteLine(noun);
            }
            else
            {
                noun += "s";

                Console.WriteLine(noun);
            }
        }
    }
}
