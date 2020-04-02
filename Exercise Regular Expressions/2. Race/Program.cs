namespace _2._Race
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var namePattern = new Regex(@"[A-Za-z]");
            var kmRunPattern = new Regex(@"\d");

            var namesAndKilometers = Console.ReadLine()
                .Split(", ")
                .ToDictionary(x => x, x => 0);

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "end of race")
                {
                    break;
                }

                var name = String.Empty;
                foreach (var letter  in namePattern.Matches(inputLine))
                {
                    name += letter;
                }

                if (namesAndKilometers.ContainsKey(name))
                {
                    foreach (var kmMatch in kmRunPattern.Matches(inputLine))
                    {
                        namesAndKilometers[name] += int.Parse(kmMatch.ToString());
                    }
                }
            }

            int counter = 1;
            foreach (var racer in namesAndKilometers.OrderByDescending(x => x.Value).Take(3))
            {
                string place = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";

                Console.WriteLine($"{counter}{place} place: {racer.Key}");

                counter++;
            }
        }
    }
}
