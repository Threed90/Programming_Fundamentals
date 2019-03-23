using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Jarvis
{
    class Leg
    {
        public int Energy { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }

        public Leg(int energy, int strength, int speed)
        {
                Energy = energy;
                Strength = strength;
                Speed = speed;
        }
    }
}
