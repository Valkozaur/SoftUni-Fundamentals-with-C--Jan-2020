namespace _3._Hero_Recruitment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var heroes = new List<Hero>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var arguments = input
                    .Split(" ");

                var command = arguments[0];
                var heroName = arguments[1];

                switch (command)
                {
                    case "Enroll":
                        if (!heroes.Any(x => x.Name == heroName))
                        {
                            heroes.Add(new Hero(heroName));
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }
                        break;

                    case "Learn":
                        var spell = arguments[2];

                        var hero = heroes.FirstOrDefault(x => x.Name == heroName);
                        if (hero == default)
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                            continue;
                        }

                        if (!hero.SpellBook.Contains(spell))
                        {
                            hero.SpellBook.Add(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has already learnt {spell}.");
                        }

                        break;

                    case "Unlearn":
                        spell = arguments[2];

                        hero = heroes.FirstOrDefault(x => x.Name == heroName);
                        if (hero == default)
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                            continue;
                        }

                        if (hero.SpellBook.Contains(spell))
                        {
                            hero.SpellBook.Remove(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spell}.");
                        }
                        break;
                }
            }

            Console.WriteLine("Heroes:");
            foreach (var hero in heroes.OrderBy(x => x.SpellBook.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(hero);
            }
        }
    }
}
