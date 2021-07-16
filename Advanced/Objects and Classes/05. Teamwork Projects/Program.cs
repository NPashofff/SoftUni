using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team()
        {
            Members = new List<string>();
        }

        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creator = input[0];
                string teamName = input[1];

                if (IsTeamExist(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (IsCeatorExist(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team
                {
                    Creator = creator,
                    TeamName = teamName,

                };

                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] parts = input.Split("->");

                string member = parts[0];
                string team = parts[1];

                Team existingTeam = GetTeamByName(teams, team);

                if (existingTeam == null)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }

                if (IsMemberExist(teams, member))
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                    continue;
                }

                existingTeam.Members.Add(member);
            }

            List<Team> sorted = teams                
                .OrderByDescending(x => x.Members.Count)                
                .ThenBy(x => x.TeamName)
                .ToList();

            List<Team> disbaned = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            foreach (var item in sorted)
            {
                if (item.Members.Count == 0)
                {
                    break;
                }

                Console.WriteLine(item.TeamName);
                Console.WriteLine($"- {item.Creator}");
               
                List<string> sortedMembers = item.Members
                    .OrderBy(x => x)
                    .ToList();

                foreach (var member in sortedMembers)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in disbaned)
            {
                Console.WriteLine(item.TeamName);
            }
        }        

        private static Team GetTeamByName(List<Team> teams, string team)
        {
            foreach (var item in teams)
            {
                if (item.TeamName == team )
                {
                    return item;
                }
            }
            return null;
        }

        private static bool IsMemberExist(List<Team> teams, string member)
        {
            foreach (var items in teams)
            {
                if (items.Creator == member)
                {
                    return true;
                }

                foreach (var mem in items.Members)
                {
                    if (mem == member)
                    {
                        return true;
                    }
                }                
            }

            return false;
        }

        private static bool IsTeamExist(List<Team> teams, string teamName)
        {
            foreach (var item in teams)
            {
                if (item.TeamName == teamName)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsCeatorExist(List<Team> teams, string creator)
        {
            foreach (var item in teams)
            {
                if (item.Creator == creator)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
