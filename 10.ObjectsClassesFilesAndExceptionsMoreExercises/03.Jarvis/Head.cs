using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Jarvis
{
    class Head
    {
        public int Energy { get; set; } = int.MaxValue;
        public int IQ { get; set; }
        public string SkinMaterial { get; set; }

        public Head(int energy, int iQ, string skinMaterial)
        {
                Energy = energy;
                IQ = iQ;
                SkinMaterial = skinMaterial;
        }

        public static Head GetLowestEnergyPart(List<Head> heads)
        {
            if(heads.Count >=1)
            return heads.OrderBy(x => x.Energy).First();

            return null;
        }
    }
}
