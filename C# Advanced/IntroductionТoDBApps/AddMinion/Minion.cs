using System;
using System.Collections.Generic;
using System.Text;

namespace AddMinion
{
    class Minion
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string TownName { get; set; }

        public Minion(string name, int age, string townName)
        {
            Name = name;
            Age = age;
            TownName = townName;
        }
    }
}
