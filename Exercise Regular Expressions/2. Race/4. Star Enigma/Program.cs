using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4._Star_Enigma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var keyPattern = new Regex(@"[STARstar]");
            var attackPattern =
                new Regex(
                    @"@(?<name>[A-Za-z]+)[^@\-!,:>]*:([0-9]+)[^@\-!,:>]*!(?<command>A|D)![^@\-!,:>]*->([0-9]+)");

            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();

            var numberOfInput = int.Parse(Console.ReadLine());

            for (var i = 0; i < numberOfInput; i++)
            {
                var messageToDecrypt = Console.ReadLine();
                var decryptedMessage = DecryptMessage(messageToDecrypt, keyPattern);
                var attackPlans = attackPattern.Match(decryptedMessage);

                if (attackPlans.Success)
                {
                    var planetName = attackPlans.Groups["name"].Value;
                    var command = attackPlans.Groups["command"].Value;

                    if (command == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine("-> " + planet);
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine("-> " + planet);

            }
        }

        public static string DecryptMessage(string messageToDecrypt, Regex keyPattern)
        {
            var decryptedMessage = "";

            var countOfLetters = keyPattern.Matches(messageToDecrypt).Count;
            
            foreach (var symbol in messageToDecrypt)
            {
                decryptedMessage += (char)(symbol - countOfLetters);
            }

            return decryptedMessage;
        }
    }
}
