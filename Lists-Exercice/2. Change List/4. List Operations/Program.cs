using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(" ");

                string command = commandArgs[0];

                if (command == "End")
                {
                    break;
                }

                switch (command)
                {
                    case "Add":
                        AddNumberToTheList(numbers, commandArgs);
                        break;

                    case "Insert":
                        InsertNumberToIndex(numbers, commandArgs);
                        break;

                    case "Remove":
                        RemoveNumberAtIndex(numbers, commandArgs);
                        break;

                    case "Shift":
                        string direction = commandArgs[1];

                        if (direction == "left")
                        {
                            ShiftLeft(numbers, commandArgs);
                        }
                        else if(direction == "right")
                        {
                            ShiftRight(numbers, commandArgs);
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        private static void ShiftRight(List<int> numbers, string[] commandArgs)
        {
            int count = int.Parse(commandArgs[2]);
            count = count % numbers.Count;

            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

        private static void ShiftLeft(List<int> numbers, string[] commandArgs)
        {
            int count = int.Parse(commandArgs[2]);
            count = count % numbers.Count;

            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        static void RemoveNumberAtIndex(List<int> numbers, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[1]);
            if (IndexIsValid(numbers, index))
            {
                numbers.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        private static void InsertNumberToIndex(List<int> numbers, string[] commandArgs)
        {
            int number = int.Parse(commandArgs[1]);
            int index = int.Parse(commandArgs[2]);
            if (!IndexIsValid(numbers,index))
            {
                Console.WriteLine("Invalid index");
                return;
            }
            numbers.Insert(index, number);
        }

        private static void AddNumberToTheList(List<int> numbers, string[] commandArgs)
        {
            int number = int.Parse(commandArgs[1]);
            numbers.Add(number);
        }

        static bool IndexIsValid(List<int> numbers, int index)
        {
            return 0 <= index && index < numbers.Count;
        }
    }
}
