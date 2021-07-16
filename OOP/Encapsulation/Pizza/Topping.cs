using System;
namespace Pizza
{
    public class Topping
    {
        private string typesTopping;
        private double grams;
        private const double caloriesPerGram = 2;
        private double toppingModifier;

        
        public Topping(string type, double grams)
        {
            TypesToping = type;
            Grams = grams;
        }
        public double Grams
        {
            get { return grams; }
            private set
            {
                if (value > 0 && value <= 50)
                {
                    grams = value;
                }
                else
                {
                    throw new ArgumentException($"{typesTopping} weight should be in the range [1..50].");
                }
                
            }
        }


        public string TypesToping
        {
            get { return typesTopping; }
            private set
            {
                if (value.ToLower() == "meat")
                {
                    typesTopping = value;
                    toppingModifier = 1.2;
                }
                else if (value.ToLower() == "veggies")
                {
                    typesTopping = value;
                    toppingModifier = 0.8;
                }
                else if (value.ToLower() == "cheese")
                {
                    typesTopping = value;
                    toppingModifier = 1.1;
                }
                else if (value.ToLower() == "sauce")
                {
                    typesTopping = value;
                    toppingModifier = 0.9;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }


        public double TopingTotalCalories()
        {
            return toppingModifier * caloriesPerGram * grams;
        }
    }
}
