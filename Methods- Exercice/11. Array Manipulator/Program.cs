using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._Array_Manipulator
{
    class Program
    {
        static int[] array;
        static void Main(string[] args)
        {
            array = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] splittedInput = input
                    .Split();

                string command = splittedInput[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(splittedInput[1]);
                        Exchange(index);
                        break;

                    case "max":
                    case "min":
                        string evenOrOdd = splittedInput[1];
                        index = MaxMinEvenOrOdd(command, evenOrOdd);

                        if (index != -1)
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;

                    case "first":
                        int count = int.Parse(splittedInput[1]);
                        if (count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        evenOrOdd = splittedInput[2];
                        string[] elementsToPrint = ReturnFirstCountElements(count, evenOrOdd);
                        if (elementsToPrint.Any())
                        {
                            elementsToPrint = elementsToPrint
                                .Where(x => x != null)
                                .ToArray();

                            Console.WriteLine("[" + String.Join(", ", elementsToPrint) + "]");
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                        break;

                    case "last":
                        count = int.Parse(splittedInput[1]);
                        if (count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        evenOrOdd = splittedInput[2];
                        elementsToPrint = ReturnLastCountElements(count, evenOrOdd)
                            .Reverse()
                            .ToArray();
                        if (elementsToPrint.Any())
                        {
                            elementsToPrint = elementsToPrint
                                .Where(x => x != null)
                                .ToArray();
                            Console.WriteLine('[' + String.Join(", ", elementsToPrint) + ']');
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine('[' + String.Join(", ", array) + ']');
        }
        private static void Exchange(int index)
        {
            if (0 <= index && index < array.Length)
            {
                List<int> tempArray = new List<int>();
                for (int i = index + 1; i < array.Length; i++)
                {
                    tempArray.Add(array[i]);

                }
                for (int i = 0; i <= index; i++)
                {
                    tempArray.Add(array[i]);
                }

                array = tempArray.ToArray();
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        private static int MaxMinEvenOrOdd(string command, string evenOrOdd)
        {
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                if (currentNum % 2 == 0 && evenOrOdd == "even")
                {
                    if (command == "max" && maxNum <= currentNum)
                    {
                        maxNum = currentNum;
                        index = i;
                    }

                    if (command == "min" && currentNum <= minNum)
                    {
                        minNum = currentNum;
                        index = i;
                    }
                }
                else if (currentNum % 2 == 1 && evenOrOdd == "odd")
                {
                    if (command == "max" && maxNum <= currentNum)
                    {
                        maxNum = currentNum;
                        index = i;
                    }

                    if (command == "min" && currentNum <= minNum)
                    {
                        minNum = currentNum;
                        index = i;
                    }
                }
            }
            return index;
        }

        private static string[] ReturnFirstCountElements(int count, string evenOrOdd)
        {
            int counter = 0;
            string[] elementsToReturn = new string[count];

            for (int i = 0; i < array.Length; i++)
            {
                if (evenOrOdd == "even" && array[i] % 2 == 0)
                {
                    elementsToReturn[counter] = array[i].ToString();
                    counter++;
                }
                else if (evenOrOdd == "odd" && array[i] % 2 == 1)
                {
                    elementsToReturn[counter] = array[i].ToString();
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            return elementsToReturn;
        }

        private static string[] ReturnLastCountElements(int count, string evenOrOdd)
        {
            int counter = 0;
            string[] elementsToReturn = new string[count];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (evenOrOdd == "even" && array[i] % 2 == 0)
                {
                    elementsToReturn[counter] = array[i].ToString();
                    counter++;
                }
                else if (evenOrOdd == "odd" && array[i] % 2 == 1)
                {
                    elementsToReturn[counter] = array[i].ToString();
                    counter++;
                }

                if (count == counter)
                {
                    break;
                }
            }

            return elementsToReturn;
        }
    }
}

