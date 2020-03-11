using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();

            while (true)
            {
                var resourceType = Console.ReadLine();
                if (resourceType == "stop")
                {
                    break;
                }

                var resourceAmount = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resourceType))
                {
                    resources.Add(resourceType, 0);
                }

                resources[resourceType] += resourceAmount;
            }

            foreach (var (resource,amount) in resources)
            {
                Console.WriteLine($"{resource} -> {amount}");   
            }
        }
    }
}
