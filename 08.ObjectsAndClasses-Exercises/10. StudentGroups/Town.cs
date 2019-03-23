using System;
using System.Collections.Generic;
using System.Text;

namespace _10._StudentGroups
{
    class Town
    {
        public string Name { get; set; }
        public int GroupCapacity { get; set; }
        public List<Student> Students { get; set; }

        public Town(string name, int groupCapacity)
        {
            this.Name = name;
            this.GroupCapacity = groupCapacity;
            this.Students = new List<Student>();
        } 
    }
}
