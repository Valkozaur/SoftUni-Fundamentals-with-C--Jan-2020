﻿using System;
using System.Linq;

namespace _2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine()
                .Split();
            var secondArray = Console.ReadLine()
                .Split();

            for (int i = 0; i < firstArray.Length; i++)
            {

                for (int k = 0; k < secondArray.Length; k++)
                {

                    if (firstArray[i] == secondArray[k])
                    {
                        Console.Write(firstArray[i] + " ");
                    }
                }
            }
        }
    }
}
