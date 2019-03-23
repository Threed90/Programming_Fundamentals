using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Take_SkipRope
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] input = Console.ReadLine().ToCharArray();

            List<int> nums = input.Where(x => char.IsDigit(x)).Select(x => (int)char.GetNumericValue(x)).ToList();
            List<char> symbols = input.Where(x => !char.IsDigit(x)).ToList();

            string result = "";
            int skiper = 0;
            for (int i = 0; i < nums.Count-1; i+=2)
            {
                result += new string (symbols.Skip(skiper).Take(nums[i]).ToArray());
                skiper += (nums[i] + nums[i + 1]);
            }

            Console.WriteLine(result);
        }
    }
}
