using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var typeOfGroup = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();

            decimal pricePerPerson = 0m;
            decimal totalPrice = 0.0m;

            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45m;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80m;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46m;
                            break;
                    }

                    if (numberOfPeople >= 30)
                    {
                        pricePerPerson *= 0.85m;
                    }

                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.90m;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60m;
                            break;
                        case "Sunday":
                            pricePerPerson = 16m;
                            break;
                    }

                    if (numberOfPeople >= 100)
                    {
                        numberOfPeople -= 10;
                    }

                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15m;
                            break;
                        case "Saturday":
                            pricePerPerson = 20m;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50m;
                            break;
                    }

                    if (numberOfPeople >= 10 && numberOfPeople <= 20)
                    {
                        pricePerPerson *= 0.95m;
                    }
                    break;
            }

            totalPrice = numberOfPeople * pricePerPerson;

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
