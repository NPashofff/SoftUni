using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        public Dough Dough { get; set; }
        
        public Pizza(string name, List<Topping> toppings, Dough dough)
        {
            Name = name;
            Toppings = toppings;
            Dough = dough;
        }

        public IReadOnlyCollection<Topping> Toppings
        {
            get { return toppings.AsReadOnly(); }
            private set 
            {
                if (value.Count > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                toppings = (List<Topping>)value;
            }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value; 
            }
        }
        public double TotalCallories()
        {
            double sumToppings = 0;
            foreach (var item in toppings)
            {
                sumToppings += item.TopingTotalCalories();
            }
            return sumToppings + Dough.DoughTotalCalories();
        }

    }
}
