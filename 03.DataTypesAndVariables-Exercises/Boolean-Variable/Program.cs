using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringWithBooleanValue = Console.ReadLine();

            bool isStringReply = Convert.ToBoolean(stringWithBooleanValue);

            if (isStringReply)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }   
    }
}
