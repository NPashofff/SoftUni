using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double weightFactor = 0.10;

        public Mouse(string name, double weight,  string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Fruit || food is Vegetable)
            {
                Weight += food.Quantity * weightFactor;
                FoodEaten = food.Quantity;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string Sound()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return $"{GetType().Name}" + base.ToString();
        }
    }
}
