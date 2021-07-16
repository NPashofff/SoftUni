using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<Private> Privates { get; set; }

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary,List<Private> privates) 
            : base(id, firstName, lastName, salary)
        {
            Privates = privates;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var item in Privates)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
