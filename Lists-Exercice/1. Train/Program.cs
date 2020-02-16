using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var train = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            var wagonsMaxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                var splittedInput = input
                    .Split(" ");

                if (splittedInput[0] == "Add")
                {
                    var newWagon = int.Parse(splittedInput[1]);
                    train.Add(newWagon);
                }
                else
                {
                    var passengersToFit = int.Parse(splittedInput[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + passengersToFit <= wagonsMaxCapacity)
                        {
                            train[i] += passengersToFit;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", train));
        }
    }
}
