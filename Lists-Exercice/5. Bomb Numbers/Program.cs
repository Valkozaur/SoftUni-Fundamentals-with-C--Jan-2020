using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            var bombAndPower = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            var bomb = bombAndPower[0];
            var power = bombAndPower[1];

            while (true)
            {
                var bombIndex = numbers.IndexOf(bomb);
                if (bombIndex == -1)
                {
                    break;
                }

                ExplosionToTheLeft(numbers, power, bombIndex);
                numbers[bombIndex] = -1;
                ExplosionToTheRight(numbers, power, bombIndex);

                numbers.RemoveAll(x => x == -1);
            }

            Console.WriteLine(numbers.Sum());
        }

        private static void ExplosionToTheLeft(List<int> numbers, int power, int bombIndex)
        {
            for (int i = power; i > 0; i--)
            {
                var indexToDetonate = bombIndex - i;
                if (IndexIsValid(numbers, indexToDetonate))
                {
                    numbers[indexToDetonate] = -1;
                }
            }
        }

        private static void ExplosionToTheRight(List<int> numbers, int power, int bombIndex)
        {
            for (int i = 1; i <= power; i++)
            {
                var indexToDetonate = bombIndex + i;
                if (IndexIsValid(numbers, indexToDetonate))
                {
                    numbers[indexToDetonate] = -1;
                }
            }
        }

        static bool IndexIsValid (List<int> numbers, int index)
        {
            return 0 <= index && index < numbers.Count;
        }
    }
}
