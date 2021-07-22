using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Tiger : Feline
    {
        private const double weightFactor = 1;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
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
            return "ROAR!!!";
        }

        public override string ToString()
        {
            return $"{GetType().Name}" + base.ToString();
        }
    }
}
