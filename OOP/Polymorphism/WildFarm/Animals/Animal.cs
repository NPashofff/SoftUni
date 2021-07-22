using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal 
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public string  Name { get; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public abstract void Eat(Food food);

        public abstract string Sound();

        public override string ToString()
        {
            return $" {Name} {Weight} ";
        }
    }
}
