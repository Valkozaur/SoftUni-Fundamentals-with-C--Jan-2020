using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInt = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine(String.Join(" ", listOfInt));
                    break;
                }

                var splittedInput = input
                    .Split(" ");
                var command = splittedInput[0];
                var element = int.Parse(splittedInput[1]);

                if (command == "Delete")
                {
                    listOfInt.RemoveAll(x => x == element);
                }
                else if(command == "Insert")
                {
                    var position = int.Parse(splittedInput[2]);
                    listOfInt.Insert(position, element);
                }
            }
        }
    }
}
