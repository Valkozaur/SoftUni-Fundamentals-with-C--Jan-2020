namespace _05._Multiply_Big_Number
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var bigNumber = Console.ReadLine();
            var zeroCount = 0;
            for (var i = 0; i < bigNumber.Length; i++)
            {
                if (bigNumber[i] == '0')
                {
                    zeroCount++;
                }
                else
                {
                    break;
                }

            }
                bigNumber = bigNumber.Remove(0, zeroCount);

            var smallNumber = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            var onMind = 0;
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                var lastNumber = int.Parse(bigNumber[i].ToString());
                if (lastNumber == 0)
                {
                    stack.Push(0);
                    continue;
                }

                if (smallNumber == 0)
                {
                    stack.Push(0);
                    break;
                }

                var multiplicationResult = lastNumber * smallNumber + onMind;
                if (multiplicationResult >= 10)
                {
                    var numberToWrite = multiplicationResult % 10;
                    if (numberToWrite >= 10)
                    {
                        onMind = multiplicationResult + numberToWrite / 10;
                        numberToWrite = numberToWrite % 10;
                        stack.Push(numberToWrite);
                        if (i == 0 && onMind != 0)
                        {
                            stack.Push(onMind);
                        }
                        continue;
                    }
                    stack.Push(numberToWrite);
                    onMind = multiplicationResult / 10;
                }
                else
                {
                    stack.Push(multiplicationResult);
                    onMind = 0;
                }

                if (i == 0 && onMind != 0)
                {
                    stack.Push(onMind);
                }

            }

            var result = String.Join("", stack);
            Console.WriteLine(result);
        }
    }
}
