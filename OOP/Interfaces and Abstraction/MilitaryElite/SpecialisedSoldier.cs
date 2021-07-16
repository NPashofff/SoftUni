namespace MilitaryElite
{
    using System;
    using System.Text;

    public abstract class SpecialisedSoldier : Private
    {
        private string corps;

        public string Corps
        {
            get { return corps; }
            set
            {
                if (value == "Airforces" || value == "Marines")
                {
                    corps = value;
                }
            }
        }

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");
            return sb.ToString().TrimEnd();
        }
    }
}
