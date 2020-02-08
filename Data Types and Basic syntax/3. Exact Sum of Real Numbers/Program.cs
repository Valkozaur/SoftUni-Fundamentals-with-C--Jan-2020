using System;
using System.Numerics;

namespace _3._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            BigInteger number = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                string currentNumber = Console.ReadLine();
                number += BigInteger.Parse(currentNumber);
            }

            Console.WriteLine(number);
        }
    }
}
