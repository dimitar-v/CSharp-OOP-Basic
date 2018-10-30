using System;
using System.Collections.Generic;

namespace Pizza_Calories
{
    class Dough
    {
        Dictionary<string, double> flourIndex = new Dictionary<string, double>()
        {
            { "white", 1.5 },
            { "wholegrain", 1.0}
        };

        Dictionary<string, double> bakingIndex = new Dictionary<string, double>()
        {
            { "crispy", 0.9 },
            { "chewy", 1.1},
            { "homemade", 1.0}
        };
        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(int weight, string flourType, string bakingTechnique)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => flourType;
            set
            {
                value = value.ToLower();
                if (value != "white" && value != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            set
            {
                value = value.ToLower();
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        public int Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }

        }

        public double GetCal => 2 * Weight * flourIndex[FlourType] * bakingIndex[BakingTechnique];
    }
}
