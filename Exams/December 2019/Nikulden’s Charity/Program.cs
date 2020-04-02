using System.Linq;

namespace Nikulden_s_Charity
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var encryptedInput = Console.ReadLine();

            while (true)
            {
                var decryptingCommands = Console.ReadLine();
                if (decryptingCommands == "Finish")
                {
                    break;
                }

                var commandsSplit = decryptingCommands
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var command = commandsSplit[0];

                switch (command)
                {
                    case "Replace":
                        var charToReplace = char.Parse(commandsSplit[1]);
                        var newChar = char.Parse(commandsSplit[2]);

                        encryptedInput = encryptedInput
                            .Replace(charToReplace, newChar);

                        Console.WriteLine(encryptedInput);
                        break;

                    case "Cut":
                        var startIndex = int.Parse(commandsSplit[1]);
                        var endIndex = int.Parse(commandsSplit[2]);

                        if (IndexIsValid(startIndex, encryptedInput) && IndexIsValid(endIndex, encryptedInput))
                        {
                            encryptedInput = encryptedInput.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(encryptedInput);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        break;

                    case "Make":
                        var upperOrLower = commandsSplit[1];

                        if (upperOrLower == "Upper")
                        {
                            encryptedInput = encryptedInput.ToUpper();
                        }
                        else
                        {
                            encryptedInput = encryptedInput.ToLower();
                        }

                        Console.WriteLine(encryptedInput);
                        break;


                    case "Check":

                        var @string = commandsSplit[1];

                        if (encryptedInput.Contains(@string))
                        {
                            Console.WriteLine($"Message contains {@string}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {@string}");
                        }

                        break;

                    case "Sum":
                        startIndex = int.Parse(commandsSplit[1]);
                        endIndex = int.Parse(commandsSplit[2]);


                        if (IndexIsValid(startIndex, encryptedInput) && IndexIsValid(endIndex, encryptedInput))
                        {
                            var substring = encryptedInput.Substring(startIndex, endIndex - startIndex + 1);
                            var sum = substring.Sum(x => (int)x);
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        break;
                }
            }
        }

        public static bool IndexIsValid(int index, string message) => index >= 0 && index < message.Length;
    }
}
