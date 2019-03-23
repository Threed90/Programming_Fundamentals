using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            //string pattern = $@"\b([A-Za-z]*[^a-zA-Z.?!]*)\b{keyWord}\b([^a-zA-Z.!?]*[a-zA-Z]*)($|(?=[!.?]))";

            string pattern = $@"\b[^.!?]*\b{keyWord}\b[^.?!]*($|(?=[!.?]))";

            Regex.Matches(text, pattern).Cast<Match>().ToList().ForEach(e =>
            {
                Console.WriteLine(e.Value.Trim());
            });
        }
    }
}
