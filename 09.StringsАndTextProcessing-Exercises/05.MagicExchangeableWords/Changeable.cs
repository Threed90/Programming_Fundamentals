using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.MagicExchangeableWords
{
    class Changeable
    {

        public static string Checkable(string[] input)
        {
            Dictionary<char, char> bookChecker = new Dictionary<char, char>();

            string smallerStr = input.First(x => x.Length == Math.Min(input[0].Length, input[1].Length));
            string biggerStr = input.Last(x => x.Length == Math.Max(input[0].Length, input[1].Length));

            for (int i = 0; i < biggerStr.Length; i++)
            {
                if (i < smallerStr.Length)
                {
                    if (!bookChecker.ContainsKey(biggerStr[i]))
                    {
                        bookChecker.Add(biggerStr[i], smallerStr[i]);
                    }
                    else
                    {
                        if (bookChecker[biggerStr[i]] != smallerStr[i])
                            return "false";
                    }
                }
                else
                {
                    if (!bookChecker.ContainsKey(biggerStr[i]))
                        return "false";

                }
            }
            return "true";
        }
    }
}
