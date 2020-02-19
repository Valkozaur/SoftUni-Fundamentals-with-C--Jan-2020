using System;
using System.Collections.Generic;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesOfInput = int.Parse(Console.ReadLine());
            var guests = new HashSet<string>();

            for (int i = 0; i < linesOfInput; i++)
            {
                var commandArgs = Console.ReadLine()
                    .Split(" ", 2);

                var name = commandArgs[0];  
                var command = commandArgs[1];

                if (command == "is going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guests.Add(name);
                }
                else if (command == "is not going!")
                {
                    if (!guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    guests.Remove(name);
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, guests));
        }
    }
}
