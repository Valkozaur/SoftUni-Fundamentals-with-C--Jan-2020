namespace Nikulden_s_meals
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var guestsAndMeals = new Dictionary<string, List<string>>();
            var countOfUnlikedMeals = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }

                var splitInput = input
                    .Split("-");

                var command = splitInput[0];
                var guest = splitInput[1];
                var meal = splitInput[2];

                if (command == "Like")
                {
                    if (!guestsAndMeals.ContainsKey(guest))
                    {
                        guestsAndMeals.Add(guest, new List<string>());
                    }

                    if (!guestsAndMeals[guest].Contains(meal))
                    {
                        guestsAndMeals[guest].Add(meal);
                    }
                }
                else if(command == "Unlike")
                {
                    if (!guestsAndMeals.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                        continue;
                    }

                    if (!guestsAndMeals[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        continue;
                    }

                    Console.WriteLine($"{guest} doesn't like the {meal}.");
                    guestsAndMeals[guest].Remove(meal);
                    countOfUnlikedMeals++;
                }
            }

            guestsAndMeals = guestsAndMeals
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(k => k.Key, v => v.Value);


            foreach (var (name, meals) in guestsAndMeals)
            {
                Console.Write($"{name}:");
                if (meals.Count != 0)
                { 
                    Console.Write(" " + string.Join(", ", meals));
                }

                    Console.WriteLine();
            }

            Console.WriteLine($"Unliked meals: {countOfUnlikedMeals}");
        }
    }
}
