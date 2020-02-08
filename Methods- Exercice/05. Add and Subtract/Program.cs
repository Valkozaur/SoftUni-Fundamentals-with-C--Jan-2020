using System;
using System.Linq;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            AddFirstTwo(firstNum, secondNum, thirdNum);

        }

        static void AddFirstTwo(int firstNum, int secondNum, int thirdNum)
        { 
            int result = firstNum + secondNum;
            SubstractThirdFromSum(thirdNum, result);
        }

        static void SubstractThirdFromSum(int thirdNum, int sum)
        {
            int result = sum - thirdNum;
            Print(result);
        }

        static void Print(int result)
        {
            Console.WriteLine(result);
        }
    }
}
