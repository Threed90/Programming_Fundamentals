using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Jarvis
{
    class Torso
    {
        public int Energy { get; set; } = int.MaxValue;
        public double ProcessorSize { get; set; }
        public string Material { get; set; }

        public Torso(int energy, double processorSize, string material)
        {
                Energy = energy;
                ProcessorSize = processorSize;
                Material = material;
        }

        public static Torso GetLowestEnergyPart(List<Torso> torsos)
        {
            if (torsos.Count >= 1)
                return torsos.OrderBy(x => x.Energy).First();

            return null;
        }
    }
}
