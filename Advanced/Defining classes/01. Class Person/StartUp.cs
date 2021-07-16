using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //string name = "Pesho";
            //int age = 24;
            //Person pesho = new Person()
            //{
            //    Name = name,
            //    Age = age
            //};
            //Console.WriteLine($"{pesho.Name} {pesho.Age}");

            //Console.WriteLine(" ---------------- ");
            //Person noName = new Person();
            //Console.WriteLine($"{noName.Name} {noName.Age}");
            //Person goegi = new Person(24);
            //Console.WriteLine($"{goegi.Name} {goegi.Age}");
            //Person ivan = new Person("Ivan", 27);
            //Console.WriteLine($"{ivan.Name} {ivan.Age}");

            //int n = int.Parse(Console.ReadLine());
            //Familiy famili = new Familiy();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split();
            //    string name = input[0];
            //    int age = int.Parse(input[1]);
            //    Person person = new Person(name, age);
            //    famili.AddMember(person);
            //}

            //// Console.WriteLine(famili.GetOdestMember());

            //HashSet<Person> peopleAbove30 = famili.GetAllAbove30();
            //Console.WriteLine(string.Join(Environment.NewLine, peopleAbove30));
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string displacement = "n/a";
                string efficiency = "n/a";
                InputMethod(input, ref displacement, ref efficiency);

                Engine engine = new Engine
                {
                    Model = input[0],
                    Power = input[1],
                    Displacement = displacement,
                    Efficiency = efficiency
                };
                engines.Add(input[0], engine);
            }

            List<Car> cars = new List<Car>();
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = engines[input[1]];
                string weight = "n/a";
                string color = "n/a";
                InputMethod(input, ref weight, ref color);

                Car car = new Car
                {
                    Model = input[0],
                    Engine = engine,
                    Weight = weight,
                    Color = color
                };
                cars.Add(car);
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item);

            }
        }

        private static void InputMethod(string[] input, ref string displacement, ref string efficiency)
        {
            int num = 0;

            if (input.Length == 3)
            {
                if (int.TryParse(input[2], out num))
                {
                    displacement = num.ToString();
                }
                else
                {
                    efficiency = input[2];
                }

            }
            else if (input.Length > 3)
            {
                displacement = input[2];
                efficiency = input[3];
            }
        }
    }
}
