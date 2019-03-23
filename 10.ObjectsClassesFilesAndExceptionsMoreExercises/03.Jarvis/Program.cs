using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace _03.Jarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            string maxEnergy = Console.ReadLine();
            List<Arm> arms = new List<Arm>();
            List<Leg> legs = new List<Leg>();
            List<Head> heads = new List<Head>();
            List<Torso> torsos = new List<Torso>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Assemble!")
                {
                    break;
                }

                GetRobotParts(input, arms, legs, heads, torsos);
            }
            
            Console.WriteLine(new Robot(maxEnergy,Head.GetLowestEnergyPart(heads), Torso.GetLowestEnergyPart(torsos), arms, legs));

        }

        private static void GetRobotParts(string[] input, List<Arm> arms, List<Leg> legs, List<Head> head, List<Torso> torso)
        {
            if (input[0].ToLower() == "head")
            {
                head.Add(new Head(int.Parse(input[1]), int.Parse(input[2]), input[3]));

            }
            else if (input[0].ToLower() == "torso")
            {
                torso.Add(new Torso(int.Parse(input[1]), double.Parse(input[2]), input[3]));

            }
            else if (input[0].ToLower() == "arm")
            {
                arms.Add(new Arm(int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3])));

            }
            else if (input[0].ToLower() == "leg")
            {
                legs.Add(new Leg(int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3])));
            }
        }
    }
}
