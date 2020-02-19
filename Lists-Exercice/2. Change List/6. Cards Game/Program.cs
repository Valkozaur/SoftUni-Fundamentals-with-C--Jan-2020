using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayerHandInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var firstPlayerHand = new Queue<int>(firstPlayerHandInput);

            var secondPlayerHandInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var secondPlayerHand = new Queue<int>(secondPlayerHandInput);

            while (true)
            {
                int firstPlayerCard = firstPlayerHand.Dequeue();
                int secondPlayerCard = secondPlayerHand.Dequeue();

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerHand.Enqueue(firstPlayerCard);
                    firstPlayerHand.Enqueue(secondPlayerCard);
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    secondPlayerHand.Enqueue(secondPlayerCard);
                    secondPlayerHand.Enqueue(firstPlayerCard);
                }

                if (secondPlayerHand.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstPlayerHand.Sum()}");
                    break;
                }
                else if (firstPlayerHand.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondPlayerHand.Sum()}");
                    break;
                }
            }
        }
    }
}
