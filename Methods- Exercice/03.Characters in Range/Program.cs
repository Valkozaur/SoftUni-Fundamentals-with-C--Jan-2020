using System;
using System.Linq;

namespace _03.Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            PrintChInBetween(firstSymbol, secondSymbol);
        }

        static void PrintChInBetween(char firstSymbol, char secondSymbol)
        {
            for (int i = (firstSymbol < secondSymbol ? firstSymbol : secondSymbol) + 1; i < (firstSymbol < secondSymbol ? secondSymbol : firstSymbol); i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}

