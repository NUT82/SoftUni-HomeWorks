using System;
using System.Diagnostics.CodeAnalysis;

namespace EqualityLogic
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo([AllowNull] Person other)
        {
            if (Name.CompareTo(other.Name) == 0)
            {
                return Age.CompareTo(other.Age);
            }

            return Name.CompareTo(other.Name);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }

        public override bool Equals(object obj) => this.GetHashCode() == obj.GetHashCode();
    }
}
