using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.__Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsAndGrades = new Dictionary<string, List<double>>();

            var numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                var name = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());

                if (!studentsAndGrades.ContainsKey(name))
                {
                    studentsAndGrades.Add(name, new List<double>());
                    studentsAndGrades[name].Add(grade);
                }
                else
                {
                    studentsAndGrades[name].Add(grade);
                }
            }

            studentsAndGrades = studentsAndGrades
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var (name,grade) in studentsAndGrades)
            {
                Console.WriteLine($"{name} -> {grade.Average():F2}");
            }
        }
    }
}
