using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car()
        {
            Weight = "n/a";
            Color = "n/a";
        }

        public Car(string model, Engine engine)
            :this()
        {
            Model = model;
            Engine = engine;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public string Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Model}:");
            stringBuilder.AppendLine($"  {Engine.Model}:");
            stringBuilder.AppendLine($"    Power: {Engine.Power}");
            stringBuilder.AppendLine($"    Displacement: {Engine.Displacement}");
            stringBuilder.AppendLine($"    Efficiency: {Engine.Efficiency}");
            stringBuilder.AppendLine($"  Weight: {Weight}");
            stringBuilder.Append    ($"  Color: {Color}");

            return stringBuilder.ToString();
        }
    }
}
