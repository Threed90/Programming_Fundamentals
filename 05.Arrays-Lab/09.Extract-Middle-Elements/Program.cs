using System;
using System.Linq;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(GetMidElements(array));
        }

        private static string GetMidElements(int[] array)
        {
            string midElements = null;
            if (array.Length == 1)
            {
                midElements = $"{{ {array[0]} }}";
            }
            else if (array.Length%2 == 0)
            {
                midElements = $"{{ {array[(array.Length-2)/2]}, {array[(array.Length - 2) / 2 + 1]} }}";
            }
            else
            {
                midElements = $"{{ {array[(array.Length - 3) / 2]}, {array[(array.Length - 3) / 2 + 1]}, {array[(array.Length - 3) / 2 + 2]} }}";
            }

            return midElements;
        }
    }
}
