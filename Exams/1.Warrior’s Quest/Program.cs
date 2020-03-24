using System;
using System.Text;

namespace _1.Warrior_s_Quest
{
    public class Program
    {
        public static void Main()
        {
            var skillToDeciphered = Console.ReadLine();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "For Azeroth")
                {
                    break;
                }

                var arguments = input
                    .Split(" ");

                var command = arguments[0];

                if (command == "GladiatorStance")
                {
                    skillToDeciphered = skillToDeciphered.ToUpper();
                    Console.WriteLine(skillToDeciphered);
                }
                else if (command == "DefensiveStance")
                {
                    skillToDeciphered = skillToDeciphered.ToLower();
                    Console.WriteLine(skillToDeciphered);
                }
                else if (command == "Dispel")
                {
                    var index = int.Parse(arguments[1]);
                    var letter = char.Parse(arguments[2]);

                    if (index >= 0 && index < skillToDeciphered.Length)
                    {
                        char[] temp = skillToDeciphered.ToCharArray();
                        temp[index] = letter;

                        skillToDeciphered = new string(temp);

                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }
                else if (command == "Target")
                {
                    var action = arguments[1];
                    var oldSubstring = arguments[2];
                    if (skillToDeciphered.Contains(oldSubstring))
                    {
                        if (skillToDeciphered.Contains(oldSubstring))
                        {
                            if (action == "Change")
                            {
                                var newSubstring = arguments[3];
                                skillToDeciphered = skillToDeciphered.Replace(oldSubstring, newSubstring);
                                Console.WriteLine(skillToDeciphered);

                            }
                            else if (action == "Remove")
                            {
                                var index = skillToDeciphered.IndexOf(oldSubstring);

                                skillToDeciphered = skillToDeciphered.Remove(index, oldSubstring.Length);
                                Console.WriteLine(skillToDeciphered);

                            }
                            else
                            {
                                Console.WriteLine("Command doesn't exist!");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }
        }
    }
}
