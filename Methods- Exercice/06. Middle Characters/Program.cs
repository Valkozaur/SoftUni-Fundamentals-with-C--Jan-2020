using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            PrintMiddleChars(input);
        }

        static void PrintMiddleChars(string input)
        {
            var lenghtIsEven = input.Length % 2 == 0;
            if (lenghtIsEven)
            {
                for (int i = (input.Length / 2 - 1); i <= input.Length / 2; i++)
                {
                    Console.Write(input[i]);
                }
            }
            else
            {
                Console.WriteLine(input[input.Length / 2]);
            }
        }
    }
}
