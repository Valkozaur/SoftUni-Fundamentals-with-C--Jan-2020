using System;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var symbolsCount = new Dictionary<char, int>();

            foreach (var symbol in inputString)
            {
                if (symbol != ' ')
                {
                    if (!symbolsCount.ContainsKey(symbol))
                    {
                        symbolsCount.Add(symbol, 0);
                    }

                    symbolsCount[symbol]++;
                }                
            }

            foreach (var (symbol, count) in symbolsCount)
            {
                Console.WriteLine($"{symbol} -> {count}");
            }
        }
    }
}
