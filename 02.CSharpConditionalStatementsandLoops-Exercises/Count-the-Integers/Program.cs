using System;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                
                
                string input = Console.ReadLine();          
                bool isNumber = int.TryParse(input, out int num);

                if (!(isNumber))
                {
                    Console.WriteLine(i);
                    break;
                }
                i++;
            }
        }
    }
}
