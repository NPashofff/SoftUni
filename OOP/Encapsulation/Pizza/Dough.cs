using System;

namespace Pizza
{
    public class Dough
    {
        private string flourType;
        private double flourModifier;
        private const double caloriesPerGram = 2;
        private double flourBacingModifier;
        private string bakingTechnique;
        private double grams;
        
        public Dough(string flourType, string bakingTechnique, double grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Grams = grams;
        }

        public double Grams
        {
            get { return grams; }
            private set
            {
                if (value > 0 && value <= 200)
                {
                    grams = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (value.ToLower() == "crispy")
                {
                    bakingTechnique = value;
                    flourBacingModifier = 0.9;
                }
                else if (value.ToLower() == "chewy")
                {
                    bakingTechnique = value;
                    flourBacingModifier = 1.1;
                }
                else if (value.ToLower() == "homemade")
                {
                    bakingTechnique = value;
                    flourBacingModifier = 1.0;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (value.ToLower() == "white")
                {
                    flourType = value;
                    flourModifier = 1.5;
                }
                else if (value.ToLower() == "wholegrain")
                {
                    flourType = value;
                    flourModifier = 1.0;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public double DoughTotalCalories()
        {
            double calorie = (caloriesPerGram * grams) * flourModifier * flourBacingModifier;
            return calorie;
        }

    }
}
