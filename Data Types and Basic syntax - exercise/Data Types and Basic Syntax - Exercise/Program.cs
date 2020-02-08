using System;
using System.Linq;
using System.Collections.Generic;

namespace Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tasks = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input
                     .Split(" ");

                string command = inputArgs[0];

                if (command != "Count")
                {
                    int index = int.Parse(inputArgs[1]);
                    bool indexExists = index >= 0 && index < tasks.Count;

                    if (command == "Complete")
                    {
                        if (indexExists)
                        {
                            tasks[index] = 0;
                        }
                    }
                    else if (command == "Change")
                    {
                        int time = int.Parse(inputArgs[2]);
                        if (time < 1 || time > 5)
                        {
                            break;
                        }
                        if (indexExists)
                        {
                            tasks[index] = time;
                        }
                    }
                    else if (command == "Drop")
                    {
                        if (indexExists)
                        {
                            tasks[index] = -1;
                        }
                    }
                }
                else
                {
                    string typeOfTasks = inputArgs[1];
                    switch (typeOfTasks)
                    {
                        case "Completed":
                            List<int> comlpeted = tasks.FindAll(x => x == 0);
                            int countOfCompletedTasks = comlpeted.Count;
                            Console.WriteLine(countOfCompletedTasks);
                            break;
                        case "Incompleted":
                            List<int> incompleted = tasks.FindAll(x => x > 0);
                            int countOfIncompleted = incompleted.Count;
                            Console.WriteLine(countOfIncompleted);
                            break;
                        case "Dropped":
                            List<int> dropped = tasks.FindAll(x => x == -1);
                            int countOfDropped = dropped.Count;
                            Console.WriteLine(countOfDropped);
                            break;
                    }
                }
            }
            List<int> incompleteItems = tasks.FindAll(x => x > 0);
            Console.WriteLine(String.Join(" ", incompleteItems));
        }
    }
}