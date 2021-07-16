using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] inputPerson = Console.ReadLine()
               .Split(";", StringSplitOptions.RemoveEmptyEntries);
                List<Person> persons = new List<Person>();

                foreach (var item in inputPerson)
                {
                    string[] parts = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = parts[0];
                    decimal money = decimal.Parse(parts[1]);
                    Person person = new Person(name, money);
                    persons.Add(person);
                }

                string[] inputProducts = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                List<Product> products = new List<Product>();

                foreach (var item in inputProducts)
                {
                    string[] parts = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = parts[0];
                    decimal price = decimal.Parse(parts[1]);
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "END")
                    {
                        break;
                    }

                    string[] parts = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string personName = parts[0];
                    string productName = parts[1];

                    Console.WriteLine(persons.FirstOrDefault(x => x.Name == personName)
                        .Buy(products.FirstOrDefault(x => x.Name == productName)));

                }

                foreach (var item in persons)
                {
                    Console.WriteLine(item);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
           
        }
    }
}
