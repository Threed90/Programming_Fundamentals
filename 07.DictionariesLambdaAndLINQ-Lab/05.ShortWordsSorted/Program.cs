using System;
using System.Collections.Generic;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            string word = "";
            List<string> words = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' || input[i] == '.' || input[i] == ',' || input[i] == ':' || input[i] == ',' || input[i] == ';'
                                   || input[i] == '(' || input[i] == ')' || input[i] == '[' || input[i] == ']' || input[i] == '\"'
                                   || input[i] == '\'' || input[i] == '\\' || input[i] == '/' || input[i] == '!' || input[i] == '?')
                {
                    if (word != string.Empty)
                        words.Add(word);

                    word = "";

                }
                else
                {
                    word += input[i];
                    if (i == input.Length - 1)
                    {
                        words.Add(word);
                    }
                }
            }

            for (int i = 0; i < words.Count - 1; i++)
            {
                for (int j = i + 1; j < words.Count; j++)
                {
                    if (words[i] == words[j])
                    {
                        words.Remove(words[j]);
                        j = i;
                    }
                }

            }
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length > 4) //|| words[i] == "")
                {
                    words.Remove(words[i]);
                    i -= 1;
                }
            }
            //for (int k = 0; k < words.Count - 1; k++)
            //{

            //    for (int i = k + 1; i < words.Count; i++)
            //    {
            //        if (words[k][0] > words[i][0])
            //        {
            //            string holder = words[k];
            //            words[k] = words[i];
            //            words[i] = holder;
            //            i = k;
            //        }
            //        //        else if (words[k].Contains(words[i]) || words[i].Contains(words[k]))
            //        //        {
            //        //            if (words[k].Length > words[i].Length)
            //        //            {
            //        //                string holder = words[k];
            //        //                words[k] = words[i];
            //        //                words[i] = holder;
            //        //                i = k;
            //        //            }
            //        //        }
            //        else if (words[k][0] == words[i][0])
            //        {
            //            int minLength = Math.Min(words[k].Length, words[i].Length);
            //            for (int j = 1; j < minLength; j++)
            //            {
            //                if (words[k][j] > words[i][j])
            //                {
            //                    string holder = words[k];
            //                    words[k] = words[i];
            //                    words[i] = holder;
            //                    i = k;
            //                    break;
            //                }
            //            }

            //        }
            //    }
            //}
            words.Sort();
            for (int i = 0; i < words.Count; i++)
            {
                if (i == words.Count - 1)
                {
                    Console.Write(words[i]);
                    break;
                }
                Console.Write(words[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
