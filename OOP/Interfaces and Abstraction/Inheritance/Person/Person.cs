using System;

namespace Person
{
    public class Person
    {
        public string Name { get; set; }

        private int age;

        public virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age canot be negative");
                }

                age = value;

            }
        }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

    }
}
