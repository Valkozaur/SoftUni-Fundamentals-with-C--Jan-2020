﻿using System;
using System.Linq;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                var temp = arrayInput[0];

                for (int currentIndex = 0; currentIndex < arrayInput.Length - 1; currentIndex++)
                {
                    arrayInput[currentIndex] = arrayInput[currentIndex + 1];
                }

                arrayInput[arrayInput.Length - 1] = temp;
            }

            Console.WriteLine(String.Join(" ", arrayInput));
        }
    }
}
