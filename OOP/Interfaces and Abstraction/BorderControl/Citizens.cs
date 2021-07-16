namespace BorderControl
{
    public class Citizens : ID , IBirthdate, IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Birthdate { get; set; }
        public int Food { get; set; }

        public Citizens(string name,int age, string id, string birthdate) 
            : base(id)
        {
            Name = name;
            Age = age;
            Birthdate = birthdate;
            Food = 0;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
