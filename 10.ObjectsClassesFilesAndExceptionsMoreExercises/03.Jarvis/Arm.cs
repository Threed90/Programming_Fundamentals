using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Jarvis
{

    class Arm
    {
        public int Enegry { get; set; }
        public int ArmDistance { get; set; }
        public int Fingers { get; set; }

        public Arm(int energy, int armDistance, int fingers)
        {
            this.Enegry = energy;
            ArmDistance = armDistance;
            Fingers = fingers;
        }
    }
}
