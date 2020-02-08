using System;

namespace Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var stageOfLife = String.Empty;

            if (input >= 0 && input <= 2)
            {
                stageOfLife = "baby";
            }
            else if (input <= 13)
            {
                stageOfLife = "child";
            }
            else if (input <= 19)
            {
                stageOfLife = "teenager";
            }
            else if (input <= 65)
            {
                stageOfLife = "adult";
            }
            else if(input > 65)
            {
                stageOfLife = "elder";
            }

            Console.WriteLine(stageOfLife);
        }
    }
}
