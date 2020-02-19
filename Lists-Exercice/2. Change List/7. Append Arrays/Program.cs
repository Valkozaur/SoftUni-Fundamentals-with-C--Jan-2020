using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arraysToAppend = Console.ReadLine()
                .Split("|")
                .Reverse()
                .ToList();

            var listToPrint = new List<string>();
            foreach (var array in arraysToAppend)
            {
                var splittedArray = array
                    .Split(' ', 
                    StringSplitOptions.RemoveEmptyEntries);

                listToPrint.AddRange(splittedArray);
            }

            Console.WriteLine(String.Join(" ", listToPrint));
        }
    }
}
