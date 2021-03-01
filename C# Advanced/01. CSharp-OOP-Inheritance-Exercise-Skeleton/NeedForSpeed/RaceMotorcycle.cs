using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, int fuel)
            : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 8;
        }
    }
}
