using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            do
            {
                List<string> input = Console.ReadLine().ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (input.Contains("delete"))
                {
                    numbers.RemoveAll(x => x == int.Parse(input[1]));
                }
                else if (input.Contains("insert"))
                {
                    numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                else if (input.Contains("odd"))
                {
                    numbers.RemoveAll(x => x % 2 == 0);
                    break;
                }
                else if (input.Contains("even"))
                {
                    numbers.RemoveAll(x => x % 2 != 0);
                    break;
                }

            } while (true);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
