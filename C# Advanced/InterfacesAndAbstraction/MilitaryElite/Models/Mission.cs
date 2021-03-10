using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Mission
    {
        public Mission(string codeName, Enums.State state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName { get; set; }

        public Enums.State State { get; set; }

        public override string ToString()
        {
            return $"  Code Name: {CodeName} State: {State}";
        }
    }
}
