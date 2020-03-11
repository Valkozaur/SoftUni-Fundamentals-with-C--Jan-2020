namespace _4._Orders
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var products = new List<Product>();

            while (true)
            {
                var splitInput = Console.ReadLine()
                    .Split(" ");
                if (splitInput[0] == "buy")
                {
                    break;
                }

                var productName = splitInput[0];
                var productPrice = double.Parse(splitInput[1]);
                var productQuantity = int.Parse(splitInput[2]);

                if (products.Any(x => x.Name == productName))
                {
                    var listedProduct = products.FirstOrDefault(x => x.Name == productName);
                    listedProduct.Quantity += productQuantity;
                    listedProduct.Price = productPrice;
                }
                else
                {
                    var product = new Product(productName, productPrice, productQuantity);
                    products.Add(product);
                }
            }

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
