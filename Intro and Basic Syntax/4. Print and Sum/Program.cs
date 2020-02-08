using System;
using System.Linq;

namespace _4._Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var password = String.Empty;

            for (int i = username.Length - 1; i <= 0; i++)
            {
                password += username[i];
            }

            while((username = Console.ReadLine()) != password)
            {
                Console.WriteLine("Incorrect password. Try again.");
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
