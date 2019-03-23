using System;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int keyForDecrypting = int.Parse(Console.ReadLine());
            int totalCharNumber = int.Parse(Console.ReadLine());

            string decryptedWords = "";

            for (int charCounter = 0; charCounter < totalCharNumber; charCounter++)
            {
                char cryptedLetter = char.Parse(Console.ReadLine());

                int decryptingProcess = Convert.ToInt32(cryptedLetter) + keyForDecrypting;

                char decryptedLetter = Convert.ToChar(decryptingProcess);

                
                decryptedWords += Convert.ToString(decryptedLetter);
            }

            Console.WriteLine(decryptedWords);
        }
    }
}
