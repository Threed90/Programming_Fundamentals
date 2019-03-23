using System;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int firstBracket = 0;
            int secondBracket = 0;
            string lastBecket = "";

            for (int counter = 0; counter < numberOfLines; counter++)
            {
                string recivedString = Console.ReadLine();

                if (recivedString == "(")
                {
                    firstBracket++;
                    if(lastBecket == "(")
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    lastBecket = "(";
                }
                else if (recivedString == ")")
                {
                    secondBracket++;
                    if(lastBecket == ")")
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    lastBecket = ")";
                }
            }
            
            if (firstBracket == secondBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
