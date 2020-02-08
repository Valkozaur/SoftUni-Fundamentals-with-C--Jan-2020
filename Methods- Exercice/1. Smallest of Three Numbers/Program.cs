using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            FillingUpTheArray(numbers);
            var smallestNumber = ReturnTheSmallestNumber(numbers);
            Console.WriteLine(smallestNumber);
        }
            
        private static void FillingUpTheArray(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReturnAnInteger();
            }
        }

        static int ReturnAnInteger()
        {
                int currentNumber = int.Parse(Console.ReadLine());
                return currentNumber;
        }

        private static int ReturnTheSmallestNumber (int[] numbers)
        {
            var minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }
    }
}
