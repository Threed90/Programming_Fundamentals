using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }
                else if (input[0].ToLower() == "truck")
                {
                    trucks.Add(new Truck(input[1], input[2], double.Parse(input[3])));
                }
                else if (input[0].ToLower() == "car")
                {
                    cars.Add(new Car(input[1], input[2], double.Parse(input[3])));
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                PrintVehicleInfo(trucks, cars, input);
            }

            PrintAverageHorsePower(trucks, cars);

        }

        private static void PrintAverageHorsePower(List<Truck> trucks, List<Car> cars)
        {
            Console.WriteLine($"Cars have average horsepower of: {Car.GetAverage(cars):f2}.");

            Console.WriteLine($"Trucks have average horsepower of: {Truck.GetAverage(trucks):f2}.");
        }

        private static void PrintVehicleInfo(List<Truck> trucks, List<Car> cars, string input)
        {
            if (trucks.Any(x => x.Model == input))
            {
                Truck truck = trucks.First(x => x.Model == input);
                Console.WriteLine($"Type: {truck.Type}");
                Console.WriteLine($"Model: {truck.Model}");
                Console.WriteLine($"Color: {truck.Color}");
                Console.WriteLine($"Horsepower: {truck.HorsePower}");
            }
            else if (cars.Any(x => x.Model == input))
            {
                Car car = cars.First(c => c.Model == input);
                Console.WriteLine($"Type: {car.Type}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Color: {car.Color}");
                Console.WriteLine($"Horsepower: {car.HorsePower}");
            }
        }
    }
}
