using System.Linq;
using System.Text;

namespace _6._Replace_Repeating_Chars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            char previousLetter = default;

            var result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var currentLetter = input[i];
                if (currentLetter != previousLetter)
                {
                    result.Append(currentLetter);
                    previousLetter = currentLetter;
                }
            }

            Console.WriteLine(result);
        }
    }
}
