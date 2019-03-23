using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10._StudentGroups
{
    class Group
    {
        public Town Town { get; set; }
        public List<Student> Members { get; set; }

        public Group(Town town)
        {
            this.Town = town;
            this.Members = new List<Student>();
        }


    }
}
