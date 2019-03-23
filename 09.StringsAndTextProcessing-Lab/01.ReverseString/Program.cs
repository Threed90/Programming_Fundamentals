using System;
using System.Linq;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            ReverseString(input);

            
        }

        private static void ReverseString(string word)
        {
            //string result = "";
            //for (int i = word.Length - 1; i >= 0; i--) //for(int i = 0; i < word.Length; i++)        
            //{
            //    result += word[i]; //result += word[word.Length-1-i];
            //}
            Console.WriteLine(string.Join("",word.ToCharArray().Reverse())); // Console.WriteLine(new string(word.ToCharArray().Reverse().ToArray()));
        }
    }
}
