using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    public class Person
    {

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        private decimal money;

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        private  List<Product> bag;

        public IReadOnlyCollection<Product> Bag
        {
            get { return bag.AsReadOnly(); }
        }

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public string Buy(Product product)
        {
            if (Money >= product.Price)
            {
                bag.Add(product);
                Money -= product.Price;
                return $"{Name} bought {product.Name}";
            }
            else
            {
                return $"{Name} can't afford {product.Name}";
            }
        }

        public override string ToString()
        {
            if (bag.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            else
            {
                return $"{Name} - {string.Join(", ", bag)}";
            }

        }
    }
}
