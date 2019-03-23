using System;
using System.Collections.Generic;
using System.Text;

namespace _07.AndreyAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> Order { get; set; }

        public Customer(string name)
        {
            this.Name = name;
            this.Order = new Dictionary<string, int>();
        }

        public Customer()
        {

        }
        
    }
}
