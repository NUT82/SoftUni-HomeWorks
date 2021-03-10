﻿namespace MilitaryElite
{
    public class Repair
    {
        public Repair(string partName, int hours)
        {
            PartName = partName;
            Hours = hours;
        }

        public string PartName { get; set; }

        public int Hours { get; set; }

        public override string ToString()
        {
            return $"  Part Name: {PartName} Hours Worked: {Hours}";
        }
    }
}
