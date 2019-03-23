using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.QueryMess
{
    class Constructor
    {
        public string Text { get; set; }
        public string WhiteSpaceDeleter { get; set; }

        public Constructor(string text)
        {
            Text = text;
            this.WhiteSpaceDeleter = Regex.Replace(Regex.Replace(this.Text, @"((%20)|\+|\t)", " "), @"\s+", " ");
        }

        public override string ToString()
        {
            Dictionary<string, HashSet<string>> result = new Dictionary<string, HashSet<string>>();
            StringBuilder str = new StringBuilder();

            Regex.Matches(this.WhiteSpaceDeleter, @"([^=?&]+)=([^?&]+)((?=[&?])|$)").Cast<Match>().ToList().ForEach(e =>
            {
                string first = e.Groups[1].Value.Trim();
                string second = e.Groups[2].Value.Trim();
                if (!result.ContainsKey(first))
                {
                    result.Add(first, new HashSet<string>());

                }

                result[first].Add(second);
            });
            foreach (KeyValuePair<string, HashSet<string>> item in result)
            {
                str.Append($"{item.Key}=[{string.Join(", ", item.Value)}]");
            }

            return str.ToString();
        }
    }
}
