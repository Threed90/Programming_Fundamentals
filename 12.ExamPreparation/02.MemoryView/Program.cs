using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string all = "";

            while (input != "Visual Studio crash")
            {
                all += input + " ";

                input = Console.ReadLine();
            }

            string[] arr = Regex.Split(all, @"32656 19759 32763 0 ").Where(el => !el.StartsWith("0") && !string.IsNullOrEmpty(el)).ToArray();

            foreach (string element in arr)
            {
                string[] arr2 = element.Split().Where(el => el != "0" && !string.IsNullOrEmpty(el)).ToArray();
                string result = "";
                for (int i = 0; i < int.Parse(arr2[0]); i++)
                {
                    result += (char)int.Parse(arr2[i + 1]);
                }

                Console.WriteLine(result);
            }
        }
    }
}
