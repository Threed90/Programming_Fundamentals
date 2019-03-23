using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool isMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                
                if (text[i] == Search)
                {
                    isMatch = true;

                    int endIndex = jump + 1;
                    
                    if (endIndex > text.Length-i)
                    {
                        endIndex = text.Length-i;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!isMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
