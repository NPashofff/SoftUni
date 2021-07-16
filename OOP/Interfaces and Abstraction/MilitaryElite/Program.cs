using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] parts = input.Split(); // <---- sp.option ???

                string soldierTipe = parts[0];
                int id = int.Parse(parts[1]);
                string firstName = parts[2];
                string lastName = parts[3];

                if (soldierTipe == "Private")
                {
                    decimal salary = decimal.Parse(parts[4]);
                    Private @private = new Private(id, firstName, lastName, salary);
                    soldiers.Add(@private);
                }
                else if (soldierTipe == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(parts[4]);
                    List<Private> privates = new List<Private>();
                    for (int i = 5; i < parts.Length; i++)
                    {
                        int privateNum = int.Parse(parts[i]);
                        foreach (var item in soldiers)
                        {
                            if (item is Private && item.Id == privateNum)
                            {
                                privates.Add((Private)item);
                            }
                        }
                    }

                    LieutenantGeneral lieutenantGeneral =
                        new LieutenantGeneral(id, firstName, lastName, salary, privates);
                    soldiers.Add(lieutenantGeneral);
                }
                else if (soldierTipe == "Engineer")
                {
                    decimal salary = decimal.Parse(parts[4]);
                    string corps;
                    if (parts[5] == "Airforces" || parts[5] == "Marines")
                    {
                        corps = parts[5];
                    }
                    else
                    {
                        continue;
                    }

                    List<Repair> repairs = new List<Repair>();
                    for (int i = 6; i < parts.Length; i = i + 2)
                    {
                        string part = parts[i];
                        int hours = int.Parse(parts[i + 1]);
                        Repair repair = new Repair(part, hours);
                        repairs.Add(repair);
                    }
                    Engineer engineer =
                        new Engineer(id, firstName, lastName, salary, corps, repairs);
                    soldiers.Add(engineer);
                }
                else if (soldierTipe == "Commando")
                {
                    decimal salary = decimal.Parse(parts[4]);
                    string corps;
                    if (parts[5] == "Airforces" || parts[5] == "Marines")
                    {
                        corps = parts[5];
                    }
                    else
                    {
                       continue;
                    }
                    List<Mission> missions = new List<Mission>();
                    for (int i = 6; i < parts.Length; i = i + 2)
                    {
                        string name = parts[i];
                        string state = parts[i + 1];
                        if (state == "inProgress" || state == "Finished")
                        {
                            Mission mission = new Mission(name, state);
                            missions.Add(mission);
                        }                        
                    }

                    Commando commando = 
                        new Commando(id, firstName, lastName, salary, corps, missions);
                    soldiers.Add(commando);
                }
                else if (soldierTipe == "Spy")
                {
                    string codeNum = parts[4];
                    Spy spy = new Spy(id, firstName, lastName, codeNum);
                    soldiers.Add(spy);
                }

            }

            foreach (var item in soldiers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
