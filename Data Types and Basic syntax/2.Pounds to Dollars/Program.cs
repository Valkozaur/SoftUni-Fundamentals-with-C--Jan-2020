using System;

namespace _2.Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal poundsInput = decimal.Parse(Console.ReadLine());
            decimal poundsToUSD = poundsInput * (decimal)1.31;

            Console.WriteLine($"{poundsToUSD:F3}");
        }
    }
}
