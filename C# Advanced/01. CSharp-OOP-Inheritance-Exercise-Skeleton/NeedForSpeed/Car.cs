using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, int fuel)
            : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 3;
        }

        public override double FuelConsumption => DefaultFuelConsumption / 100;
    }
}
