using System;
using System.Collections.Generic;

namespace Pizza_Calories
{
    class Topping
    {
        Dictionary<string, double> toppingIndex = new Dictionary<string, double>()
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9}
        };

        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;
            set
            {
                var valueToLower = value.ToLower();
                if (valueToLower != "meat" && valueToLower != "veggies" 
                    && valueToLower != "cheese" && valueToLower != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value.ToLower();
            }
        }

        public int Weight
        {
            get => weight;
            set
            {
                var type = Char.ToUpper(this.type[0]) + this.type.Substring(1);
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{type} weight should be in the range[1..50].");
                }
                weight = value;
            }
        }

        public double GetCal => 2 * Weight * toppingIndex[Type];
    }
}
