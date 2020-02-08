using System;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            var firstArray = new int[numberOfLines];
            var secondArray = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                var inputArray = Console.ReadLine()
                    .Split();

                if (i % 2 == 0)
                {
                    firstArray[i] = int.Parse(inputArray[0]);
                    secondArray[i] = int.Parse(inputArray[1]);
                }
                else
                {
                    firstArray[i] = int.Parse(inputArray[1]);
                    secondArray[i] = int.Parse(inputArray[0]);
                }
            }

            Console.WriteLine(String.Join(" ", firstArray) + Environment.NewLine
                + String.Join(" ", secondArray));
        }
    }
}
