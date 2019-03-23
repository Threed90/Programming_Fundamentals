using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class Delimiter
    {
        public string FirstDelimiter { get; set; }
        public string SecondDelimiter { get; set; }
        public string Text { get; set; }
        public string Result
        {
            get
            {
                MatchCollection matches = Regex.Matches(this.Text, $@"(?<={this.FirstDelimiter}).*?(?={this.SecondDelimiter})");
                StringBuilder result = new StringBuilder();
                foreach (Match item in matches)
                {
                    result.Append(item);
                }

                return result.Length == 0 ? "Empty result" : result.ToString();
            }
        }

        public Delimiter(string key, string text)
        {
            this.FirstDelimiter = Regex.Match(key, @"^[A-Za-z]+(?=[<\|\\])").Value;
            this.SecondDelimiter = Regex.Match(key, @"(?<=[<\|\\])[A-Za-z]+$").Value;
            this.Text = text;
        }

        //public static string End(string text)
        //{
        //    return Regex.Match(text, @"(?<=[<\|\\])[A-Za-z]+$").Value;
        //}

        //public static string Start(string text)
        //{
        //    return Regex.Match(text, @"^[A-Za-z]+(?=[<\|\\])").Value;
        //}
    }
}
