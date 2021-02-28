using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsePower, int fuel)
            : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 10;
        }
        public override double FuelConsumption => DefaultFuelConsumption / 100;
    }
}
