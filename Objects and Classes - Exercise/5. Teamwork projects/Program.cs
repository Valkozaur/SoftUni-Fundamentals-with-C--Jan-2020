using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_projects
{
    class Program
    {
        static void Main()
        {

            var teams = new List<Team>();

            var countOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTeams; i++)
            {
                var teamCreation = Console.ReadLine()
                    .Split("-");
                var creator = teamCreation[0];
                var teamName = teamCreation[1];

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(x => x.TeamCreator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                var team = new Team(teamName, creator);
                team.TeamMembers = new List<string>();

                teams.Add(team);
                Console.WriteLine($"Team {team.TeamName} has been created by {team.TeamCreator}!");
            }

            while (true)
            {

                var command = Console.ReadLine();
                if (command == "end of assignment")
                {
                    break;
                }

                var teamBuilding = command
                    .Split("->");
                var newMember = teamBuilding[0];
                var teamName = teamBuilding[1];

                if (!teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(x => x.TeamMembers.Contains(newMember)) || teams.Any(x => x.TeamCreator == newMember))
                {
                    Console.WriteLine($"Member {newMember} cannot join team {teamName}!");
                    continue;
                }

                int teamIndex = teams.IndexOf
                    (teams.FirstOrDefault(x => x.TeamName == teamName));

                teams[teamIndex].TeamMembers.Add(newMember);
            }


            var teamsToDisband = teams
                .Where(x => x.TeamMembers.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            foreach (var team in teamsToDisband)
            {
                teams.RemoveAll(x => x.TeamName == team.TeamName);
            }

            teams = teams
                .OrderByDescending(x => x.TeamMembers.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            foreach (var team in teams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.TeamCreator}");
                foreach (var member in team.TeamMembers.OrderBy(x => x))
                {

                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {

                Console.WriteLine($"{team.TeamName}");
            }
        }
    }

    public class Team
    {
        public Team(string teamName, string teamCreator)
        {
            this.TeamName = teamName;
            this.TeamCreator = teamCreator;
        }

        public string TeamName { get; set; }

        public string TeamCreator { get; set; }

        public List<string> TeamMembers { get; set; }
    }
}