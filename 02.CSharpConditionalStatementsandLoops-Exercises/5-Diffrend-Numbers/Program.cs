using System;

namespace _5_Diffrend_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int min = Math.Min(a, b);
            int max = Math.Max(a, b);

            if (max - min < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int one = min; one <= max; one++)
            {
                for (int two = min; two <= max; two++)
                {
                    for (int three = min; three <= max; three++)
                    {
                        for (int four = min; four <= max; four++)
                        {
                            for (int five = min; five <= max; five++)
                            {
                                if(min<=one && one<two && two<three && three<four && four<five && five <= b)
                                {
                                    Console.WriteLine($"{one} {two} {three} {four} {five}");
                                }
                                

                            }
                        }
                    }
                }
            }
            
        }
    }
}
