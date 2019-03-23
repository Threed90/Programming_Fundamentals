using System;
using System.Linq;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = rnd.Next(0, input.Length);
                string holder = input[i];
                input[i] = input[randomIndex];
                input[randomIndex] = holder;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
