using System;
using System.Linq;

namespace _05.ShortWordsSorted_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ",Console.ReadLine().ToLower().Split(".,:;()[]\"\'\\/!? ".ToCharArray(), StringSplitOptions
                                                                 .RemoveEmptyEntries).OrderBy(x => x).Distinct()
                                                                 .Where(x => x.Length < 5).ToArray()));
        }
    }
}
