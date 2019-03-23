using System;
using System.Linq;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int masterNumChecker = 0; masterNumChecker <= number; masterNumChecker++)
            {
                if (isPalindrome(masterNumChecker) && isDivisibleBySeven(masterNumChecker) && isEvenNumber(masterNumChecker))
                {
                    Console.WriteLine(masterNumChecker);
                }
                
            }
        }

        static bool isPalindrome(int number)
        {
            int temporalyNumHolder = number;
            int palindromeChecker = 0;
            while (number > 0)
            {
                palindromeChecker *= 10;
                palindromeChecker += (number % 10);
                
                number /= 10;
            }
            if(palindromeChecker == temporalyNumHolder)
            {
                return true;
            }
            return false;
            
        }
        static bool isDivisibleBySeven(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }
        static bool isEvenNumber(int number)
        {
            int evenChecker = 0;
            while (number>0)
            {
                evenChecker = number % 10;
                if (evenChecker%2 == 0)
                {
                    return true;
                    
                }
                number /= 10;
            }
            return false;
        }
    }
}
