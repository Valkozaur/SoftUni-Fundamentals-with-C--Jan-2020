using System;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _3._SoftUni_Bar_Income
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var orderPattern = new Regex(@".*%(?<customer>[A-Z]{1}[a-z]+)%.*<(?<product>[A-Z]{1}[a-z]+)>.*\|(?<quantity>\d+)\|.*(?<price>\d+\.?\d*).*\$");
            //var namePattern = new Regex(@"[A-Z]{1}[a-z]+");
            var productPattern = new Regex("");
            var totalCapital = 0.0;
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end of shift")
                {
                    break;
                }

                var orderMatch = orderPattern.Match(inputLine);
                if (orderMatch.Success)
                {
                    var customerName = orderMatch.Groups["customer"].Value;
                    var product = orderMatch.Groups["product"].Value;
                    var quantity = int.Parse(orderMatch.Groups["quantity"].Value);
                    var price = double.Parse(orderMatch.Groups["price"].Value);

                    Console.WriteLine($"{customerName}: {product} - {quantity * price}");
                    totalCapital += quantity * price;   
                }
            }


        }
    }
}
