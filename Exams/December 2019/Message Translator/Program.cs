using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var validMessagePattern = new Regex(@"^!([A-Z]{1}[a-z]{2,})!:\[([A-Za-z]{8,})\]$");

            var numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                var messageInput = Console.ReadLine();

                var match = validMessagePattern.Match(messageInput);

                if (match.Success)
                {
                    var command = match.Groups[1].Value;
                    var message = match.Groups[2].Value;

                    var numbers = new List<int>();

                    foreach (var letter in message)
                    {
                        numbers.Add((int)letter);
                    }

                    Console.WriteLine($"{command}: " + string.Join(" ", numbers));
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
