using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var examsArchives = new Dictionary<string, int>();
            var countOfSubmisions = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "exam finished")
            {
                string[] commandArgs = command
                    .Split("-");
                string username = commandArgs[0];

                if (commandArgs[1] == "banned")
                {
                    if (examsArchives.ContainsKey(username))
                    {
                        examsArchives.Remove(username);
                    }
                }
                else
                {
                    string language = commandArgs[1];
                    int points = int.Parse(commandArgs[2]);

                    if (!examsArchives.ContainsKey(username))
                    {
                        examsArchives.Add(username, points);
                        if (!countOfSubmisions.ContainsKey(language))
                        {
                            countOfSubmisions.Add(language, 0);
                        }
                        countOfSubmisions[language]++;
                    }
                    else if(examsArchives.ContainsKey(username))
                    {
                        if (examsArchives[username] < points)
                        {
                            examsArchives[username] = points;
                        }

                        if (!countOfSubmisions.ContainsKey(language))
                        {
                            countOfSubmisions.Add(language, 0);
                        }
                        countOfSubmisions[language]++;
                    }                   
                }
            }

            examsArchives = examsArchives
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine
                ("Results:" + Environment.NewLine +
                String.Join(Environment.NewLine, examsArchives.Select(
                x => $"{x.Key} | {x.Value}")));

            countOfSubmisions = countOfSubmisions
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine
                ("Submissions:" + Environment.NewLine +
                String.Join(Environment.NewLine, countOfSubmisions.Select(
                    x => $"{x.Key} - {x.Value}")));
        }
    }
}
