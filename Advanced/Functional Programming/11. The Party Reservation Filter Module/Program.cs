using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guest = new List<string>
                (Console.ReadLine().Split());
            List<string> filters = new List<string>();
            string input = Console.ReadLine();

            while (input != "Print")
            {
                string[] comands = input.Split(";");

                if (comands[0] == "Add filter")
                {
                    filters.Add(comands[1] + " " + comands[2]);
                }
                else if (comands[0] == "Remove filter")
                {
                    filters.Remove(comands[1] + " " + comands[2]);
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                string[] comand = filter.Split(" ");

                if (comand[0] == "Starts")
                {
                    guest = guest.Where(p => !p.StartsWith((comand[2]))).ToList();
                }
                else if (comand[0] == "Ends")
                {
                    guest = guest.Where(p => !p.EndsWith((comand[2]))).ToList();

                }
                else if (comand[0] == "Length")
                {
                    guest = guest.Where(p => p.Length != int.Parse(comand[1])).ToList();

                }
                else if (comand[0] == "Contains")
                {
                    guest = guest.Where(p => !p.Contains((comand[1]))).ToList();

                }
            }

            if (guest.Any())
            {
                Console.WriteLine(string.Join(" ", guest));
            }
        }
    }
}
