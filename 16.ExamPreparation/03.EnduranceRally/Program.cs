using System;
using System.Linq;

namespace _03.EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split();

            double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int[] checkPoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (string driver in participants)
            {
                double fuelHolder = (int)driver[0];

                for (int i = 0; i < zones.Length; i++)
                {
                    if(checkPoints.Contains(i))
                    {
                        fuelHolder += zones[i];
                    }
                    else
                    {
                        fuelHolder -= zones[i];

                        if(fuelHolder<=0)
                        {
                            Console.WriteLine($"{driver} - reached {i}");
                            break;
                        }
                    }
                }
                if(fuelHolder>0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuelHolder:f2}");
                }
            }
        }
    }
}
