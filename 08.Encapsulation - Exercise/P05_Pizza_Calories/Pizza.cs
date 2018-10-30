using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizza_Calories
{
    class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name)
        {
            Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }
        internal List<Topping> Toppings
        {
            get => toppings;
            set
            {
                if (toppings.Count > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                toppings = value;
            }
        }
        public Dough Dough { get => dough; set => dough = value; }

        public void AddTopping(Topping topping) 
            => this.Toppings.Add(topping);

        private double GetCallories 
            => Dough.GetCal + Toppings.Sum(t => t.GetCal);

        public override string ToString()
            => $"{Name} - {this.GetCallories:F2} Calories.";
    }
}
