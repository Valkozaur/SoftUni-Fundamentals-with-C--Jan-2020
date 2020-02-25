using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    public class Car
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }

    public class Truck
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var carsCatalogue = new List<Car>();
            var trucksCatalogue = new List<Truck>();

            while (true)
            {

                var input = Console.ReadLine()
                    .Split(" ");

                if (input[0] == "End")
                {

                    break;
                }

                var type = input[0];
                var model = input[1];
                var color = input[2];
                var horsePower = int.Parse(input[3]);

                if (type == "car")
                {

                    var car = new Car();
                    car.Model = model;
                    car.Color = color;
                    car.HorsePower = horsePower;

                    carsCatalogue.Add(car);
                }
                else if (type == "truck")
                {

                    var truck = new Truck();
                    truck.Model = model;
                    truck.Color = color;
                    truck.HorsePower = horsePower;

                    trucksCatalogue.Add(truck);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                var model = input;

                if (carsCatalogue.Any(x => x.Model == model))
                {

                    var currentCar = carsCatalogue.FirstOrDefault(x => x.Model == model);
                    Console.WriteLine($"Type: Car" + Environment.NewLine
                                    + $"Model: {currentCar.Model}" + Environment.NewLine
                                    + $"Color: {currentCar.Color}" + Environment.NewLine
                                    + $"Horsepower: {currentCar.HorsePower}");
                }
                else if (trucksCatalogue.Any(x => x.Model == model))
                {
                    var currentTruck = trucksCatalogue.FirstOrDefault(x => x.Model == model);
                    Console.WriteLine($"Type: Truck" + Environment.NewLine
                                    + $"Model: {currentTruck.Model}" + Environment.NewLine
                                    + $"Color: {currentTruck.Color}" + Environment.NewLine
                                    + $"Horsepower: {currentTruck.HorsePower}");
                }
            }

            var totalHorsePower = 0.0;
            foreach (var car in carsCatalogue)
            {
                totalHorsePower += car.HorsePower;
            }

            if (carsCatalogue.Any())
            {
                Console.WriteLine($"Cars have average horsepower of: {totalHorsePower / carsCatalogue.Count:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            totalHorsePower = 0.0;
            foreach (var truck in trucksCatalogue)
            {
                totalHorsePower += truck.HorsePower;
            }

            if (trucksCatalogue.Any())
            {
                Console.WriteLine($"Trucks have average horsepower of: {totalHorsePower / trucksCatalogue.Count:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
