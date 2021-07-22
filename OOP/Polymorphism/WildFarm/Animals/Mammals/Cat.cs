using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Cat : Feline
    {
        private const double weightFactor = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Meat || food is Vegetable)
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
            return "Meow";
        }

        public override string ToString()
        {
            return $"{GetType().Name}" + base.ToString();
        }
    }
}
