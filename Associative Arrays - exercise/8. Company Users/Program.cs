namespace _8._Company_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var companiesAndEmployees = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                var splitInput = Console.ReadLine()
                    .Split(" -> ");
                if (splitInput[0] == "End")
                {
                    break;
                }

                var companyName = splitInput[0];
                var employeeId = splitInput[1];

                if (!companiesAndEmployees.ContainsKey(companyName))
                {
                    companiesAndEmployees.Add(companyName, new HashSet<string>());
                }

                companiesAndEmployees[companyName].Add(employeeId);
            }

            foreach (var (company, employees) in companiesAndEmployees.OrderBy(x => x.Key))
            {
                Console.WriteLine(company);
                foreach (var employeeId in employees)
                {
                    Console.WriteLine($"-- {employeeId}");   
                }
            }
        }
    }
}
