using System;
using System.Collections.Generic;
using System.Linq;

namespace More_Exercises_Shopping_Spree
{
    public class Program
    {
        //        Pesho=11;Gosho=4
        //Bread=10;Milk=2;
        //Pesho Bread
        //Gosho Milk
        //Gosho Milk
        //Pesho
        public static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            var peopleInput = Console.ReadLine()
                .Split(new char[] { '=', ';' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i < peopleInput.Length; i += 2)
            {
                var personName = peopleInput[i - 1];
                var personMoney = int.Parse(peopleInput[i]);

                var person = new Person();
                person.Name = personName;
                person.Money = personMoney;
                person.ShoppingBag = new List<Product>();

                people.Add(person);
            }

            var productsInput = Console.ReadLine()
                .Split(new char[] { '=', ';' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i < productsInput.Length; i += 2)
            {
                var productName = productsInput[i - 1];
                var price = double.Parse(productsInput[i]);

                var product = new Product();
                product.ProductName = productName;
                product.Price = price;

                products.Add(product);
            }

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(" ");
                if (input[0] == "END")
                {
                    break;
                }

                var personName = input[0];
                var productName = input[1];

                var person = people.FirstOrDefault(x => x.Name == personName);
                var product = products.FirstOrDefault(x => x.ProductName == productName);

                if (person != null && product != null)
                {
                    var personMoney = person.Money;
                    var productPrice = product.Price;

                    if (personMoney >= productPrice)
                    {
                        Console.WriteLine($"{person.Name} bought {product.ProductName}");
                        person.ShoppingBag.Add(product);
                        person.Money -= product.Price;
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.ProductName}");
                    }
                }
            }

            foreach (var person in people)
            {
                if (person.ShoppingBag.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - " + String.Join(", ", person.ShoppingBag.Select(x => $"{x.ProductName}")));
                }
            }
        }
    }
}
