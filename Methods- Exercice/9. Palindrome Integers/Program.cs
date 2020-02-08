using System;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                bool isPalindrome = PalindromeOrNot(input);

                Console.WriteLine(isPalindrome.ToString().ToLower());
            }
        }

        static bool PalindromeOrNot(string number)
        {
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length -i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
