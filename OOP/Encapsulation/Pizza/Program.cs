using System;
using System.Collections.Generic;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string[] pizzaInput = Console.ReadLine().Split();
                string pizzaName = pizzaInput[1];
                List<Topping> toppings = new List<Topping>();

                string[] doughInput = Console.ReadLine().Split();
                string type = doughInput[1];
                string baking = doughInput[2];
                double gram = double.Parse(doughInput[3]);


                Dough dough = new Dough(type, baking, gram);




                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "END")
                    {
                        break;
                    }

                    string[] parts = input.Split();
                    string ingredient = parts[0];


                    if (ingredient == "Topping")
                    {
                        string name = parts[1];
                        double gramToping = double.Parse(parts[2]);
                        Topping topping = new Topping(name, gramToping);
                        toppings.Add(topping);
                    }
                    else
                    {
                        throw new Exception("Not Toping");
                    }


                }

                Pizza pizza = new Pizza(pizzaName, toppings, dough);
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCallories():f2} Calories.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
