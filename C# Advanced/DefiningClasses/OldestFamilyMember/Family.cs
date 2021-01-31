using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {

        List<Person> FamilyMembers = new List<Person>();

        public void AddMember(Person member)
        {
            FamilyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            return FamilyMembers.OrderByDescending(m => m.Age).FirstOrDefault();
        }
    }
}
