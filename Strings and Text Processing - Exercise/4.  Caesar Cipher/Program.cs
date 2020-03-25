namespace _4.__Caesar_Cipher
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var textToEncode = Console.ReadLine();

            var stringBuilder = new StringBuilder();

            foreach (var symbol in textToEncode)
            {
                var encodedSymbol = (char)symbol + 3;
                char newSymbol = (char)encodedSymbol;
                stringBuilder.Append(newSymbol);
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
