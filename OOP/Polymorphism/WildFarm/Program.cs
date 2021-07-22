using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Foods;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input is "End")
                {
                    break;
                }

                string[] animalParts = input.Split(); 
                string type = animalParts[0];
                string name = animalParts[1];
                double weight = double.Parse(animalParts[2]);
                Animal animal;

                if (type is "Owl")
                {
                    double wingsSize = double.Parse(animalParts[3]);
                    animal = new Owl(name, weight, wingsSize);
                }
                else if (type is "Hen")
                {
                    double wingsSize = double.Parse(animalParts[3]);
                    animal = new Hen(name, weight, wingsSize);
                }
                else if (type is "Mouse")
                {
                    string leavingRegion = animalParts[3];
                    animal = new Mouse(name, weight, leavingRegion);
                }
                else if (type is "Dog")
                {
                    string leavingRegion = animalParts[3];
                    animal = new Dog(name, weight, leavingRegion);
                }
                else if (type is "Cat")
                {
                    string leavingRegion = animalParts[3];
                    string breed = animalParts[4];
                    animal = new Cat(name, weight, leavingRegion, breed);
                }
                else if (type is "Tiger")
                {
                    string leavingRegion = animalParts[3];
                    string breed = animalParts[4];
                    animal = new Tiger(name, weight, leavingRegion, breed);
                }
                else
                {
                    throw new ArgumentException("Invalid animal");
                }
                animals.Add(animal);


                string[] foodParts = Console.ReadLine().Split();
                string foodType = foodParts[0];
                int quantity = int.Parse(foodParts[1]);
                Food food;

                if (foodType is "Vegetable")
                {
                    food = new Vegetable(quantity);
                }
                else if (foodType is "Fruit")
                {
                    food = new Fruit(quantity);
                }
                else if (foodType is "Meat")
                {
                    food = new Meat(quantity);
                }
                else if (foodType is "Seeds")
                {
                    food = new Seeds(quantity);
                }
                else
                {
                    throw new ArgumentException("Invalid Food");
                }

                Console.WriteLine(animal.Sound());
                animal.Eat(food);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
