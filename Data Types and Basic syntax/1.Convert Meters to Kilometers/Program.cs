using System;

namespace Integ
{
    class Program
    {
        static void Main(string[] args)
        {
            double metersInput = double.Parse(Console.ReadLine());
            decimal convertedToKM = (decimal)metersInput / 1000;

            Console.WriteLine($"{convertedToKM:F2}");
        }
    }
}
