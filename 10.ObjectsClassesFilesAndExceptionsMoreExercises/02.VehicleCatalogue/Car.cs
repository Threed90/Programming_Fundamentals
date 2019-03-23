using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.VehicleCatalogue
{
    class Car
    {
        public Car(string model, string color, double horsePower)
        {
            Model = model;
            Color = color;
            HorsePower += horsePower;
        }

        public string Type
        {
            get
            {
                return "Car";
            }
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public static double GetAverage(List<Car> cars)
        {
            double average = 0.00;
            if (cars.Count > 0)
            {
                average = cars.Select(t => t.HorsePower).Average();
            }

            return average;
        }
    }
}
