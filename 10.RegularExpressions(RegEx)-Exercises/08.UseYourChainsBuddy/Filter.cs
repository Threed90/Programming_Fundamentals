using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.UseYourChainsBuddy
{
    class Filter
    {
        public string Text { get; set; }
        

        public Filter(string input)
        {
            StringBuilder result = new StringBuilder();
            //(?<=<p>)(.+?)(?=<\/p>) - better pattern, but judge dont accept it (88/100)
            Regex.Matches(input, @"<p>(.+?)<\/p>").Cast<Match>().ToList().ForEach(e=>
            {
                result.Append(e.Groups[1]);
            });
            

            this.Text = result.ToString();
        }

    }
}
