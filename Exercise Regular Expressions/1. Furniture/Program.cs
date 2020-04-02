using System.Reflection.Metadata.Ecma335;

namespace _1._Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;


    public class Program
    {
        public static void Main()
        {
            var regexPattern = new Regex(@"^>>(?<furniture>\w+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)\b");
            var listOfBoughtFurniture = new List<string>();
            var totalSpendMoney = 0.0M;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                var match = regexPattern.Match(input);


                if (match.Success)
                {
                    
                    var furniture = match.Groups["furniture"].Value;
                    var price = decimal.Parse(match.Groups["price"].Value);
                    var quantity = int.Parse(match.Groups["quantity"].Value);

                    if (quantity < 0)
                    {
                        continue;
                    }

                    listOfBoughtFurniture.Add(furniture);
                    totalSpendMoney += price * quantity;
                }
            }
                
            Console.WriteLine("Bought furniture:");
            Console.WriteLine(String.Join(Environment.NewLine, listOfBoughtFurniture));
            Console.WriteLine($"Total money spend: {totalSpendMoney:F2}");
        }
    }
}
