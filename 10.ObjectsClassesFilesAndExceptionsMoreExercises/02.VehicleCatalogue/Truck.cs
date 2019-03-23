using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.VehicleCatalogue
{
    class Truck
    {
        public Truck(string model, string color, double horsePower)
        {
            Model = model;
            Color = color;
            HorsePower += horsePower;
        }

        public string Type
        {
            get
            {
                return "Truck";
            }
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; } = 0;

        public static double GetAverage(List<Truck> trucks)
        {
            double average = 0.00;
            if (trucks.Count>0)
            {
                average = trucks.Select(t => t.HorsePower).Average();
            }

            return average;
        }
    }
}
