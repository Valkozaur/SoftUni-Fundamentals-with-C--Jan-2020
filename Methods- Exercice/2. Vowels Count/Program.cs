using System;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var volewsCount = ReturnNumberOfVolews(input);

            Console.WriteLine(volewsCount);
        }
        static int ReturnNumberOfVolews(string input)
        {
            var volewsCount = 0;
            var volews = "aAeEiIoOuU";

            for (var currentLetter = 0; currentLetter < input.Length; currentLetter++)
            {
                if (volews.Contains(input[currentLetter]))
                {
                    volewsCount++;
                }
            }

            return volewsCount;
        }
    }

}
