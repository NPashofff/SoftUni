using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> passwordByContest =
                new Dictionary<string, string>();
            FillPasswordByContest(passwordByContest);
            SortedDictionary<string, Dictionary<string, int>> userByContest =
                new SortedDictionary<string, Dictionary<string, int>>();
            FillUserByContest(passwordByContest, userByContest);
            string bestUser = "";
            int bestPoint = 0;

            foreach (var item in userByContest)
            {
                int sum = 0;
                foreach (var user in item.Value)
                {
                    sum += user.Value;
                }

                if (sum > bestPoint)
                {
                    bestPoint = sum;
                    bestUser = item.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoint} points.");
            Console.WriteLine("Ranking:");

            foreach (var item in userByContest)
            {
                Console.WriteLine(item.Key);
                foreach (var user in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {user.Key} -> {user.Value}");
                }
            }

        }

        private static void FillUserByContest(Dictionary<string, string> passwordByContest, SortedDictionary<string, Dictionary<string, int>> userByContest)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] parts = input.Split("=>");
                string contest = parts[0];
                string password = parts[1];
                string user = parts[2];
                int point = int.Parse(parts[3]);

                if (passwordByContest.ContainsKey(contest))
                {
                    if (passwordByContest[contest] == password)
                    {
                        if (!userByContest.ContainsKey(user))
                        {
                            userByContest.Add(user, new Dictionary<string, int>());
                        }

                        if (userByContest[user].ContainsKey(contest))
                        {
                            if (userByContest[user][contest] < point)
                            {
                                userByContest[user][contest] = point;
                            }
                        }
                        else
                        {
                            userByContest[user].Add(contest, point);
                        }

                    }
                }
            }
        }

        private static void FillPasswordByContest(Dictionary<string, string> passwordByContest)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] parts = input.Split(":");
                string contest = parts[0];
                string pasword = parts[1];

                passwordByContest.Add(contest, pasword);
            }
        }
    }
}
