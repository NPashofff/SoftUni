using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier
    {
        public List<Mission> Missions { get; set; }

        public Commando(int id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions) 
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = missions;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            foreach (var item in Missions)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
