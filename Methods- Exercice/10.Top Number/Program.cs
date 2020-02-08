using System;
using System.Linq;

namespace _10.Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberInput; i++)
            {
                bool isDivisibleByEight = IsDivisibleByEight(i);
                bool holdsAnOddDigit = HoldsAnOddDigit(i);

                if (isDivisibleByEight && holdsAnOddDigit)
                {
                    Console.WriteLine(i);
                }
            }


        }

        static bool IsDivisibleByEight(int number)
        {
            string numberAsString = number.ToString();
            int sum = 0;

            while(number > 0)
            {
                int currentNumber = number % 10;
                number /= 10;
                sum += currentNumber;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool HoldsAnOddDigit(int number)
        {
            string numberAsString = number
                .ToString();
            string oddDigits = "13579";

            for (int i = 0; i < numberAsString.Length; i++)
            {
                if (oddDigits.Contains(numberAsString[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
