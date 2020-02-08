using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            PrintMatrix(number);
        }

        static void PrintMatrix(int number)
        {
            PrintRows(number);
        }

        static void PrintRows(int number)
        {
            for (int currentLine = 0; currentLine < number; currentLine++)
            {
                PrintLines();

                for (int currentRow = 0; currentRow < number; currentRow++)
                {
                    Console.Write(number + " ");
                }
            }
        }

        static void PrintLines()
        {
            Console.WriteLine();
        }
    }
}
