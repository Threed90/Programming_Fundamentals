using System;
using System.Collections.Generic;
using System.Text;

namespace _08.UseYourChainsBuddy
{
    class Decrypt
    {
        public static string Decrypting(string text)
        {
            return GetResult(Transformer.RemoveSpaces(Transformer.ReplaceSymbols(new Filter(text).Text))).ToString();
        }

        private static StringBuilder GetResult(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 97 && str[i] <= 109)
                {
                    result.Append((char)(str[i] + 13));
                }
                else if (str[i] > 109 && str[i] <= 122)
                {
                    result.Append((char)(str[i] - 13));
                }
                else if (char.IsDigit(str[i]) || char.IsWhiteSpace(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result;
        }
    }
}
