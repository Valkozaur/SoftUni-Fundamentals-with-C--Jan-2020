using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var uniqueUser = new Dictionary<string, string>();
            var forceSidesUsers = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    string[] commandArgs = command
                        .Split(" | ");

                    string side = commandArgs[0];
                    string user = commandArgs[1];

                    if (!uniqueUser.ContainsKey(user))
                    {
                        uniqueUser.Add(user, side);

                        if (!forceSidesUsers.ContainsKey(side))
                        {
                            forceSidesUsers[side] = new List<string>();
                            forceSidesUsers[side].Add(user);
                        }
                        else
                        {
                            forceSidesUsers[side].Add(user);
                        }
                    }
                }
                else
                {
                    string[] commandArgs = command
                   .Split(" -> ");

                    string user = commandArgs[0];
                    string side = commandArgs[1];

                    if (uniqueUser.ContainsKey(user))
                    {
                        string currentSide = uniqueUser[user];

                        Console.WriteLine($"{user} joins the {side} side!");

                        forceSidesUsers[currentSide].Remove(user);
                        forceSidesUsers[side].Add(user);
                    }
                    else
                    {
                        uniqueUser.Add(user, side);

                        if (!forceSidesUsers.ContainsKey(side) )
                        {
                            Console.WriteLine($"{user} joins the {side} side!");

                            forceSidesUsers[side] = new List<string>();
                            forceSidesUsers[side].Add(user);
                        }
                        else
                        {
                            Console.WriteLine($"{user} joins the {side} side!");
                            forceSidesUsers[side].Add(user);
                        }
                    }
                }
            }

            forceSidesUsers = forceSidesUsers
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var side in forceSidesUsers)
            {
                
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                side.Value.Sort();

                for (int i = 0; i < side.Value.Count; i++)
                {
                    Console.WriteLine($"! {side.Value[i]}");
                }
            }
        }
    }
}
