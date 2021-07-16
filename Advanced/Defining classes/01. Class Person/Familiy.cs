using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Familiy
    {
        private readonly HashSet<Person> members;

        public Familiy()
        {
            members = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOdestMember()
        {
            Person person = members.OrderByDescending(x => x.Age).FirstOrDefault();
            return person;
        }

        public HashSet<Person> GetAllAbove30()
            => members.Where(p => p.Age > 30)
            .OrderBy(p => p.Name)
            .ToHashSet();
    }

    
}
