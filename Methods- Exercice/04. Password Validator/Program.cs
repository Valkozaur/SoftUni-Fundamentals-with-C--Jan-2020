using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();
            var lenghtIsValid = LenghtIsValid(password);
            var onlyLettersAndDigit = OnlyLettersAndDigits(password);
            var hasMinTwoDigits = HaveAtleastTwoDigits(password);

            if (lenghtIsValid && onlyLettersAndDigit && hasMinTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!lenghtIsValid)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!onlyLettersAndDigit)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!hasMinTwoDigits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            
        }

        static bool LenghtIsValid(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }

        static bool OnlyLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool HaveAtleastTwoDigits(string password)
        {
            var digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digitCounter++;
                }
                if (digitCounter == 2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
