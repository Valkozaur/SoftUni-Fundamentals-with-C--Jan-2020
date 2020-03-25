using System.Linq;

namespace _1.__Valid_Usernames
{
    using System;

    public class Program
    {
        public static void Main()
        {
            const string allowedSymbols = "-_";

            var usernameInput = Console.ReadLine()
                .Split(", ");

            foreach (var username in usernameInput)
            {
                var nameIsValid = true;

                foreach (var symbol in username)
                {
                    if (username.Length >= 3 && username.Length <= 16)
                    {
                        if (!char.IsLetterOrDigit(symbol))
                        {
                            if (!allowedSymbols.Contains(symbol))
                            {
                                nameIsValid = false;
                            }
                        }
                    }
                    else
                    {
                        nameIsValid = false;
                        continue;
                    }
                }

                if (nameIsValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
