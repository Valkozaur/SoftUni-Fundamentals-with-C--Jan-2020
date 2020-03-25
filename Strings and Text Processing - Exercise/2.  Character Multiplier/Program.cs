using System;

namespace _2.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(" ");

            string firstString = strings[0];
            string secondString = strings[1];

            double sum = 0;
            int longerStringLenght = 0;

            bool firstIsLonger = false;

            if (firstString.Length > secondString.Length)
            {
                longerStringLenght = firstString.Length;
                firstIsLonger = true;
            }
            else
            {
                longerStringLenght = secondString.Length;
            }



            for (int i = 0; i < longerStringLenght; i++)
            {
                if (firstIsLonger)
                {
                    if (i < secondString.Length)
                    {
                        sum += firstString[i] * secondString[i];
                    }
                    else
                    {
                        sum += firstString[i];
                        continue;
                    }
                }
                else
                {
                    if (i < firstString.Length)
                    {
                        sum += firstString[i] * secondString[i];
                    }
                    else
                    {
                        sum += secondString[i];
                        continue;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}