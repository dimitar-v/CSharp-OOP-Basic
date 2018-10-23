using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { this.engine = value; }
        }

        public string Color
        {
            get { return color; }
            set { this.color = value; }
        }

        public string Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }

        public override string ToString() =>
            this.Model + ":" + Environment.NewLine +
            "  " + this.Engine.Model + ":" + Environment.NewLine +
            "    Power: " + this.Engine.Power + Environment.NewLine +
            "    Displacement: " + this.Engine.Displacement + Environment.NewLine +
            "    Efficiency: " + this.Engine.Efficiency + Environment.NewLine +
            "  Weight: " + this.Weight + Environment.NewLine +
            "  Color: " + this.Color;
    }
}
