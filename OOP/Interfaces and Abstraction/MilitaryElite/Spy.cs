namespace MilitaryElite
{
    using System;
    public class Spy : Soldier
    {
        public Spy(int id, string firstName, string lastName, string codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }
        public string CodeNumber { get; set; }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Code Number: {CodeNumber}";
        }
    }
}
