using PersonInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Pet : IBirthable, IPet
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Birthdate { get; set; }
        public string Name { get; set; }
    }
}
