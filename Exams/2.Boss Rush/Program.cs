using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.Boss_Rush
{
    public class Program
    {
        public static void Main()
        {
            var pattern = new Regex(@"\|([A-Z]{4,})\|:(#)([A-Za-z]+ [A-Za-z]+)\2");

            var numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                var input = Console.ReadLine();

                if (pattern.IsMatch(input))
                {
                    var bossNameMatch = pattern.Match(input);

                    var bossName = bossNameMatch.Groups[1].Value;
                    var bossTitle = bossNameMatch.Groups[3].Value;
                    
                    var stringBuilder = new StringBuilder();
                    stringBuilder.AppendLine($"{bossName}, The {bossTitle}");
                    stringBuilder.AppendLine($">> Strength: {bossName.Length}");
                    stringBuilder.Append($">> Armour: {bossTitle.Length}");

                    Console.WriteLine(stringBuilder);
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
