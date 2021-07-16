namespace MilitaryElite
{
    using System;
    public class Mission
    {
        private string state;

        public Mission(string misionName, string state)
        {
            MisionName = misionName;
            State = state;
        }

        public string MisionName { get; set; }
        public string State
        {
            get => state;
            private set
            {
                if (value == "inProgress" || value == "Finished")
                {
                    state = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Mision");
                }
            }
        }

        public void CompleteMission()
        {
            if (State == "inProgress")
            {
                State = "Finished";
            }
        }
        public override string ToString()
        {
            return $"Code Name: {MisionName} State: {State}";
        }
    }

}
