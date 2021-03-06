﻿using System;
using System.Linq;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfWagons = int.Parse(Console.ReadLine());

            var train = new int[numberOfWagons];

            for (int i = 0; i < numberOfWagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" ", train) + Environment.NewLine
                + train.Sum());
        }
    }
}
