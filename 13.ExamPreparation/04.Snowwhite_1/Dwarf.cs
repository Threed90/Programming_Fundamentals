using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Snowwhite_1
{
    class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }
        public int ColorNum { get; set; }
        

        public Dwarf(string name, string color, string physics)
        {
            Name = name;
            Color = color;
            Physics = int.Parse(physics);
            ColorNum = 1;
        }

        public static void CheckDwarfs(List<Dwarf> dwarfs)
        {
            for (int i = 0; i < dwarfs.Count - 1; i++)
            {
                for (int j = i + 1; j < dwarfs.Count; j++)
                {
                    if (dwarfs[i].Name == dwarfs[j].Name && dwarfs[i].Color == dwarfs[j].Color)
                    {
                        if (dwarfs[i].Physics >= dwarfs[j].Physics)
                        {
                            dwarfs.Remove(dwarfs[j]);
                            j = i;
                            continue;
                        }
                        if (dwarfs[i].Physics < dwarfs[j].Physics)
                        {
                            dwarfs.Remove(dwarfs[i]);
                            i = -1;
                            break;
                        }
                    }
                }
            }
            List<string> colors = new List<string>();
            for (int i = 0; i < dwarfs.Count - 1; i++)
            {
                for (int j = i + 1; j < dwarfs.Count; j++)
                {
                    if (dwarfs[i].Color == dwarfs[j].Color && dwarfs[i].ColorNum >= dwarfs[j].ColorNum && !colors.Contains(dwarfs[i].Color))
                    {
                        dwarfs[i].ColorNum++;
                    }
                }
                colors.Add(dwarfs[i].Color);
                for (int j = i+1; j < dwarfs.Count; j++)
                {
                    if (dwarfs[i].Color == dwarfs[j].Color)
                    {
                        dwarfs[j].ColorNum = Math.Max(dwarfs[i].ColorNum, dwarfs[j].ColorNum);
                    }
                }
            }
            
            
        }
        
        
    }
}
