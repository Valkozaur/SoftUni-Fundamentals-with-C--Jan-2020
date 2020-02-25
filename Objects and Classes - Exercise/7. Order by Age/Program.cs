using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    public class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var people = new List<Person>();
            
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var splittedInput = input
                    .Split(" ");

                var name = splittedInput[0];
                var ID = splittedInput[1];
                var age = int.Parse(splittedInput[2]);

                var person = new Person();
                person.Name = name;
                person.ID = ID;
                person.Age = age;

                people.Add(person);
            }

            foreach (var person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
