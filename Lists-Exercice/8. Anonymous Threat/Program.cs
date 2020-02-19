using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine()
                .Split(" ")
                .ToList();

            while (true)
            {
                var commandArgs = Console.ReadLine()
                    .Split(" ");
                var action = commandArgs[0];

                if (action == "3:1")
                {
                    break;
                }

                if (action == "merge")
                {
                    var startIndex = int.Parse(commandArgs[1]);
                    var endIndex = int.Parse(commandArgs[2]);
                    MergeElements(data, startIndex, endIndex);
                }
                else if (action == "divide")
                {
                    var indexToDivide = int.Parse(commandArgs[1]);
                    var participations = int.Parse(commandArgs[2]);
                    DivideElements(data, indexToDivide, participations);
                }
            }

            Console.WriteLine(String.Join(" ", data));
        }

        private static void DivideElements(List<string> data, int indexToDivide, int participations)
        {
            var elementToDivide = data[indexToDivide];
            data[indexToDivide] = null;

            var dividedElement = new List<string>();
            var participationLenght = elementToDivide.Length / participations;

            int currentChar = 0;

            for (int i = 0; i < participations; i++)
            {
                if (i + 1 == participations && elementToDivide.Length % participations != 0)
                {
                    dividedElement.Add(elementToDivide.Substring(currentChar));
                    break;
                }

                dividedElement.Add(elementToDivide.Substring(currentChar, participationLenght));

                currentChar += participationLenght;
            }

            data.InsertRange(indexToDivide, dividedElement);
            data.RemoveAll(x => x == null);
        }

        private static void MergeElements(List<string> data, int startIndex, int endIndex)
        {
            var sb = new StringBuilder();
            var beginIndex = -1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (IndexIsValid(data, i))
                {
                    if (beginIndex == -1)
                    {
                        beginIndex = i;
                    }

                    sb.Append(data[i]);
                    data[i] = null;
                }
            }
            if (beginIndex == -1)
            {
                return;
            }
            data[beginIndex] = sb.ToString();
            data.RemoveAll(v => v == null);
        }
        static bool IndexIsValid(List<string> data, int index)
        {
            return 0 <= index && index < data.Count;
        }
    }
}

