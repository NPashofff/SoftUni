using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier
    {
        public List<Repair> Repairs { get; set; }
        public Engineer(int id, string firstName, string lastName, decimal salary, string corps, List<Repair> repairs) 
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = repairs;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());            
            sb.AppendLine("Repairs:");
            foreach (var item in Repairs)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
