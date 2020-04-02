using System.Linq;

namespace _5._Nether_Realms
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var demonsHealthPattern = new Regex(@"[^+\-\*\/.0-9]");
            var attackDamagePattern = new Regex(@"([+-]?[0-9]+\.?[0-9]+|[+-]?[0-9])");
            var arithmeticSymbols = new Regex(@"(\*|\/)"); 

            var demonList = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x);

            foreach (var demon in demonList)
            {
                var demonName = demon.Trim();
                var demonHealth = DemonHealth(demonName, demonsHealthPattern);
                var attackDamage = AttackDamage(demonName, attackDamagePattern, arithmeticSymbols);
                Console.WriteLine($"{demonName} - {demonHealth} health, {attackDamage:F2} damage");
            }
        }

        public static int DemonHealth(string demonName, Regex demonsHealthPattern)
        {
            var demonsHealth = 0;

            var healthMatches = demonsHealthPattern.Matches(demonName);
            foreach (var match in healthMatches)
            {
                demonsHealth += char.Parse(match.ToString());
            }

            return demonsHealth;
        }

        public static double AttackDamage(string demonName, Regex attackDamagePattern, Regex arithmeticSymbols)
        {
            var attackDamage = 0.0;

            var digitsMatch = attackDamagePattern.Matches(demonName);

            foreach (var match in digitsMatch)
            {
                var currentNumber = double.Parse(match.ToString());
                attackDamage += currentNumber;
            }

            var arithmeticOperations = arithmeticSymbols.Matches(demonName);

            foreach (var match in arithmeticOperations)
            {
                if (match.ToString() == "/")
                {
                    attackDamage /= 2;
                }
                else
                {
                    attackDamage *= 2;
                }
            }

            return attackDamage;
        }
    }
}
