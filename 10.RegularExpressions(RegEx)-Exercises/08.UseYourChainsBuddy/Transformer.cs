using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.UseYourChainsBuddy
{
    class Transformer
    {
        public static string ReplaceSymbols(string text)
        {
            return Regex.Replace(text, @"[^a-z0-9]", " ");
        }

        public static string RemoveSpaces(string text)
        {
            return Regex.Replace(text, @"\s+", " ");
        }
    }
}
