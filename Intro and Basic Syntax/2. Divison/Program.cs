using System;

namespace _2._Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberInput = int.Parse(Console.ReadLine());

            if (numberInput % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if(numberInput % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if(numberInput % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if(numberInput % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if(numberInput % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
