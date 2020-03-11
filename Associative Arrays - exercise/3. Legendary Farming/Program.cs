namespace _3._Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var neededAmount = 250;
            var materialsAndWeapons = new Dictionary<string, string>()
            {
                { "shards", "Shadowmourne"},
                { "fragments", "Valanyr"},
                { "motes", "Dragonwrath"}
            };
            var weaponObtained = false;

            var legendaryMaterial = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };
            
            var junk = new Dictionary<string, int>();
            while (true)
            {
                var splitInput = Console.ReadLine()
                    .Split(" ");

                for (var i = 1; i < splitInput.Length; i += 2)
                {
                    var quantitiy = int.Parse(splitInput[i - 1]);
                    var material = splitInput[i].ToLower();

                    if (materialsAndWeapons.ContainsKey(material))
                    {
                        legendaryMaterial[material] += quantitiy;

                        if (legendaryMaterial[material] >= neededAmount)
                        {
                            Console.WriteLine($"{materialsAndWeapons[material]} obtained!");
                            legendaryMaterial[material] -= neededAmount;
                            weaponObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }

                        junk[material] += quantitiy;
                    }
                }

                if (weaponObtained)
                {
                    break;
                }
            }

            legendaryMaterial = legendaryMaterial
                        .OrderByDescending(x => x.Value)
                        .ThenBy(x => x.Key)
                        .ToDictionary(x => x.Key, y => y.Value);

            junk = junk
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var (material, quantity) in legendaryMaterial)
            {
                Console.WriteLine($"{material}: {quantity}");
            }

            foreach (var (material, quantity) in junk)
            {
                Console.WriteLine($"{material}: {quantity}");
            }
        }
    }
}
