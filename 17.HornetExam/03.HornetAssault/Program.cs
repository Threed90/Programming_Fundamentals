using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();

            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            long hornetPower = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                    break;

                beehives[i] -= hornetPower;

                if(beehives[i]>=0)
                {
                    hornetPower -= hornets[0];
                    hornets.RemoveAt(0);
                }
            }

            beehives.RemoveAll(x => x <= 0);

            if(beehives.Count>0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
