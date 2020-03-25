using System.Text;

namespace _7.__String_Explosion
{
    using System;

    public class Program
    {
        public static void Main()
        {
            const char Explosive = '>';
            var explosiveField = Console.ReadLine();

            var result = new StringBuilder();
            var explosionCount = 0;

            for (var index = 0; index < explosiveField.Length; index++)
            {
                var currentField = explosiveField[index];
                if (currentField == Explosive)
                {
                    explosionCount += int.Parse(explosiveField[index + 1].ToString());
                    result.Append('>');
                    index++;
                }

                if (explosionCount != 0)
                {
                    explosionCount--;
                    continue;
                }

                result.Append(explosiveField[index]);
            }

            Console.WriteLine(result);
        }
    }
}
