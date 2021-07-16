namespace BorderControl
{
    public class Robots : ID
    {
        public string Model { get; set; }
        public Robots(string model, string id) 
            : base(id)
        {
            Model = model;
        }
    }
}
